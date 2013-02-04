namespace SublerW32
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
            this.btnCompile = new System.Windows.Forms.Button();
            this.ssMainStatus = new System.Windows.Forms.StatusStrip();
            this.pbCompileProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.msMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectVideoFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectMetaHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMetaHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewMetaHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditMetaHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gbVideoNMeta = new System.Windows.Forms.GroupBox();
            this.tbMetaPath = new System.Windows.Forms.TextBox();
            this.btnSelectMeta = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mp4CompileWorker = new System.ComponentModel.BackgroundWorker();
            this.ssMainStatus.SuspendLayout();
            this.msMainMenuStrip.SuspendLayout();
            this.gbVideoNMeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompile
            // 
            this.btnCompile.Location = new System.Drawing.Point(341, 119);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(128, 23);
            this.btnCompile.TabIndex = 0;
            this.btnCompile.Text = "编译视频";
            this.btnCompile.UseVisualStyleBackColor = true;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // ssMainStatus
            // 
            this.ssMainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbCompileProgress});
            this.ssMainStatus.Location = new System.Drawing.Point(0, 145);
            this.ssMainStatus.Name = "ssMainStatus";
            this.ssMainStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ssMainStatus.Size = new System.Drawing.Size(481, 22);
            this.ssMainStatus.TabIndex = 2;
            this.ssMainStatus.Text = "ssMainStatus";
            // 
            // pbCompileProgress
            // 
            this.pbCompileProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pbCompileProgress.Name = "pbCompileProgress";
            this.pbCompileProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // msMainMenuStrip
            // 
            this.msMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiMetaHeader,
            this.tsmiAbout});
            this.msMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.msMainMenuStrip.Name = "msMainMenuStrip";
            this.msMainMenuStrip.Size = new System.Drawing.Size(481, 24);
            this.msMainMenuStrip.TabIndex = 3;
            this.msMainMenuStrip.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectVideoFile,
            this.tsmiSelectMetaHeader,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(43, 20);
            this.tsmiFile.Text = "文件";
            // 
            // tsmiSelectVideoFile
            // 
            this.tsmiSelectVideoFile.Name = "tsmiSelectVideoFile";
            this.tsmiSelectVideoFile.Size = new System.Drawing.Size(160, 22);
            this.tsmiSelectVideoFile.Text = "选择视频";
            this.tsmiSelectVideoFile.Click += new System.EventHandler(this.tsmiSelectVideoFile_Click);
            // 
            // tsmiSelectMetaHeader
            // 
            this.tsmiSelectMetaHeader.Name = "tsmiSelectMetaHeader";
            this.tsmiSelectMetaHeader.Size = new System.Drawing.Size(160, 22);
            this.tsmiSelectMetaHeader.Text = "选择信息头XML";
            this.tsmiSelectMetaHeader.Click += new System.EventHandler(this.tsmiSelectMetaHeader_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(160, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiMetaHeader
            // 
            this.tsmiMetaHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewMetaHeader,
            this.tsmiEditMetaHeader});
            this.tsmiMetaHeader.Name = "tsmiMetaHeader";
            this.tsmiMetaHeader.Size = new System.Drawing.Size(55, 20);
            this.tsmiMetaHeader.Text = "信息头";
            // 
            // tsmiNewMetaHeader
            // 
            this.tsmiNewMetaHeader.Name = "tsmiNewMetaHeader";
            this.tsmiNewMetaHeader.Size = new System.Drawing.Size(160, 22);
            this.tsmiNewMetaHeader.Text = "新建信息头XML";
            this.tsmiNewMetaHeader.Click += new System.EventHandler(this.tsmiNewMetaHeader_Click);
            // 
            // tsmiEditMetaHeader
            // 
            this.tsmiEditMetaHeader.Name = "tsmiEditMetaHeader";
            this.tsmiEditMetaHeader.Size = new System.Drawing.Size(160, 22);
            this.tsmiEditMetaHeader.Text = "编辑信息头XML";
            this.tsmiEditMetaHeader.Click += new System.EventHandler(this.tsmiEditMetaHeader_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(43, 20);
            this.tsmiAbout.Text = "关于";
            // 
            // gbVideoNMeta
            // 
            this.gbVideoNMeta.Controls.Add(this.tbMetaPath);
            this.gbVideoNMeta.Controls.Add(this.btnSelectMeta);
            this.gbVideoNMeta.Controls.Add(this.tbFilePath);
            this.gbVideoNMeta.Controls.Add(this.btnSelectFile);
            this.gbVideoNMeta.Location = new System.Drawing.Point(12, 33);
            this.gbVideoNMeta.Name = "gbVideoNMeta";
            this.gbVideoNMeta.Size = new System.Drawing.Size(457, 78);
            this.gbVideoNMeta.TabIndex = 0;
            this.gbVideoNMeta.TabStop = false;
            this.gbVideoNMeta.Text = "视频及信息头";
            // 
            // tbMetaPath
            // 
            this.tbMetaPath.AllowDrop = true;
            this.tbMetaPath.Location = new System.Drawing.Point(6, 45);
            this.tbMetaPath.Name = "tbMetaPath";
            this.tbMetaPath.ReadOnly = true;
            this.tbMetaPath.Size = new System.Drawing.Size(415, 20);
            this.tbMetaPath.TabIndex = 3;
            this.tbMetaPath.Text = "拖动信息头XML文件至此  或点击右侧按钮选择文件";
            this.tbMetaPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMetaPath.WordWrap = false;
            this.tbMetaPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbMetaPath_DragDrop);
            this.tbMetaPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbMetaPath_DragEnter);
            // 
            // btnSelectMeta
            // 
            this.btnSelectMeta.Location = new System.Drawing.Point(427, 45);
            this.btnSelectMeta.Name = "btnSelectMeta";
            this.btnSelectMeta.Size = new System.Drawing.Size(24, 20);
            this.btnSelectMeta.TabIndex = 2;
            this.btnSelectMeta.Text = "...";
            this.btnSelectMeta.UseVisualStyleBackColor = true;
            this.btnSelectMeta.Click += new System.EventHandler(this.btnSelectMeta_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.AllowDrop = true;
            this.tbFilePath.Location = new System.Drawing.Point(6, 19);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(415, 20);
            this.tbFilePath.TabIndex = 1;
            this.tbFilePath.Text = "拖动视频文件至此  或点击右侧按钮选择文件";
            this.tbFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFilePath.WordWrap = false;
            this.tbFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFilePath_DragDrop);
            this.tbFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbFilePath_DragEnter);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(427, 18);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(24, 20);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // mp4CompileWorker
            // 
            this.mp4CompileWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mp4CompileWorker_DoWork);
            this.mp4CompileWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.mp4CompileWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 167);
            this.Controls.Add(this.gbVideoNMeta);
            this.Controls.Add(this.ssMainStatus);
            this.Controls.Add(this.msMainMenuStrip);
            this.Controls.Add(this.btnCompile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MP4信息头编辑器";
            this.ssMainStatus.ResumeLayout(false);
            this.ssMainStatus.PerformLayout();
            this.msMainMenuStrip.ResumeLayout(false);
            this.msMainMenuStrip.PerformLayout();
            this.gbVideoNMeta.ResumeLayout(false);
            this.gbVideoNMeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.StatusStrip ssMainStatus;
        private System.Windows.Forms.ToolStripProgressBar pbCompileProgress;
        private System.Windows.Forms.MenuStrip msMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectVideoFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectMetaHeader;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiMetaHeader;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewMetaHeader;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.GroupBox gbVideoNMeta;
        private System.Windows.Forms.TextBox tbMetaPath;
        private System.Windows.Forms.Button btnSelectMeta;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditMetaHeader;
        private System.ComponentModel.BackgroundWorker mp4CompileWorker;
    }
}

