using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Collections;

namespace HamSpace
{
    class ProgramFinder
    {
        const int kMaxNumberOfApps = 1000;
        public ManagedApp[] managedApps = new ManagedApp[kMaxNumberOfApps];
        private void SearchForPrograms(RegistryKey currentKey)
        {
            object displayName = currentKey.GetValue("DisplayName");
            object uninstalString = currentKey.GetValue("UninstallString");
            object installString = currentKey.GetValue("InstallLocation");

            string sDisplayName = displayName    as string;
            string sUninstalString = uninstalString as string;
            string sInstallString = installString as string;

            int esotericCounter = programsList.Count;
            if (displayName != null && uninstalString != null && installString != null)
                if (displayName as string != "" && uninstalString as string != "" && installString as string != "")
                    AddToArray(displayName, installString, uninstalString);
            if (programsList.Count != esotericCounter)
            {
                programsListProper[plpc]  = displayName    as string;
                installListProper[plpc]   = installString  as string;
                uninstallListProper[plpc] = uninstalString as string;
                ManagedApp app = new ManagedApp(sDisplayName, sUninstalString, sInstallString);
                managedApps[plpc] = app;
                plpc++;


            }
            string[] subKeysArray = currentKey.GetSubKeyNames();
            foreach (string subKey in subKeysArray)
            {
                try
                {
                    RegistryKey newKey = currentKey.OpenSubKey(subKey);
                    if (newKey != null)
                        SearchForPrograms(currentKey.OpenSubKey(subKey));
                }
                catch (System.Security.SecurityException e)
                {
                }
            }
        }

        public HashSet<string> programsList = new HashSet<string>();
        public HashSet<string> installList = new HashSet<string>();
        public HashSet<string> uninstallList = new HashSet<string>();

        public string[] programsListProper = new string[kMaxNumberOfApps]; int plpc = 0;
        public string[] installListProper = new string[kMaxNumberOfApps]; int ilpc = 0;
        public string[] uninstallListProper = new string[kMaxNumberOfApps]; int ulpc = 0;

        Hashtable programTable = new Hashtable();
        private void AddToArray(object program, object install, object uninstall)
        {
            programsList.Add(program as string);
            installList.Add(install as string);
            uninstallList.Add(uninstall as string);

            //programTable.Add(program as string, install as string);
        }

        public bool StartSearch()
        {
            try
            {
                String uninst = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                RegistryKey r = Registry.LocalMachine.OpenSubKey(uninst);
                SearchForPrograms(Registry.CurrentUser.OpenSubKey("Software"));
                SearchForPrograms(Registry.LocalMachine.OpenSubKey("SOFTWARE"));
                SearchForPrograms(r);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool Dispose()
        {
            foreach (ManagedApp app in managedApps)
            {
                app.Dispose();
            }
            return true;
        }
    }
}
