using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MTSRCDS {
    public partial class MainForm : Form {
        Dictionary<String, String> arguments = new();
        Dictionary<String, DirectoryInfo> keyDirs = new();

        public MainForm() {
            this.InitializeComponent();

            // Fill arguments dictionary
            foreach(String arg in this.CBArgument.Items)
                this.arguments.Add(arg, String.Empty);
        }
        private void MainForm_Load(Object sender, EventArgs e) {

        }
        private void BExit_Click(Object sender, EventArgs e) {
            this.Close();
        }

        private void CBArgument_SelectedIndexChanged(Object sender, EventArgs e) {
            if (!this.CBLockAssigner.Checked) {
                this.TBArgValue.Text =
                    this.arguments[this.CBArgument.Text] ?? String.Empty;
            }
        }

        private void BRefreshArg_Click(Object sender, EventArgs e) {
            String got = this.arguments[this.CBArgument.Text] ?? String.Empty;
            if (String.IsNullOrEmpty(got) || got != this.TBArgValue.Text) {
                this.arguments[this.CBArgument.Text] = this.TBArgValue.Text;
            } else {
                this.TBArgValue.Text = got.Trim();
            }
        }

    }
}
