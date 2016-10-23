using Microsoft.Practices.Unity;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleInstanceApplicationLib {
    public class SingleInstanceApplication<T> : WindowsFormsApplicationBase where T : new() {
        private IUnityContainer container;

        public SingleInstanceApplication(IUnityContainer container) {
            this.container = container;
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }

        public void AddTopLevelForm(TopLevelForm<T> form) {
            form.Activated += TopLevelForm_Activated;
            form.FormClosed += TopLevelForm_FormClosed;
            AddWindowMenu(form);

            if (this.OpenForms.Count == 1) {
                this.MainForm = form;
            }
        }
        private void AddWindowMenu(TopLevelForm<T> windowsMenuForm) {
            windowsMenuForm.WindowsMenu.DropDownOpening +=
                WindowMenu_DropDownOpening;
        }
        protected override void OnCreateMainForm() {
            this.MainForm = CreateTopLevelWindow(CommandLineArgs);
        }

        private void WindowMenu_DropDownOpening(object sender, EventArgs e) {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            if (menu.DropDownItems.Count > 0) {
                menu.DropDown.Dispose();
            }

            menu.DropDown = new ToolStripDropDownMenu();
            PopulateWindowsMenu(menu.DropDown);
        }
        private void ContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            ContextMenuStrip menu = (ContextMenuStrip)sender;
            if (menu.Items.Count > 0) {
                menu.Items.Clear();
            }
            PopulateWindowsMenu(menu);
        }
        private void PopulateWindowsMenu(ToolStripDropDown menu) {
            foreach (Form form in this.OpenForms) {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = form.Text;
                item.Tag = form;
                menu.Items.Add(item);
                item.Click += WindowMenuItem_Click;

                if (form == this.MainForm) {
                    item.Checked = true;
                }
            }
        }

        private void WindowMenuItem_Click(object sender, EventArgs e) {
            ((Form)((ToolStripMenuItem)sender).Tag).Activate();
        }

        private void TopLevelForm_FormClosed(object sender, FormClosedEventArgs e) {
            Form form = (Form)sender;
            if (form == this.MainForm &&
                this.OpenForms.Count > 0) {
                this.MainForm = this.OpenForms[0];
            }
            form.Activated -= TopLevelForm_Activated;
            form.FormClosed -= TopLevelForm_FormClosed;
        }

        private void TopLevelForm_Activated(object sender, EventArgs e) {
            this.MainForm = (Form)sender;
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs) {
            CreateTopLevelWindow(eventArgs.CommandLine);
        }

        public TopLevelForm<T> CreateTopLevelWindow(ReadOnlyCollection<string> args) {
            string fileName = (args.Count > 0) ? args[0] : null;
            return TopLevelForm<T>.CreateTopLevelWindow(fileName, container);
        }
    }
}
