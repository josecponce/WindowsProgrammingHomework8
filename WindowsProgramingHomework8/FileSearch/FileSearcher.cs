using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsProgramingHomework8.FileSearch {
    //Change the configuration to Debug to see a list of folders that are being read.
    //Change to release to see just the folders that cannot be read.
    //The search will be faster in Release configuration
    public class FileSearcher {
        public delegate void FileFound(FileInfo[] filesPath);
        public event FileFound NewFileFound;

        private CancellationTokenSource cancelToken;
        private string extension;
        private bool paused;
        private object syncObj = new object();        

        public FileSearcher(string extension) {
            this.extension = extension;
            this.cancelToken = new CancellationTokenSource();
        }
        public void RunSearch() {
            Task.Run(() => Search(), cancelToken.Token);
        }
        public void Pause() {
            if (paused == false) {
                Monitor.Enter(syncObj);//gets the lock(which in turn pauses processing)
                paused = true;
            }
        }
        public void Resume() {
            if (paused) {
                paused = false;
                Monitor.Exit(syncObj);//release the lock
            }
        }
        public void Cancel() {
            cancelToken.Cancel();
        }        
        private void Search() {
            foreach (String drive in Directory.GetLogicalDrives()) {
                Debug.WriteLine(drive);
                foreach (DirectoryInfo child in getDirectories(drive)) {
                    Debug.WriteLine(child.FullName);
                    FindFiles(child);
                }
            }
        }

        private void FindFiles(DirectoryInfo dir) {
            lock (syncObj) { }//this will pause the execution            
            try {
                DirectoryInfo[] children = getDirectories(dir);
                if (children.Length > 0) {
                    foreach (DirectoryInfo child in children) {
                        Debug.WriteLine(child.FullName);
                        FindFiles(child);
                    }
                } else {
                    FileInfo[] Files = dir.GetFiles(extension);
                    if (Files.Length > 0) {
                        NewFileFound?.Invoke(Files);
                    }
                }
            } catch (Exception ex) {
                System.Console.WriteLine(ex.Message);
            }
        }

        private bool AttrOn(FileAttributes attr, FileAttributes field) {
            return (attr & field) == field;
        }

        private DirectoryInfo[] getDirectories(DirectoryInfo dir) {
            if (AttrOn(dir.Attributes, FileAttributes.Offline)) {
                Console.Out.WriteLine(dir.Name + " is not mapped ");
                return new DirectoryInfo[] { };
            }
            if (!dir.Exists) {
                Console.Out.WriteLine(dir.Name + " does not exist ");
                return new DirectoryInfo[] { };
            }
            try {
                return dir.GetDirectories();
            } catch (Exception ex) {
                Console.Out.WriteLine(ex.Message);
                Console.Out.WriteLine(ex.StackTrace);
                return new DirectoryInfo[] { };
            }
        }

        private DirectoryInfo[] getDirectories(String strDrive) {
            DirectoryInfo dir = new DirectoryInfo(strDrive);
            return getDirectories(dir);
        }
    }
}
