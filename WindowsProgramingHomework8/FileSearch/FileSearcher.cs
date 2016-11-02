using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsProgramingHomework8.FileSearch {
    //Change the configuration to Debug to see a list of folders that are being read.
    //Change to release to see just the folders that cannot be read.
    //The search will be faster in Release configuration
    public class FileSearcher {
        public delegate void FileFound(FileInfo[] filesPath);
        public event FileFound NewFilesFound;
        public event EventHandler FileSearchCompleted;

        private CancellationTokenSource cancelTokenSource;
        private CancellationToken cancelToken;
        private Task task;
        private List<Task> children = new List<Task>();
        public int Found { get; private set; } = 0;
        public bool Cancelled = false;

        public string extension { get; set; }
        private bool started;
        private bool paused;
        private object syncObj = new object();

        public FileSearcher(string extension) {
            this.extension = extension;
            cancelTokenSource = new CancellationTokenSource();
            cancelToken = cancelTokenSource.Token;
        }
        public void RunSearch() {
            if (started)
                throw new InvalidOperationException(
                    "A task can't be started more than once." + Environment.NewLine
                    + "If you need to run it again, use a new instance to do so.");
            started = true;
            task = Task.Run(() => Search(), cancelToken);
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
        public Task Cancel() {
            cancelTokenSource.Cancel();
            if (paused) {
                Monitor.Exit(syncObj);
                return Task.WhenAny(task);                
            }else {
                children.Add(task);
                return Task.WhenAll(children);
            }            
        }
        private void Search() {
            foreach (String drive in Directory.GetLogicalDrives()) {
                //Debug.WriteLine(drive);
                foreach (DirectoryInfo child in getDirectories(drive)) {
                    //Debug.WriteLine(child.FullName);
                    FindFiles(child);
                }
            }
            FileSearchCompleted?.Invoke(this, new EventArgs());
        }

        private void FindFiles(DirectoryInfo dir) {
            lock (syncObj) { }//this will pause the execution 
            
            //cancelToken.ThrowIfCancellationRequested();

            try {
                DirectoryInfo[] children = getDirectories(dir);
                if (children.Length > 0) {
                    foreach (DirectoryInfo child in children) {
                        //Debug.WriteLine(child.FullName);
                        FindFiles(child);
                    }
                } else {
                    FileInfo[] Files = dir.GetFiles(extension);
                    if (Files.Length > 0) {
                        Found += Files.Length;
                        this.children.Add(Task.Run(() => NewFilesFound?.Invoke(Files)));
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
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
