using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HamSpace
{
    public class HamUtils
    {
        public const string DECOY_NAME = "!";
        public const string LOCKED_NAME = "!!";
    }

    public class NotHamManageableException : Exception
    {
        public NotHamManageableException(string message)
            : base(message)
        {
        }
    }
    public class ManagedApp : IDisposable
    {
        private string installPathDecoy;
        private string installPathLocked;
        private string installPathDecoyUninst;
        private string installPathLockedUninst;
        FileSystemWatcher fileDecoyWatch;
        FileSystemWatcher fileDecoyWatchUninst;
        FileStream fs;
        FileStream fsuninst;
        public ManagedApp(string name, string installPath, string uninstallPath)
        {
            installPathDecoy = Path.Combine(installPath, HamUtils.DECOY_NAME);
            installPathLocked = Path.Combine(installPath, HamUtils.LOCKED_NAME);
            installPathDecoyUninst = Path.Combine(uninstallPath, HamUtils.DECOY_NAME);
            installPathLockedUninst = Path.Combine(uninstallPath, HamUtils.LOCKED_NAME);

            if (!File.Exists(installPathDecoy))
            {
                if(!installPath.Equals(""))
                {
                    FileStream decoyFS = File.Create(installPathDecoy);
                    decoyFS.Close();
                    this.fileDecoyWatch = new FileSystemWatcher(installPathDecoy);
                }
                
            }
            else
            {
                throw new NotHamManageableException("This is already managed by HAM, or something is really wrong.");
            }

            if (!File.Exists(installPathDecoyUninst))
            {
                if (!uninstallPath.Equals(""))
                {
                    FileStream decoyFSUninst = File.Create(installPathDecoyUninst);
                    decoyFSUninst.Close();
                    this.fileDecoyWatchUninst = new FileSystemWatcher(installPathDecoyUninst);
                }
            }
            else
            {
                throw new NotHamManageableException("This is already managed by HAM, or something is really wrong.");
            }
            if (fileDecoyWatch != null)
            {
                fs = File.Open(installPathLocked, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                this.fileDecoyWatch.Deleted += new FileSystemEventHandler(fileDecoyWatch_Deleted);
            }
            if (fileDecoyWatchUninst != null)
            {
                fsuninst = File.Open(installPathLockedUninst, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                this.fileDecoyWatchUninst.Deleted += new FileSystemEventHandler(fileDecoyWatchUninst_Deleted);
            }
        }

        void fileDecoyWatchUninst_Deleted(object sender, FileSystemEventArgs e)
        {
            if (!File.Exists(installPathDecoyUninst))
            {
                FileStream decoyFSUninst = File.Create(installPathDecoyUninst);
                decoyFSUninst.Close();
                this.fileDecoyWatchUninst = new FileSystemWatcher(installPathDecoyUninst);
            }
        }

        void fileDecoyWatch_Deleted(object sender, FileSystemEventArgs e)
        {
            if (!File.Exists(installPathDecoy))
            {
                FileStream decoyFS = File.Create(installPathDecoy);
                decoyFS.Close();
                this.fileDecoyWatch = new FileSystemWatcher(installPathDecoy);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            fs.Close();
            fsuninst.Close();
            File.Delete(installPathDecoy);
            File.Delete(installPathLocked);
            File.Delete(installPathDecoyUninst);
            File.Delete(installPathLockedUninst);
        }
        
    }
}
