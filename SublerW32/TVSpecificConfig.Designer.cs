namespace SublerW32
{
    partial class TVSpecificConfig
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.tbEpisodeNum = new System.Windows.Forms.TextBox();
            this.lbEpisodeNum = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.tbTVSeason = new System.Windows.Forms.TextBox();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.lbTVSeason = new System.Windows.Forms.Label();
            this.tbTVShow = new System.Windows.Forms.TextBox();
            this.lbRating = new System.Windows.Forms.Label();
            this.lbTVShow = new System.Windows.Forms.Label();
            this.lbTVNetwork = new System.Windows.Forms.Label();
            this.tbTVNetwork = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbGenre
            // 
            this.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "动作",
            "战争",
            "剧情",
            "喜剧",
            "生活",
            "青春偶像",
            "魔幻",
            "科幻",
            "纪录片",
            "恐怖",
            "惊悚",
            "悬疑",
            "医务",
            "律政",
            "真人秀",
            "罪案",
            "动画",
            "西部"});
            this.cbGenre.Location = new System.Drawing.Point(280, 64);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(121, 21);
            this.cbGenre.TabIndex = 14;
            this.cbGenre.SelectedIndexChanged += new System.EventHandler(this.cbGenre_SelectedIndexChanged);
            this.cbGenre.TextChanged += new System.EventHandler(this.cbGenre_SelectedValueChanged);
            // 
            // tbEpisodeNum
            // 
            this.tbEpisodeNum.Location = new System.Drawing.Point(53, 65);
            this.tbEpisodeNum.Name = "tbEpisodeNum";
            this.tbEpisodeNum.Size = new System.Drawing.Size(36, 20);
            this.tbEpisodeNum.TabIndex = 15;
            this.tbEpisodeNum.WordWrap = false;
            this.tbEpisodeNum.TextChanged += new System.EventHandler(this.tbEpisodeNum_Leave);
            // 
            // lbEpisodeNum
            // 
            this.lbEpisodeNum.AutoSize = true;
            this.lbEpisodeNum.Location = new System.Drawing.Point(50, 49);
            this.lbEpisodeNum.Name = "lbEpisodeNum";
            this.lbEpisodeNum.Size = new System.Drawing.Size(31, 13);
            this.lbEpisodeNum.TabIndex = 12;
            this.lbEpisodeNum.Text = "集数";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(277, 47);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(55, 13);
            this.lbGenre.TabIndex = 13;
            this.lbGenre.Text = "剧集类型";
            // 
            // tbTVSeason
            // 
            this.tbTVSeason.Location = new System.Drawing.Point(10, 65);
            this.tbTVSeason.Name = "tbTVSeason";
            this.tbTVSeason.Size = new System.Drawing.Size(36, 20);
            this.tbTVSeason.TabIndex = 10;
            this.tbTVSeason.WordWrap = false;
            this.tbTVSeason.TextChanged += new System.EventHandler(this.tbTVSeason_Leave);
            // 
            // cbRating
            // 
            this.cbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Items.AddRange(new object[] {
            "TV-Y",
            "TV-Y7",
            "TV-G",
            "TV-PG",
            "TV-14",
            "TV-MA",
            "Unrated"});
            this.cbRating.Location = new System.Drawing.Point(280, 22);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(121, 21);
            this.cbRating.TabIndex = 11;
            this.cbRating.TextChanged += new System.EventHandler(this.cbRating_SelectedValueChanged);
            // 
            // lbTVSeason
            // 
            this.lbTVSeason.AutoSize = true;
            this.lbTVSeason.Location = new System.Drawing.Point(8, 49);
            this.lbTVSeason.Name = "lbTVSeason";
            this.lbTVSeason.Size = new System.Drawing.Size(31, 13);
            this.lbTVSeason.TabIndex = 8;
            this.lbTVSeason.Text = "季数";
            // 
            // tbTVShow
            // 
            this.tbTVShow.Location = new System.Drawing.Point(10, 22);
            this.tbTVShow.Name = "tbTVShow";
            this.tbTVShow.Size = new System.Drawing.Size(244, 20);
            this.tbTVShow.TabIndex = 7;
            this.tbTVShow.WordWrap = false;
            this.tbTVShow.TextChanged += new System.EventHandler(this.tbTVShow_Leave);
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Location = new System.Drawing.Point(277, 5);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(55, 13);
            this.lbRating.TabIndex = 9;
            this.lbRating.Text = "剧集分级";
            // 
            // lbTVShow
            // 
            this.lbTVShow.AutoSize = true;
            this.lbTVShow.Location = new System.Drawing.Point(8, 5);
            this.lbTVShow.Name = "lbTVShow";
            this.lbTVShow.Size = new System.Drawing.Size(55, 13);
            this.lbTVShow.TabIndex = 6;
            this.lbTVShow.Text = "剧集名称";
            // 
            // lbTVNetwork
            // 
            this.lbTVNetwork.AutoSize = true;
            this.lbTVNetwork.Location = new System.Drawing.Point(103, 49);
            this.lbTVNetwork.Name = "lbTVNetwork";
            this.lbTVNetwork.Size = new System.Drawing.Size(43, 13);
            this.lbTVNetwork.TabIndex = 16;
            this.lbTVNetwork.Text = "电视网";
            // 
            // tbTVNetwork
            // 
            this.tbTVNetwork.Location = new System.Drawing.Point(106, 65);
            this.tbTVNetwork.Name = "tbTVNetwork";
            this.tbTVNetwork.Size = new System.Drawing.Size(148, 20);
            this.tbTVNetwork.TabIndex = 17;
            this.tbTVNetwork.WordWrap = false;
            this.tbTVNetwork.TextChanged += new System.EventHandler(this.tbTVNetwork_Leave);
            // 
            // TVSpecificConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbTVNetwork);
            this.Controls.Add(this.lbTVNetwork);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.tbEpisodeNum);
            this.Controls.Add(this.lbEpisodeNum);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.tbTVSeason);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.lbTVSeason);
            this.Controls.Add(this.tbTVShow);
            this.Controls.Add(this.lbRating);
            this.Controls.Add(this.lbTVShow);
            this.Name = "TVSpecificConfig";
            this.Size = new System.Drawing.Size(408, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.TextBox tbEpisodeNum;
        private System.Windows.Forms.Label lbEpisodeNum;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.TextBox tbTVSeason;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.Label lbTVSeason;
        private System.Windows.Forms.TextBox tbTVShow;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.Label lbTVShow;
        private System.Windows.Forms.Label lbTVNetwork;
        private System.Windows.Forms.TextBox tbTVNetwork;
    }
}
