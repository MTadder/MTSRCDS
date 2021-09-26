
namespace MTSRCDS {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BExit = new System.Windows.Forms.Button();
            this.PParameters = new System.Windows.Forms.Panel();
            this.GBArgs = new System.Windows.Forms.GroupBox();
            this.CBLockAssigner = new System.Windows.Forms.CheckBox();
            this.BInterpArg = new System.Windows.Forms.Button();
            this.LArgIdentifier = new System.Windows.Forms.Label();
            this.TBArgValue = new System.Windows.Forms.TextBox();
            this.CBArgument = new System.Windows.Forms.ComboBox();
            this.GBEnv = new System.Windows.Forms.GroupBox();
            this.GBWorkspace = new System.Windows.Forms.GroupBox();
            this.CBWorkspaceValid = new System.Windows.Forms.CheckBox();
            this.BOpenLogs = new System.Windows.Forms.Button();
            this.BAddonMan = new System.Windows.Forms.Button();
            this.TBWorkingDir = new System.Windows.Forms.TextBox();
            this.PExecution = new System.Windows.Forms.Panel();
            this.BExecute = new System.Windows.Forms.Button();
            this.PBStatus = new System.Windows.Forms.ProgressBar();
            this.TBLoadingURL = new System.Windows.Forms.TextBox();
            this.TBHostname = new System.Windows.Forms.TextBox();
            this.PDetails = new System.Windows.Forms.Panel();
            this.GBOutput = new System.Windows.Forms.GroupBox();
            this.TBOutput = new System.Windows.Forms.TextBox();
            this.PParameters.SuspendLayout();
            this.GBArgs.SuspendLayout();
            this.GBEnv.SuspendLayout();
            this.GBWorkspace.SuspendLayout();
            this.PExecution.SuspendLayout();
            this.PDetails.SuspendLayout();
            this.GBOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // BExit
            // 
            this.BExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BExit.Location = new System.Drawing.Point(0, 377);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(900, 23);
            this.BExit.TabIndex = 0;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = false;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // PParameters
            // 
            this.PParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PParameters.BackColor = System.Drawing.SystemColors.Control;
            this.PParameters.Controls.Add(this.GBArgs);
            this.PParameters.Controls.Add(this.GBEnv);
            this.PParameters.Location = new System.Drawing.Point(12, 12);
            this.PParameters.Name = "PParameters";
            this.PParameters.Padding = new System.Windows.Forms.Padding(5);
            this.PParameters.Size = new System.Drawing.Size(300, 359);
            this.PParameters.TabIndex = 1;
            // 
            // GBArgs
            // 
            this.GBArgs.Controls.Add(this.CBLockAssigner);
            this.GBArgs.Controls.Add(this.BInterpArg);
            this.GBArgs.Controls.Add(this.LArgIdentifier);
            this.GBArgs.Controls.Add(this.TBArgValue);
            this.GBArgs.Controls.Add(this.CBArgument);
            this.GBArgs.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBArgs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GBArgs.Location = new System.Drawing.Point(5, 161);
            this.GBArgs.Name = "GBArgs";
            this.GBArgs.Size = new System.Drawing.Size(290, 107);
            this.GBArgs.TabIndex = 1;
            this.GBArgs.TabStop = false;
            this.GBArgs.Text = "Argument";
            // 
            // CBLockAssigner
            // 
            this.CBLockAssigner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBLockAssigner.AutoSize = true;
            this.CBLockAssigner.Location = new System.Drawing.Point(124, 81);
            this.CBLockAssigner.Name = "CBLockAssigner";
            this.CBLockAssigner.Size = new System.Drawing.Size(82, 19);
            this.CBLockAssigner.TabIndex = 4;
            this.CBLockAssigner.Text = "Lock Value";
            this.CBLockAssigner.UseVisualStyleBackColor = true;
            this.CBLockAssigner.CheckedChanged += new System.EventHandler(this.CBLockAssigner_CheckedChanged);
            // 
            // BInterpArg
            // 
            this.BInterpArg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BInterpArg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BInterpArg.Location = new System.Drawing.Point(212, 77);
            this.BInterpArg.Name = "BInterpArg";
            this.BInterpArg.Size = new System.Drawing.Size(75, 23);
            this.BInterpArg.TabIndex = 3;
            this.BInterpArg.Text = "Set/Get";
            this.BInterpArg.UseVisualStyleBackColor = true;
            this.BInterpArg.Click += new System.EventHandler(this.BInterpArg_Click);
            // 
            // LArgIdentifier
            // 
            this.LArgIdentifier.AutoSize = true;
            this.LArgIdentifier.Location = new System.Drawing.Point(3, 51);
            this.LArgIdentifier.Name = "LArgIdentifier";
            this.LArgIdentifier.Size = new System.Drawing.Size(15, 15);
            this.LArgIdentifier.TabIndex = 2;
            this.LArgIdentifier.Text = "is";
            // 
            // TBArgValue
            // 
            this.TBArgValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBArgValue.Location = new System.Drawing.Point(24, 48);
            this.TBArgValue.Name = "TBArgValue";
            this.TBArgValue.PlaceholderText = "null";
            this.TBArgValue.Size = new System.Drawing.Size(263, 23);
            this.TBArgValue.TabIndex = 1;
            this.TBArgValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CBArgument
            // 
            this.CBArgument.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBArgument.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBArgument.FormattingEnabled = true;
            this.CBArgument.Items.AddRange(new object[] {
            "-game",
            "-32bit",
            "-high",
            "-highjack",
            "-insecure",
            "-threads",
            "-heapsize",
            "-authkey",
            "-nobots",
            "+map",
            "+maxplayers",
            "+host_workshop_collection",
            "+gamemode",
            "+port"});
            this.CBArgument.Location = new System.Drawing.Point(3, 19);
            this.CBArgument.MaxDropDownItems = 10;
            this.CBArgument.Name = "CBArgument";
            this.CBArgument.Size = new System.Drawing.Size(284, 23);
            this.CBArgument.TabIndex = 0;
            this.CBArgument.SelectedIndexChanged += new System.EventHandler(this.CBArgument_SelectedIndexChanged);
            // 
            // GBEnv
            // 
            this.GBEnv.BackColor = System.Drawing.SystemColors.Control;
            this.GBEnv.Controls.Add(this.GBWorkspace);
            this.GBEnv.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBEnv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GBEnv.Location = new System.Drawing.Point(5, 5);
            this.GBEnv.Name = "GBEnv";
            this.GBEnv.Size = new System.Drawing.Size(290, 156);
            this.GBEnv.TabIndex = 0;
            this.GBEnv.TabStop = false;
            this.GBEnv.Text = "Environment";
            // 
            // GBWorkspace
            // 
            this.GBWorkspace.Controls.Add(this.CBWorkspaceValid);
            this.GBWorkspace.Controls.Add(this.BOpenLogs);
            this.GBWorkspace.Controls.Add(this.BAddonMan);
            this.GBWorkspace.Controls.Add(this.TBWorkingDir);
            this.GBWorkspace.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBWorkspace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GBWorkspace.Location = new System.Drawing.Point(3, 19);
            this.GBWorkspace.Name = "GBWorkspace";
            this.GBWorkspace.Size = new System.Drawing.Size(284, 78);
            this.GBWorkspace.TabIndex = 2;
            this.GBWorkspace.TabStop = false;
            this.GBWorkspace.Text = "Workspace";
            // 
            // CBWorkspaceValid
            // 
            this.CBWorkspaceValid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBWorkspaceValid.AutoSize = true;
            this.CBWorkspaceValid.Enabled = false;
            this.CBWorkspaceValid.Location = new System.Drawing.Point(222, 0);
            this.CBWorkspaceValid.Name = "CBWorkspaceValid";
            this.CBWorkspaceValid.Size = new System.Drawing.Size(56, 19);
            this.CBWorkspaceValid.TabIndex = 3;
            this.CBWorkspaceValid.Text = "Valid?";
            this.CBWorkspaceValid.UseVisualStyleBackColor = true;
            // 
            // BOpenLogs
            // 
            this.BOpenLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BOpenLogs.Enabled = false;
            this.BOpenLogs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BOpenLogs.Location = new System.Drawing.Point(6, 49);
            this.BOpenLogs.Name = "BOpenLogs";
            this.BOpenLogs.Size = new System.Drawing.Size(65, 23);
            this.BOpenLogs.TabIndex = 2;
            this.BOpenLogs.Text = "Logs";
            this.BOpenLogs.UseVisualStyleBackColor = true;
            // 
            // BAddonMan
            // 
            this.BAddonMan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BAddonMan.Enabled = false;
            this.BAddonMan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BAddonMan.Location = new System.Drawing.Point(175, 49);
            this.BAddonMan.Name = "BAddonMan";
            this.BAddonMan.Size = new System.Drawing.Size(106, 23);
            this.BAddonMan.TabIndex = 1;
            this.BAddonMan.Text = "Manage Addons";
            this.BAddonMan.UseVisualStyleBackColor = true;
            // 
            // TBWorkingDir
            // 
            this.TBWorkingDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBWorkingDir.Location = new System.Drawing.Point(3, 19);
            this.TBWorkingDir.Name = "TBWorkingDir";
            this.TBWorkingDir.PlaceholderText = "...\\";
            this.TBWorkingDir.ReadOnly = true;
            this.TBWorkingDir.Size = new System.Drawing.Size(278, 23);
            this.TBWorkingDir.TabIndex = 0;
            this.TBWorkingDir.TextChanged += new System.EventHandler(this.TBWorkingDir_TextChanged);
            // 
            // PExecution
            // 
            this.PExecution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PExecution.BackColor = System.Drawing.SystemColors.Control;
            this.PExecution.Controls.Add(this.BExecute);
            this.PExecution.Controls.Add(this.PBStatus);
            this.PExecution.Location = new System.Drawing.Point(318, 289);
            this.PExecution.Name = "PExecution";
            this.PExecution.Size = new System.Drawing.Size(570, 82);
            this.PExecution.TabIndex = 2;
            // 
            // BExecute
            // 
            this.BExecute.Dock = System.Windows.Forms.DockStyle.Right;
            this.BExecute.Location = new System.Drawing.Point(495, 0);
            this.BExecute.Name = "BExecute";
            this.BExecute.Size = new System.Drawing.Size(75, 59);
            this.BExecute.TabIndex = 1;
            this.BExecute.Text = "Execute";
            this.BExecute.UseVisualStyleBackColor = true;
            // 
            // PBStatus
            // 
            this.PBStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBStatus.Location = new System.Drawing.Point(0, 59);
            this.PBStatus.Name = "PBStatus";
            this.PBStatus.Size = new System.Drawing.Size(570, 23);
            this.PBStatus.TabIndex = 0;
            // 
            // TBLoadingURL
            // 
            this.TBLoadingURL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TBLoadingURL.Location = new System.Drawing.Point(5, 217);
            this.TBLoadingURL.Name = "TBLoadingURL";
            this.TBLoadingURL.PlaceholderText = "Loading Screen URL";
            this.TBLoadingURL.Size = new System.Drawing.Size(560, 23);
            this.TBLoadingURL.TabIndex = 2;
            this.TBLoadingURL.TextChanged += new System.EventHandler(this.TBLoadingURL_TextChanged);
            // 
            // TBHostname
            // 
            this.TBHostname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TBHostname.Location = new System.Drawing.Point(5, 240);
            this.TBHostname.Name = "TBHostname";
            this.TBHostname.PlaceholderText = "Server Hostname";
            this.TBHostname.Size = new System.Drawing.Size(560, 23);
            this.TBHostname.TabIndex = 1;
            this.TBHostname.TextChanged += new System.EventHandler(this.TBHostname_TextChanged);
            // 
            // PDetails
            // 
            this.PDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PDetails.BackColor = System.Drawing.SystemColors.Control;
            this.PDetails.Controls.Add(this.TBLoadingURL);
            this.PDetails.Controls.Add(this.GBOutput);
            this.PDetails.Controls.Add(this.TBHostname);
            this.PDetails.Location = new System.Drawing.Point(318, 12);
            this.PDetails.Margin = new System.Windows.Forms.Padding(5);
            this.PDetails.Name = "PDetails";
            this.PDetails.Padding = new System.Windows.Forms.Padding(5);
            this.PDetails.Size = new System.Drawing.Size(570, 268);
            this.PDetails.TabIndex = 3;
            // 
            // GBOutput
            // 
            this.GBOutput.BackColor = System.Drawing.SystemColors.Control;
            this.GBOutput.Controls.Add(this.TBOutput);
            this.GBOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GBOutput.Location = new System.Drawing.Point(5, 5);
            this.GBOutput.Name = "GBOutput";
            this.GBOutput.Size = new System.Drawing.Size(560, 162);
            this.GBOutput.TabIndex = 0;
            this.GBOutput.TabStop = false;
            this.GBOutput.Text = "Output";
            // 
            // TBOutput
            // 
            this.TBOutput.BackColor = System.Drawing.SystemColors.InfoText;
            this.TBOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBOutput.ForeColor = System.Drawing.Color.White;
            this.TBOutput.Location = new System.Drawing.Point(3, 19);
            this.TBOutput.Multiline = true;
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.PlaceholderText = "Nothing Yet...";
            this.TBOutput.ReadOnly = true;
            this.TBOutput.Size = new System.Drawing.Size(554, 140);
            this.TBOutput.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AcceptButton = this.BExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.BExit;
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Controls.Add(this.PDetails);
            this.Controls.Add(this.PExecution);
            this.Controls.Add(this.PParameters);
            this.Controls.Add(this.BExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MTSRCDS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PParameters.ResumeLayout(false);
            this.GBArgs.ResumeLayout(false);
            this.GBArgs.PerformLayout();
            this.GBEnv.ResumeLayout(false);
            this.GBWorkspace.ResumeLayout(false);
            this.GBWorkspace.PerformLayout();
            this.PExecution.ResumeLayout(false);
            this.PDetails.ResumeLayout(false);
            this.PDetails.PerformLayout();
            this.GBOutput.ResumeLayout(false);
            this.GBOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Panel PParameters;
        private System.Windows.Forms.Panel PExecution;
        private System.Windows.Forms.Panel PDetails;
        private System.Windows.Forms.GroupBox GBEnv;
        private System.Windows.Forms.GroupBox GBWorkspace;
        private System.Windows.Forms.Button BOpenLogs;
        private System.Windows.Forms.Button BAddonMan;
        private System.Windows.Forms.TextBox TBWorkingDir;
        private System.Windows.Forms.ProgressBar PBStatus;
        private System.Windows.Forms.GroupBox GBOutput;
        private System.Windows.Forms.TextBox TBOutput;
        private System.Windows.Forms.GroupBox GBArgs;
        private System.Windows.Forms.ComboBox CBArgument;
        private System.Windows.Forms.Label LArgIdentifier;
        private System.Windows.Forms.TextBox TBArgValue;
        private System.Windows.Forms.Button BInterpArg;
        private System.Windows.Forms.TextBox TBHostname;
        private System.Windows.Forms.TextBox TBLoadingURL;
        private System.Windows.Forms.Button BExecute;
        private System.Windows.Forms.CheckBox CBLockAssigner;
        private System.Windows.Forms.CheckBox CBWorkspaceValid;
    }
}

