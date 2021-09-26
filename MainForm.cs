using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MTSRCDS {
    public partial class MainForm : Form {
        MTLibrary.DictionaryFile ArgumentsFile;

        public MainForm() {
            this.InitializeComponent();

            this.ArgumentsFile = new("arguments.bin", true);
            foreach(String arg in this.CBArgument.Items)
                if (!this.ArgumentsFile.IsKey(arg)) {
                    this.ArgumentsFile.Set(arg);
                }
        }
        private void MainForm_Load(Object sender, EventArgs e) {
            this.TBWorkingDir.Text = Environment.CurrentDirectory + @"\";
            CBArgument.SelectedIndex = 0;
            TBHostname.Text = this.ArgumentsFile.Get("Hostname");
            TBLoadingURL.Text = this.ArgumentsFile.Get("LoadingURL");
        }
        private void BExit_Click(Object sender, EventArgs e) => this.Close();

        private void CBArgument_SelectedIndexChanged(Object sender, EventArgs e) {
            if (!this.CBLockAssigner.Checked) {
                String selectedArg = this.CBArgument.Text.Trim();
                this.TBArgValue.Text = this.ArgumentsFile.Get(selectedArg);
            }
        }

        private void BInterpArg_Click(Object sender, EventArgs e) {
            String selectedArg = this.CBArgument.Text.Trim();
            String storedArg = this.ArgumentsFile.Get(selectedArg);
            String candidateArg = this.TBArgValue.Text.Trim();
            if (candidateArg.Equals(storedArg) == false
                && candidateArg.Equals(String.Empty) == false) {
                this.ArgumentsFile.Set(selectedArg, candidateArg);
            } else {
                if (CBLockAssigner.Checked) {
                    this.ArgumentsFile.Set(selectedArg, String.Empty);
                } else {
                    this.TBArgValue.Text = storedArg;
                }
            }
        }

        private void CBLockAssigner_CheckedChanged(Object sender, EventArgs e) {
            this.TBArgValue.Enabled = !this.CBLockAssigner.Checked;
        }

        private void TBLoadingURL_TextChanged(Object sender, EventArgs e) {
            this.ArgumentsFile.Set("LoadingURL", this.TBLoadingURL.Text);
        }

        private void TBHostname_TextChanged(Object sender, EventArgs e) {
            this.ArgumentsFile.Set("Hostname", this.TBHostname.Text);
        }

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e) {
            this.ArgumentsFile.Save();
        }

        private void TBWorkingDir_TextChanged(Object sender, EventArgs e) {

        }
    }
}
