namespace STM_Flasher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelPort = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.buttonScanPort = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFlash = new System.Windows.Forms.Button();
            this.labelCycle = new System.Windows.Forms.Label();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.labelLoopCount = new System.Windows.Forms.Label();
            this.textBoxLoopCount = new System.Windows.Forms.TextBox();
            this.labelLoopExecuted = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.progressBarFlash = new System.Windows.Forms.ProgressBar();
            this.labelFlashFile = new System.Windows.Forms.Label();
            this.textBoxFlashFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLoopPass = new System.Windows.Forms.Label();
            this.labelLoopFail = new System.Windows.Forms.Label();
            this.buttonExportLog = new System.Windows.Forms.Button();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.labelTestplan = new System.Windows.Forms.Label();
            this.textBoxTestplan = new System.Windows.Forms.TextBox();
            this.buttonTestplanBrowse = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(40, 255);
            this.labelPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(118, 25);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "DUT Port : ";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(164, 253);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(340, 33);
            this.comboBoxPort.TabIndex = 1;
            // 
            // buttonScanPort
            // 
            this.buttonScanPort.Location = new System.Drawing.Point(526, 248);
            this.buttonScanPort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonScanPort.Name = "buttonScanPort";
            this.buttonScanPort.Size = new System.Drawing.Size(84, 48);
            this.buttonScanPort.TabIndex = 2;
            this.buttonScanPort.Text = "Scan";
            this.buttonScanPort.UseVisualStyleBackColor = true;
            this.buttonScanPort.Click += new System.EventHandler(this.buttonScanPort_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLog.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxLog.Location = new System.Drawing.Point(38, 511);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4, 4, 10, 10);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(2166, 674);
            this.textBoxLog.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 461);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log :";
            // 
            // buttonFlash
            // 
            this.buttonFlash.Location = new System.Drawing.Point(164, 382);
            this.buttonFlash.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFlash.Name = "buttonFlash";
            this.buttonFlash.Size = new System.Drawing.Size(178, 54);
            this.buttonFlash.TabIndex = 5;
            this.buttonFlash.Text = "Start";
            this.buttonFlash.UseVisualStyleBackColor = true;
            this.buttonFlash.Click += new System.EventHandler(this.buttonFlash_Click);
            // 
            // labelCycle
            // 
            this.labelCycle.AutoSize = true;
            this.labelCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCycle.Location = new System.Drawing.Point(1748, 118);
            this.labelCycle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCycle.Name = "labelCycle";
            this.labelCycle.Size = new System.Drawing.Size(293, 37);
            this.labelCycle.TabIndex = 6;
            this.labelCycle.Text = "CYCLE : 00:00:00";
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Location = new System.Drawing.Point(744, 257);
            this.checkBoxLoop.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(177, 29);
            this.checkBoxLoop.TabIndex = 7;
            this.checkBoxLoop.Text = "Loop Enabled";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            this.checkBoxLoop.CheckedChanged += new System.EventHandler(this.checkBoxLoop_CheckedChanged);
            // 
            // labelLoopCount
            // 
            this.labelLoopCount.AutoSize = true;
            this.labelLoopCount.Location = new System.Drawing.Point(740, 328);
            this.labelLoopCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoopCount.Name = "labelLoopCount";
            this.labelLoopCount.Size = new System.Drawing.Size(141, 25);
            this.labelLoopCount.TabIndex = 8;
            this.labelLoopCount.Text = "Loop Count : ";
            this.labelLoopCount.Visible = false;
            // 
            // textBoxLoopCount
            // 
            this.textBoxLoopCount.Enabled = false;
            this.textBoxLoopCount.Location = new System.Drawing.Point(889, 322);
            this.textBoxLoopCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoopCount.Name = "textBoxLoopCount";
            this.textBoxLoopCount.Size = new System.Drawing.Size(196, 31);
            this.textBoxLoopCount.TabIndex = 9;
            this.textBoxLoopCount.Text = "0";
            this.textBoxLoopCount.Visible = false;
            // 
            // labelLoopExecuted
            // 
            this.labelLoopExecuted.AutoSize = true;
            this.labelLoopExecuted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoopExecuted.Location = new System.Drawing.Point(739, 391);
            this.labelLoopExecuted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoopExecuted.Name = "labelLoopExecuted";
            this.labelLoopExecuted.Size = new System.Drawing.Size(248, 31);
            this.labelLoopExecuted.TabIndex = 10;
            this.labelLoopExecuted.Text = "Loop Executed : 0";
            this.labelLoopExecuted.Visible = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(1748, 181);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(291, 37);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "TOTAL : 00:00:00";
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(382, 382);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(178, 54);
            this.buttonStop.TabIndex = 12;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // progressBarFlash
            // 
            this.progressBarFlash.Location = new System.Drawing.Point(866, 455);
            this.progressBarFlash.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarFlash.Name = "progressBarFlash";
            this.progressBarFlash.Size = new System.Drawing.Size(432, 31);
            this.progressBarFlash.TabIndex = 13;
            // 
            // labelFlashFile
            // 
            this.labelFlashFile.AutoSize = true;
            this.labelFlashFile.Location = new System.Drawing.Point(44, 159);
            this.labelFlashFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFlashFile.Name = "labelFlashFile";
            this.labelFlashFile.Size = new System.Drawing.Size(124, 25);
            this.labelFlashFile.TabIndex = 14;
            this.labelFlashFile.Text = "Flash File : ";
            // 
            // textBoxFlashFile
            // 
            this.textBoxFlashFile.Enabled = false;
            this.textBoxFlashFile.Location = new System.Drawing.Point(164, 159);
            this.textBoxFlashFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFlashFile.Name = "textBoxFlashFile";
            this.textBoxFlashFile.Size = new System.Drawing.Size(908, 31);
            this.textBoxFlashFile.TabIndex = 15;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(1096, 153);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(120, 40);
            this.buttonBrowse.TabIndex = 16;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelStatusText
            // 
            this.labelStatusText.AutoSize = true;
            this.labelStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusText.Location = new System.Drawing.Point(1748, 243);
            this.labelStatusText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(180, 37);
            this.labelStatusText.TabIndex = 17;
            this.labelStatusText.Text = "STATUS : ";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(1932, 243);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(28, 37);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 461);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Progress : ";
            // 
            // labelLoopPass
            // 
            this.labelLoopPass.AutoSize = true;
            this.labelLoopPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoopPass.Location = new System.Drawing.Point(1146, 391);
            this.labelLoopPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoopPass.Name = "labelLoopPass";
            this.labelLoopPass.Size = new System.Drawing.Size(131, 31);
            this.labelLoopPass.TabIndex = 20;
            this.labelLoopPass.Text = "PASS : 0";
            this.labelLoopPass.Visible = false;
            // 
            // labelLoopFail
            // 
            this.labelLoopFail.AutoSize = true;
            this.labelLoopFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoopFail.Location = new System.Drawing.Point(1476, 391);
            this.labelLoopFail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoopFail.Name = "labelLoopFail";
            this.labelLoopFail.Size = new System.Drawing.Size(117, 31);
            this.labelLoopFail.TabIndex = 21;
            this.labelLoopFail.Text = "FAIL : 0";
            this.labelLoopFail.Visible = false;
            // 
            // buttonExportLog
            // 
            this.buttonExportLog.Location = new System.Drawing.Point(134, 1202);
            this.buttonExportLog.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExportLog.Name = "buttonExportLog";
            this.buttonExportLog.Size = new System.Drawing.Size(160, 52);
            this.buttonExportLog.TabIndex = 22;
            this.buttonExportLog.Text = "Export Log";
            this.buttonExportLog.UseVisualStyleBackColor = true;
            this.buttonExportLog.Click += new System.EventHandler(this.buttonExportLog_Click);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(348, 1202);
            this.buttonClearLog.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(160, 52);
            this.buttonClearLog.TabIndex = 23;
            this.buttonClearLog.Text = "Clear Log";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // labelTestplan
            // 
            this.labelTestplan.AutoSize = true;
            this.labelTestplan.Location = new System.Drawing.Point(44, 100);
            this.labelTestplan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTestplan.Name = "labelTestplan";
            this.labelTestplan.Size = new System.Drawing.Size(107, 25);
            this.labelTestplan.TabIndex = 24;
            this.labelTestplan.Text = "Testplan :";
            // 
            // textBoxTestplan
            // 
            this.textBoxTestplan.Enabled = false;
            this.textBoxTestplan.Location = new System.Drawing.Point(164, 100);
            this.textBoxTestplan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTestplan.Name = "textBoxTestplan";
            this.textBoxTestplan.Size = new System.Drawing.Size(908, 31);
            this.textBoxTestplan.TabIndex = 25;
            // 
            // buttonTestplanBrowse
            // 
            this.buttonTestplanBrowse.Location = new System.Drawing.Point(1096, 88);
            this.buttonTestplanBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTestplanBrowse.Name = "buttonTestplanBrowse";
            this.buttonTestplanBrowse.Size = new System.Drawing.Size(120, 42);
            this.buttonTestplanBrowse.TabIndex = 26;
            this.buttonTestplanBrowse.Text = "Browse";
            this.buttonTestplanBrowse.UseVisualStyleBackColor = true;
            this.buttonTestplanBrowse.Click += new System.EventHandler(this.buttonTestplanBrowse_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2236, 40);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.fileToolStripMenuItem.Text = "About";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(2236, 1275);
            this.Controls.Add(this.buttonTestplanBrowse);
            this.Controls.Add(this.textBoxTestplan);
            this.Controls.Add(this.labelTestplan);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.buttonExportLog);
            this.Controls.Add(this.labelLoopFail);
            this.Controls.Add(this.labelLoopPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelStatusText);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFlashFile);
            this.Controls.Add(this.labelFlashFile);
            this.Controls.Add(this.progressBarFlash);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelLoopExecuted);
            this.Controls.Add(this.textBoxLoopCount);
            this.Controls.Add(this.labelLoopCount);
            this.Controls.Add(this.checkBoxLoop);
            this.Controls.Add(this.labelCycle);
            this.Controls.Add(this.buttonFlash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonScanPort);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "STM Flasher by SANTRONIX";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button buttonScanPort;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFlash;
        private System.Windows.Forms.Label labelCycle;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.Label labelLoopCount;
        private System.Windows.Forms.TextBox textBoxLoopCount;
        private System.Windows.Forms.Label labelLoopExecuted;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ProgressBar progressBarFlash;
        private System.Windows.Forms.Label labelFlashFile;
        private System.Windows.Forms.TextBox textBoxFlashFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLoopPass;
        private System.Windows.Forms.Label labelLoopFail;
        private System.Windows.Forms.Button buttonExportLog;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Label labelTestplan;
        private System.Windows.Forms.TextBox textBoxTestplan;
        private System.Windows.Forms.Button buttonTestplanBrowse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
    }
}

