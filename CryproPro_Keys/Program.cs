using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace CryproPro_Keys
{
    internal static class Program
    {
        public static string CRYPTO_VERSION;
        public static string KEY;
        static readonly string file = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\CryproPro_key_info.txt";

        // ветка реестра КриптоПро
        static readonly string subkey1 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Installer\\UserData\\S-1-5-18\\Products\\";
        static readonly string[] subkeyVersions = { "05480A45343B0B0429E4860F13549069",
                "68A52D936E5ACF24C9F8FE4A1C830BC8",
                "7AB5E7046046FB044ACD63458B5F481C",
                "08F19F05793DC7340B8C2621D83E5BE5"
            };
        static readonly string subkey2 = "\\InstallProperties";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            // Определение разрядности
            RegistryView regView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            RegistryKey localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, regView);
            int index = 0;

            // Поиск ключа
            while (true)
            {
                try
                {
                    if (localKey.OpenSubKey(subkey1 + subkeyVersions[index] + subkey2) != null)
                    {
                        RegistryKey registryBranch = localKey.OpenSubKey(subkey1 + subkeyVersions[index] + subkey2);
                        CRYPTO_VERSION = $"КриптоПро {registryBranch.GetValue("DisplayVersion")}";
                        KEY = registryBranch.GetValue("ProductID").ToString();

                        // запись ключа в файл
                        StreamWriter writer = new StreamWriter(file, false);
                        string text = $"{CRYPTO_VERSION}\n{KEY}";
                        writer.WriteLine(text);
                        writer.Close();

                        break;
                    }
                    else
                        index++;
                }
                catch (IndexOutOfRangeException)
                {
                    CRYPTO_VERSION = "КриптоПро не установлен";
                    KEY = "";
                    break;
                }
            }

            Application.Run(new MainForm());
        }
    }
}
