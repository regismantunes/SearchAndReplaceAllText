using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Microsoft.Win32;

namespace RA
{
    public static class TextFile
    {
        private static string GetNotepadPlusPlusOpenCommand()
        {
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(@"Applications\notepad++.exe\shell\open\command");
            if (registryKey == null)
                return null;

            return registryKey.GetValue(null) as string;
        }

        private static string GetNotepadOpenCommand()
        {
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(@"Applications\notepad.exe\shell\open\command");
            if (registryKey == null)
                return null;

            return registryKey.GetValue(null) as string;
        }

        public static void Open(string fileAddress)
        {
            string openCommand = GetNotepadPlusPlusOpenCommand();
            if (openCommand == null)
                openCommand = GetNotepadOpenCommand();

            int i = openCommand.IndexOf("\"%1\"");
            string exeAddress = openCommand.Substring(0, i - 1);

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo(exeAddress, $"\"{fileAddress}\"")
            };
            process.Start();
        }
    }
}
