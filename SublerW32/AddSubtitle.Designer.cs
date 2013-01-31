namespace SublerW32
{
    partial class AddSubtitle
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
            this.lbSubLang = new System.Windows.Forms.Label();
            this.cbSubLang = new System.Windows.Forms.ComboBox();
            this.lbSubFile = new System.Windows.Forms.Label();
            this.tbSubFilePath = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbSubLang
            // 
            this.lbSubLang.AutoSize = true;
            this.lbSubLang.Location = new System.Drawing.Point(13, 13);
            this.lbSubLang.Name = "lbSubLang";
            this.lbSubLang.Size = new System.Drawing.Size(55, 13);
            this.lbSubLang.TabIndex = 0;
            this.lbSubLang.Text = "字幕语言";
            // 
            // cbSubLang
            // 
            this.cbSubLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubLang.FormattingEnabled = true;
            this.cbSubLang.Items.AddRange(new object[] {
            "简体中文",
            "繁体中文",
            "英文",
            "日文",
            "韩文",
            "简中英双语",
            "繁中英双语",
            "中日双语",
            "中韩双语"});
            this.cbSubLang.Location = new System.Drawing.Point(16, 30);
            this.cbSubLang.Name = "cbSubLang";
            this.cbSubLang.Size = new System.Drawing.Size(121, 21);
            this.cbSubLang.TabIndex = 1;
            this.cbSubLang.SelectedIndexChanged += new System.EventHandler(this.cbSubLang_SelectedIndexChanged);
            // 
            // lbSubFile
            // 
            this.lbSubFile.AutoSize = true;
            this.lbSubFile.Location = new System.Drawing.Point(13, 60);
            this.lbSubFile.Name = "lbSubFile";
            this.lbSubFile.Size = new System.Drawing.Size(55, 13);
            this.lbSubFile.TabIndex = 2;
            this.lbSubFile.Text = "字幕文件";
            // 
            // tbSubFilePath
            // 
            this.tbSubFilePath.AllowDrop = true;
            this.tbSubFilePath.Location = new System.Drawing.Point(16, 77);
            this.tbSubFilePath.Name = "tbSubFilePath";
            this.tbSubFilePath.ReadOnly = true;
            this.tbSubFilePath.Size = new System.Drawing.Size(285, 20);
            this.tbSubFilePath.TabIndex = 3;
            this.tbSubFilePath.Text = "拖动字幕文件至此  或点击右侧按钮选择文件";
            this.tbSubFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSubFilePath.WordWrap = false;
            this.tbSubFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbSubFilePath_DragDrop);
            this.tbSubFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbSubFilePath_DragEnter);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(263, 105);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "添加";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(307, 75);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(31, 23);
            this.btnSelectFile.TabIndex = 5;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // AddSubtitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 135);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbSubFilePath);
            this.Controls.Add(this.lbSubFile);
            this.Controls.Add(this.cbSubLang);
            this.Controls.Add(this.lbSubLang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSubtitle";
            this.Text = "AddSubtitle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubLang;
        private System.Windows.Forms.ComboBox cbSubLang;
        private System.Windows.Forms.Label lbSubFile;
        private System.Windows.Forms.TextBox tbSubFilePath;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}