using Homework8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProgramingHomework8.FileSearch;

namespace WindowsProgramingHomework8.Dialogs {
    public partial class SearchDialog : Form {
        private Transition last;
        private FileSearcher searcher;
        private BindingList<string> files;
        public SearchDialog() {
            InitializeComponent();
            files = new BindingList<string>();
            filesListBox.DataSource = files;
        }

        private void startSearchButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(fileExtensionDropDown.Text)) {
                MessageBox.Show("Please select a file extension from the drop down list.");
                return;
            }
            files.Clear();
            changeState(Transition.Run);
            searcher = new FileSearcher(fileExtensionDropDown.Text.Split(' ')[0]);
            searcher.NewFilesFound += Searcher_NewFilesFound;
            searcher.FileSearchCompleted += Searcher_FileSearchCompleted;
            searcher.RunSearch();
        }

        private void Searcher_FileSearchCompleted(object sender, EventArgs e) {
            MessageBox.Show($"Search Complete. Files found: {searcher.Found}");
            changeState(Transition.Stop);
        }

        private void pauseSearchButton_Click(object sender, EventArgs e) {
            if (last == Transition.Pause) {
                changeState(Transition.Continue);
                searcher.Resume();
            } else {
                changeState(Transition.Pause);
                searcher.Pause();
            }
        }
        private void stopSearchButton_Click(object sender, EventArgs e) {
            changeState(Transition.Stop);
            searcher.Cancel().ContinueWith((task) => {
                searcher = null;
                files.Clear();
            });//don't clear until the task is completely stopped/canceled
        }
        private void SearchDialog_FormClosing(object sender, FormClosingEventArgs e) {
            searcher?.Cancel();
        }
        private void Searcher_NewFilesFound(FileInfo[] filesPath) {
            this.Invoke(new AddFiles(addFiles),
                filesPath.Select((file) => file.FullName).ToList());
        }
        private delegate void AddFiles(List<string> filesPath);
        private void addFiles(List<string> filesPath) {
            filesPath.ToList()
                .ForEach((file) => files.Add(file));
        }

        private void changeState(Transition transition) {
            switch (transition) {
                case Transition.Run:
                    startSearchButton.Enabled = false;
                    pauseSearchButton.Enabled = true;
                    pauseSearchButton.Text = "Pause";
                    stopSearchButton.Enabled = true;
                    break;
                case Transition.Stop:
                    startSearchButton.Enabled = true;
                    pauseSearchButton.Enabled = false;
                    pauseSearchButton.Text = "Pause";
                    stopSearchButton.Enabled = false;
                    break;
                case Transition.Pause:
                    startSearchButton.Enabled = false;
                    pauseSearchButton.Enabled = true;
                    pauseSearchButton.Text = "Continue";
                    stopSearchButton.Enabled = true;
                    break;
                case Transition.Continue:
                    startSearchButton.Enabled = false;
                    pauseSearchButton.Enabled = true;
                    pauseSearchButton.Text = "Pause";
                    stopSearchButton.Enabled = true;
                    break;
            }
            last = transition;
        }

        private enum Transition {
            Run,
            Pause,
            Stop,
            Continue
        }

        private void fileExtensionDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            if (searcher != null) {
                searcher.extension = fileExtensionDropDown.Text.Split(' ')[0];
            }
        }

        private void filesListBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            int index = this.filesListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches) {
                FormMain.CreateTopLevelWindow(
                    filesListBox.Items[index] as string, UnityConfig.Container);
            }
        }
    }
}
