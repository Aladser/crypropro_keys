using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace CryproPro_Keys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            

            string subKey1 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Installer\\UserData\\S-1-5-18\\Products\\";
            string[] versions = { "05480A45343B0B0429E4860F13549069", "68A52D936E5ACF24C9F8FE4A1C830BC8", "7AB5E7046046FB044ACD63458B5F481C", "08F19F05793DC7340B8C2621D83E5BE5" };
            string subKey2 = "\\InstallProperties";
            // Определение разрядности
            RegistryKey localKey;
            if (Environment.Is64BitOperatingSystem)
                localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            else
                localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

            int index = 0;
            // Поиск ключа
            while (true)
            {
                if (localKey.OpenSubKey(subKey1 + versions[index] + subKey2) != null)
                {
                    string cryproVersion = localKey.OpenSubKey(subKey1 + versions[index] + subKey2).GetValue("DisplayVersion").ToString();
                    string key = localKey.OpenSubKey(subKey1 + versions[index] + subKey2).GetValue("ProductID").ToString();
                    this.version_Field.Text = "КриптоПро " + cryproVersion;
                    this.key_Field.Text = key;
                    break;
                }
                else
                {
                    if(index == 4)
                    {
                        this.version_Field.Text = "КриптоПро не установлен";
                        this.key_Field.Text = "";
                        break;
                    }
                    index++;
                }
            }
        }
    }
}
