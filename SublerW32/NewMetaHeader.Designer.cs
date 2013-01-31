 namespace SublerW32
{
    partial class NewMetaHeader
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
            this.tcMetaInfo = new System.Windows.Forms.TabControl();
            this.tpMISummary = new System.Windows.Forms.TabPage();
            this.tpMetaData = new System.Windows.Forms.TabPage();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.tbLongDescription = new System.Windows.Forms.TextBox();
            this.lbLongDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbWriter = new System.Windows.Forms.TextBox();
            this.lbWriter = new System.Windows.Forms.Label();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.lbDirector = new System.Windows.Forms.Label();
            this.tbCast = new System.Windows.Forms.TextBox();
            this.lbCast = new System.Windows.Forms.Label();
            this.tbReleaseDate = new System.Windows.Forms.TextBox();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tpExtendedMeta = new System.Windows.Forms.TabPage();
            this.btnSelectChapters = new System.Windows.Forms.Button();
            this.tbChaptersFile = new System.Windows.Forms.TextBox();
            this.lbChapters = new System.Windows.Forms.Label();
            this.btnAddSub = new System.Windows.Forms.Button();
            this.lbSubtitles = new System.Windows.Forms.Label();
            this.lvSubtitles = new System.Windows.Forms.ListView();
            this.chLang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbHD = new System.Windows.Forms.ComboBox();
            this.lbHD = new System.Windows.Forms.Label();
            this.cbContentRating = new System.Windows.Forms.ComboBox();
            this.lbContentRating = new System.Windows.Forms.Label();
            this.cbMediaType = new System.Windows.Forms.ComboBox();
            this.lbMediaType = new System.Windows.Forms.Label();
            this.pMediaSpecific = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tcMetaInfo.SuspendLayout();
            this.tpMetaData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.tpExtendedMeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMetaInfo
            // 
            this.tcMetaInfo.Controls.Add(this.tpMISummary);
            this.tcMetaInfo.Controls.Add(this.tpMetaData);
            this.tcMetaInfo.Controls.Add(this.tpExtendedMeta);
            this.tcMetaInfo.Location = new System.Drawing.Point(12, 12);
            this.tcMetaInfo.Name = "tcMetaInfo";
            this.tcMetaInfo.SelectedIndex = 0;
            this.tcMetaInfo.Size = new System.Drawing.Size(451, 426);
            this.tcMetaInfo.TabIndex = 0;
            // 
            // tpMISummary
            // 
            this.tpMISummary.Location = new System.Drawing.Point(4, 22);
            this.tpMISummary.Name = "tpMISummary";
            this.tpMISummary.Padding = new System.Windows.Forms.Padding(3);
            this.tpMISummary.Size = new System.Drawing.Size(443, 400);
            this.tpMISummary.TabIndex = 0;
            this.tpMISummary.Text = "摘要";
            this.tpMISummary.UseVisualStyleBackColor = true;
            // 
            // tpMetaData
            // 
            this.tpMetaData.AllowDrop = true;
            this.tpMetaData.Controls.Add(this.pbPoster);
            this.tpMetaData.Controls.Add(this.tbLongDescription);
            this.tpMetaData.Controls.Add(this.lbLongDescription);
            this.tpMetaData.Controls.Add(this.tbDescription);
            this.tpMetaData.Controls.Add(this.lbDescription);
            this.tpMetaData.Controls.Add(this.tbWriter);
            this.tpMetaData.Controls.Add(this.lbWriter);
            this.tpMetaData.Controls.Add(this.tbDirector);
            this.tpMetaData.Controls.Add(this.lbDirector);
            this.tpMetaData.Controls.Add(this.tbCast);
            this.tpMetaData.Controls.Add(this.lbCast);
            this.tpMetaData.Controls.Add(this.tbReleaseDate);
            this.tpMetaData.Controls.Add(this.lbReleaseDate);
            this.tpMetaData.Controls.Add(this.tbTitle);
            this.tpMetaData.Controls.Add(this.lbTitle);
            this.tpMetaData.Location = new System.Drawing.Point(4, 22);
            this.tpMetaData.Name = "tpMetaData";
            this.tpMetaData.Padding = new System.Windows.Forms.Padding(3);
            this.tpMetaData.Size = new System.Drawing.Size(443, 400);
            this.tpMetaData.TabIndex = 1;
            this.tpMetaData.Text = "信息头数据";
            this.tpMetaData.UseVisualStyleBackColor = true;
            this.tpMetaData.DragDrop += new System.Windows.Forms.DragEventHandler(this.tpMetaData_DragDrop);
            this.tpMetaData.DragEnter += new System.Windows.Forms.DragEventHandler(this.tpMetaData_DragEnter);
            // 
            // pbPoster
            // 
            this.pbPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPoster.Location = new System.Drawing.Point(316, 6);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(121, 152);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 14;
            this.pbPoster.TabStop = false;
            // 
            // tbLongDescription
            // 
            this.tbLongDescription.Location = new System.Drawing.Point(9, 303);
            this.tbLongDescription.Multiline = true;
            this.tbLongDescription.Name = "tbLongDescription";
            this.tbLongDescription.Size = new System.Drawing.Size(428, 91);
            this.tbLongDescription.TabIndex = 13;
            // 
            // lbLongDescription
            // 
            this.lbLongDescription.AutoSize = true;
            this.lbLongDescription.Location = new System.Drawing.Point(6, 287);
            this.lbLongDescription.Name = "lbLongDescription";
            this.lbLongDescription.Size = new System.Drawing.Size(55, 13);
            this.lbLongDescription.TabIndex = 12;
            this.lbLongDescription.Text = "剧情详述";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(9, 241);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(428, 42);
            this.tbDescription.TabIndex = 11;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(6, 225);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(55, 13);
            this.lbDescription.TabIndex = 10;
            this.lbDescription.Text = "剧情简介";
            // 
            // tbWriter
            // 
            this.tbWriter.Enabled = false;
            this.tbWriter.Location = new System.Drawing.Point(9, 138);
            this.tbWriter.Name = "tbWriter";
            this.tbWriter.Size = new System.Drawing.Size(301, 20);
            this.tbWriter.TabIndex = 9;
            this.tbWriter.WordWrap = false;
            // 
            // lbWriter
            // 
            this.lbWriter.AutoSize = true;
            this.lbWriter.Location = new System.Drawing.Point(6, 122);
            this.lbWriter.Name = "lbWriter";
            this.lbWriter.Size = new System.Drawing.Size(31, 13);
            this.lbWriter.TabIndex = 8;
            this.lbWriter.Text = "编剧";
            // 
            // tbDirector
            // 
            this.tbDirector.Enabled = false;
            this.tbDirector.Location = new System.Drawing.Point(9, 98);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(301, 20);
            this.tbDirector.TabIndex = 7;
            this.tbDirector.WordWrap = false;
            // 
            // lbDirector
            // 
            this.lbDirector.AutoSize = true;
            this.lbDirector.Location = new System.Drawing.Point(6, 82);
            this.lbDirector.Name = "lbDirector";
            this.lbDirector.Size = new System.Drawing.Size(31, 13);
            this.lbDirector.TabIndex = 6;
            this.lbDirector.Text = "导演";
            // 
            // tbCast
            // 
            this.tbCast.Enabled = false;
            this.tbCast.Location = new System.Drawing.Point(9, 179);
            this.tbCast.Multiline = true;
            this.tbCast.Name = "tbCast";
            this.tbCast.Size = new System.Drawing.Size(428, 42);
            this.tbCast.TabIndex = 5;
            // 
            // lbCast
            // 
            this.lbCast.AutoSize = true;
            this.lbCast.Location = new System.Drawing.Point(6, 163);
            this.lbCast.Name = "lbCast";
            this.lbCast.Size = new System.Drawing.Size(31, 13);
            this.lbCast.TabIndex = 4;
            this.lbCast.Text = "演员";
            // 
            // tbReleaseDate
            // 
            this.tbReleaseDate.Location = new System.Drawing.Point(9, 58);
            this.tbReleaseDate.Name = "tbReleaseDate";
            this.tbReleaseDate.Size = new System.Drawing.Size(301, 20);
            this.tbReleaseDate.TabIndex = 3;
            this.tbReleaseDate.Text = "以YYYY-MM-DD格式填写";
            this.tbReleaseDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbReleaseDate.WordWrap = false;
            this.tbReleaseDate.Click += new System.EventHandler(this.tbReleaseDate_Click);
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Location = new System.Drawing.Point(6, 42);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(55, 13);
            this.lbReleaseDate.TabIndex = 2;
            this.lbReleaseDate.Text = "上映时间";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(9, 19);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(301, 20);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.WordWrap = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(6, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(31, 13);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "标题";
            // 
            // tpExtendedMeta
            // 
            this.tpExtendedMeta.Controls.Add(this.btnSelectChapters);
            this.tpExtendedMeta.Controls.Add(this.tbChaptersFile);
            this.tpExtendedMeta.Controls.Add(this.lbChapters);
            this.tpExtendedMeta.Controls.Add(this.btnAddSub);
            this.tpExtendedMeta.Controls.Add(this.lbSubtitles);
            this.tpExtendedMeta.Controls.Add(this.lvSubtitles);
            this.tpExtendedMeta.Controls.Add(this.cbHD);
            this.tpExtendedMeta.Controls.Add(this.lbHD);
            this.tpExtendedMeta.Controls.Add(this.cbContentRating);
            this.tpExtendedMeta.Controls.Add(this.lbContentRating);
            this.tpExtendedMeta.Controls.Add(this.cbMediaType);
            this.tpExtendedMeta.Controls.Add(this.lbMediaType);
            this.tpExtendedMeta.Controls.Add(this.pMediaSpecific);
            this.tpExtendedMeta.Location = new System.Drawing.Point(4, 22);
            this.tpExtendedMeta.Name = "tpExtendedMeta";
            this.tpExtendedMeta.Padding = new System.Windows.Forms.Padding(3);
            this.tpExtendedMeta.Size = new System.Drawing.Size(443, 400);
            this.tpExtendedMeta.TabIndex = 2;
            this.tpExtendedMeta.Text = "扩展数据";
            this.tpExtendedMeta.UseVisualStyleBackColor = true;
            // 
            // btnSelectChapters
            // 
            this.btnSelectChapters.Location = new System.Drawing.Point(391, 346);
            this.btnSelectChapters.Name = "btnSelectChapters";
            this.btnSelectChapters.Size = new System.Drawing.Size(32, 23);
            this.btnSelectChapters.TabIndex = 13;
            this.btnSelectChapters.Text = "...";
            this.btnSelectChapters.UseVisualStyleBackColor = true;
            this.btnSelectChapters.Click += new System.EventHandler(this.btnSelectChapters_Click);
            // 
            // tbChaptersFile
            // 
            this.tbChaptersFile.AllowDrop = true;
            this.tbChaptersFile.Location = new System.Drawing.Point(16, 348);
            this.tbChaptersFile.Name = "tbChaptersFile";
            this.tbChaptersFile.ReadOnly = true;
            this.tbChaptersFile.Size = new System.Drawing.Size(369, 20);
            this.tbChaptersFile.TabIndex = 12;
            this.tbChaptersFile.Text = "拖动章节文件至此或点击右侧按钮选择文件";
            this.tbChaptersFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbChaptersFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbChaptersFile_DragDrop);
            this.tbChaptersFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbChaptersFile_DragEnter);
            // 
            // lbChapters
            // 
            this.lbChapters.AutoSize = true;
            this.lbChapters.Location = new System.Drawing.Point(13, 332);
            this.lbChapters.Name = "lbChapters";
            this.lbChapters.Size = new System.Drawing.Size(55, 13);
            this.lbChapters.TabIndex = 11;
            this.lbChapters.Text = "章节分段";
            // 
            // btnAddSub
            // 
            this.btnAddSub.Location = new System.Drawing.Point(72, 175);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(25, 20);
            this.btnAddSub.TabIndex = 10;
            this.btnAddSub.Text = "+";
            this.btnAddSub.UseVisualStyleBackColor = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // lbSubtitles
            // 
            this.lbSubtitles.AutoSize = true;
            this.lbSubtitles.Location = new System.Drawing.Point(17, 178);
            this.lbSubtitles.Name = "lbSubtitles";
            this.lbSubtitles.Size = new System.Drawing.Size(55, 13);
            this.lbSubtitles.TabIndex = 9;
            this.lbSubtitles.Text = "内嵌字幕";
            // 
            // lvSubtitles
            // 
            this.lvSubtitles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLang,
            this.chSubFile});
            this.lvSubtitles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSubtitles.Location = new System.Drawing.Point(16, 202);
            this.lvSubtitles.Name = "lvSubtitles";
            this.lvSubtitles.Size = new System.Drawing.Size(408, 118);
            this.lvSubtitles.TabIndex = 8;
            this.lvSubtitles.UseCompatibleStateImageBehavior = false;
            this.lvSubtitles.View = System.Windows.Forms.View.Details;
            // 
            // chLang
            // 
            this.chLang.Text = "字幕语言";
            this.chLang.Width = 80;
            // 
            // chSubFile
            // 
            this.chSubFile.Text = "字幕文件";
            this.chSubFile.Width = 291;
            // 
            // cbHD
            // 
            this.cbHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHD.FormattingEnabled = true;
            this.cbHD.Items.AddRange(new object[] {
            "SD",
            "720p",
            "1080p"});
            this.cbHD.Location = new System.Drawing.Point(303, 27);
            this.cbHD.Name = "cbHD";
            this.cbHD.Size = new System.Drawing.Size(121, 21);
            this.cbHD.TabIndex = 6;
            // 
            // lbHD
            // 
            this.lbHD.AutoSize = true;
            this.lbHD.Location = new System.Drawing.Point(300, 10);
            this.lbHD.Name = "lbHD";
            this.lbHD.Size = new System.Drawing.Size(43, 13);
            this.lbHD.TabIndex = 5;
            this.lbHD.Text = "清晰度";
            // 
            // cbContentRating
            // 
            this.cbContentRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContentRating.FormattingEnabled = true;
            this.cbContentRating.Items.AddRange(new object[] {
            "None",
            "Clean",
            "Explicit"});
            this.cbContentRating.Location = new System.Drawing.Point(160, 27);
            this.cbContentRating.Name = "cbContentRating";
            this.cbContentRating.Size = new System.Drawing.Size(121, 21);
            this.cbContentRating.TabIndex = 4;
            // 
            // lbContentRating
            // 
            this.lbContentRating.AutoSize = true;
            this.lbContentRating.Location = new System.Drawing.Point(157, 10);
            this.lbContentRating.Name = "lbContentRating";
            this.lbContentRating.Size = new System.Drawing.Size(55, 13);
            this.lbContentRating.TabIndex = 3;
            this.lbContentRating.Text = "内容分级";
            // 
            // cbMediaType
            // 
            this.cbMediaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMediaType.FormattingEnabled = true;
            this.cbMediaType.Items.AddRange(new object[] {
            "电影",
            "电视剧",
            "播客",
            "iTunes U"});
            this.cbMediaType.Location = new System.Drawing.Point(16, 27);
            this.cbMediaType.Name = "cbMediaType";
            this.cbMediaType.Size = new System.Drawing.Size(121, 21);
            this.cbMediaType.TabIndex = 2;
            this.cbMediaType.SelectedValueChanged += new System.EventHandler(this.cbMediaType_SelectedValueChanged);
            // 
            // lbMediaType
            // 
            this.lbMediaType.AutoSize = true;
            this.lbMediaType.Location = new System.Drawing.Point(13, 10);
            this.lbMediaType.Name = "lbMediaType";
            this.lbMediaType.Size = new System.Drawing.Size(55, 13);
            this.lbMediaType.TabIndex = 1;
            this.lbMediaType.Text = "媒体类型";
            // 
            // pMediaSpecific
            // 
            this.pMediaSpecific.Location = new System.Drawing.Point(16, 66);
            this.pMediaSpecific.Name = "pMediaSpecific";
            this.pMediaSpecific.Size = new System.Drawing.Size(408, 91);
            this.pMediaSpecific.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(388, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(307, 444);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewMetaHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 476);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcMetaInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewMetaHeader";
            this.Text = "文件头属性";
            this.Load += new System.EventHandler(this.NewMetaHeader_Load);
            this.tcMetaInfo.ResumeLayout(false);
            this.tpMetaData.ResumeLayout(false);
            this.tpMetaData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.tpExtendedMeta.ResumeLayout(false);
            this.tpExtendedMeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMetaInfo;
        private System.Windows.Forms.TabPage tpMISummary;
        private System.Windows.Forms.TabPage tpMetaData;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbLongDescription;
        private System.Windows.Forms.Label lbLongDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbWriter;
        private System.Windows.Forms.Label lbWriter;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.TextBox tbCast;
        private System.Windows.Forms.Label lbCast;
        private System.Windows.Forms.TextBox tbReleaseDate;
        private System.Windows.Forms.Label lbReleaseDate;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.TabPage tpExtendedMeta;
        private System.Windows.Forms.ComboBox cbMediaType;
        private System.Windows.Forms.Label lbMediaType;
        private System.Windows.Forms.Panel pMediaSpecific;
        private System.Windows.Forms.ComboBox cbContentRating;
        private System.Windows.Forms.Label lbContentRating;
        private System.Windows.Forms.ComboBox cbHD;
        private System.Windows.Forms.Label lbHD;
        private System.Windows.Forms.Label lbSubtitles;
        private System.Windows.Forms.ListView lvSubtitles;
        private System.Windows.Forms.ColumnHeader chLang;
        private System.Windows.Forms.ColumnHeader chSubFile;
        private System.Windows.Forms.Button btnSelectChapters;
        private System.Windows.Forms.TextBox tbChaptersFile;
        private System.Windows.Forms.Label lbChapters;
        private System.Windows.Forms.Button btnAddSub;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}