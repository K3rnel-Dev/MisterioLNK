using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MisteryLnk.Algorithms
{
    internal class Obfuscator
    {
        #region BatObfuscator
        public static string BatObfuscator(string batchCode)
        {
            try
            {
                StringBuilder obfuscatedCode = new StringBuilder();
                string[] lines = batchCode.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                obfuscatedCode.AppendLine("::obfuscated by MisterioLNK");

                foreach (string line in lines)
                {
                    StringBuilder obfuscatedLine = new StringBuilder();
                    bool inPercent = false;
                    foreach (char ch in line)
                    {
                        if (!inPercent)
                        {
                            if (ch == '%')
                            {
                                obfuscatedLine.Append(ch);
                                inPercent = true;
                            }
                            else
                            {
                                int randomLength = new Random().Next(1, 11);
                                string randomString = RandomString(randomLength);
                                obfuscatedLine.Append($"{ch}%{randomString}%");
                            }
                        }
                        else
                        {
                            if (ch == '%')
                            {
                                obfuscatedLine.Append(ch);
                                inPercent = false;
                            }
                            else
                            {
                                obfuscatedLine.Append(ch);
                            }
                        }
                    }
                    obfuscatedCode.AppendLine(obfuscatedLine.ToString());
                }

                return obfuscatedCode.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("~ Internal Error ~", $"Internal Building Error: {ex}");
                return null;
            }
        }

        #endregion
        #region VBSObfuscator
        public static string VBSObfuscator(string vbsCode)
        {
            StringBuilder obfuscatedCode = new StringBuilder();
            Random random = new Random();

            foreach (char ch in vbsCode)
            {
                obfuscatedCode.Append($"Chr({(int)ch})&");
            }

            // Убираем последний амперсанд '&'
            if (obfuscatedCode.Length > 0)
            {
                obfuscatedCode.Length--;
            }

            return $"Execute({obfuscatedCode.ToString()})";
        }
        #endregion
        /*        public static string HTAObfuscator(string htaCode)
                {
                    StringBuilder obfuscatedCode = new StringBuilder();

                    foreach (char ch in htaCode)
                    {
                        string charCode;
                        switch (ch)
                        {
                            case '"':
                                charCode = "\\\"";
                                break;
                            case '\\':
                                charCode = "\\\\";
                                break;
                            default:
                                charCode = $"String.fromCharCode({(int)ch})";
                                break;
                        }

                        obfuscatedCode.Append(charCode);
                    }
                    string obfuscatedScript = $"<script>eval(\"{obfuscatedCode.ToString()}\");</script>";
                    return obfuscatedScript;
                }*/
        #region HelperFunctions
        private static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789卐☀☁☂☃☼☽★☆☾℃℉☀ -‘๑’-☁ϟ☂︸☃⁂☼☽✩✪✫✬✭✮✯✰牡マキグナルファ系路克瑞大阪市立学鎰命科ャマ能力ϒ人は妻スティ要望通り玉宏¥サ丹谷Ѫ灯影伝鶐ԱաԲբԳգԴդԵեԶզԷէԸըԹթԺժԻиԼլԽխԾծԿկՀհՁձՂղՃճՄмՅյՆնՇշՈոՉчПпՋջՌрՍսՎвՏтՐрՑцՒуՓпՔкՕоՖфლ(´ڡ`ლ)ლ(ಠ益ಠლ)ლ(╹◡╹ლ)ლ(◉◞౪◟◉‵ლヾ(⌐■_■)ノ♪(◕‿◕)| (• ◡•)|(❍ᴥ❍ʋ)⒑⒒⒓⒔⒕⒖⒗⒘⒙⒚⒛";
            char[] charArray = chars.ToCharArray();
            Random rng = new Random();
            int n = charArray.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                char value = charArray[k];
                charArray[k] = charArray[n];
                charArray[n] = value;
            }
            StringBuilder randomString = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                randomString.Append(charArray[rng.Next(charArray.Length)]);
            }
            return randomString.ToString();
        }
        #endregion
    }
}
