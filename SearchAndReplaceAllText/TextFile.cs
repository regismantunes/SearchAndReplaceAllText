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

            string exeAddress;
            if (openCommand[0] == '"')
            {
                int i = openCommand.Substring(1).IndexOf('"') + 2;
                exeAddress = openCommand.Substring(0, i);
            }
            else
                exeAddress = openCommand.Split(' ')[0];

            Process.Start(exeAddress, $"\"{fileAddress}\"");
        }
    }
}
