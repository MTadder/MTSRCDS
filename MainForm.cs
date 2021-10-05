using System;
using System.IO;
using System.Windows.Forms;

namespace MTSRCDS {
#pragma warning disable IDE0022
    public partial class MainForm : Form {
        MTLibrary.DictionaryFile ArgumentsFile;
        MTLibrary.DictionaryFile SettingsFile;

        public MainForm() {
            this.InitializeComponent();

            this.SettingsFile = new("settings.bin", true);
            this.ArgumentsFile = new("arguments.bin", true);
            foreach (String arg in this.CBArgument.Items)
                if (!this.ArgumentsFile.IsKey(arg)) {
                    this.ArgumentsFile.Set(arg);
                }
        }
        private void MainForm_Load(Object sender, EventArgs e) {
            this.CBArgument.SelectedIndex = 0; this.CBOperation.SelectedIndex = 0;
            this.TBWorkingDir.Text = this.SettingsFile.Get("WorkingDirectory");
            if (this.TBWorkingDir.Text == String.Empty) {
                this.TBWorkingDir.Text = Environment.CurrentDirectory + @"\";
            }
            this.TBHostname.Text = this.SettingsFile.Get("Hostname");
            this.TBLoadingURL.Text = this.SettingsFile.Get("LoadingURL");
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
            this.SettingsFile.Set("LoadingURL", this.TBLoadingURL.Text);
        }

        private void TBHostname_TextChanged(Object sender, EventArgs e) {
            this.SettingsFile.Set("Hostname", this.TBHostname.Text);
        }

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e) {
            this.ArgumentsFile.Save();
            this.SettingsFile.Save();
        }

        private void TBWorkingDir_TextChanged(Object sender, EventArgs e) {
            String currentDir = this.TBWorkingDir.Text;
            Boolean isValidDir = 
                Directory.Exists(currentDir +@"\SteamCMD")
             &&
                File.Exists(currentDir + @"\SteamCMD\steamcmd.exe");
            this.CBWorkspaceValid.Checked = isValidDir;
            this.SettingsFile.Set("WorkingDirectory", currentDir);
        }

        private void CBWorkspaceValid_CheckedChanged(Object sender, EventArgs e) {
            this.BOpenLogs.Enabled = this.CBWorkspaceValid.Checked;
            this.BAddonMan.Enabled = this.CBWorkspaceValid.Checked;
        }

        private void BExecute_Click(Object sender, EventArgs e) {
            this.ArgumentsFile.Save();
            String currentDir = this.TBWorkingDir.Text;
            Boolean hasApp = File.Exists(currentDir +@"\srcds.exe");
            if (this.CBWorkspaceValid.Checked) {
                switch (this.CBOperation.Text) {
                    case "Update":
                        // TODO
                        return;
                    case "Start":
                        if (hasApp) {
                            return;
                        } else { break; }
                    case "Stop":
                        if (hasApp) {
                            return;
                        } else { break; }
                }
            } else {
                String title = "Invalid Workspace", msg = "Cannot Execute an invalid workspace." +
                    "Try Updating the Server first.";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BSendInput_Click(Object sender, EventArgs e) {
            String command = this.TBInput.Text.Trim();
            this.TBOutput.Text += command + Environment.NewLine;
        }
    }
#pragma warning restore IDE0022
}
