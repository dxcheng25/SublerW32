namespace SublerW32
{
    partial class MovieSpecificConfig
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
            this.lbGenre = new System.Windows.Forms.Label();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.lbRating = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbGenre
            // 
            this.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "动作与冒险",
            "日本动漫",
            "经典电影",
            "喜剧",
            "纪录片",
            "剧情",
            "恐怖",
            "独立电影",
            "儿童与家庭",
            "音乐剧",
            "浪漫",
            "科幻与幻想",
            "短剧",
            "惊悚",
            "体育",
            "西部",
            "电视电影",
            "日本院线",
            "韩国院线"});
            this.cbGenre.Location = new System.Drawing.Point(12, 64);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(121, 21);
            this.cbGenre.TabIndex = 14;
            this.cbGenre.SelectedIndexChanged += new System.EventHandler(this.cbGenre_SelectedIndexChanged_1);
            this.cbGenre.TextChanged += new System.EventHandler(this.cbGenre_SelectedIndexChanged);
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(9, 47);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(55, 13);
            this.lbGenre.TabIndex = 13;
            this.lbGenre.Text = "电影类型";
            // 
            // cbRating
            // 
            this.cbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Items.AddRange(new object[] {
            "Unrated",
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-17"});
            this.cbRating.Location = new System.Drawing.Point(12, 22);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(121, 21);
            this.cbRating.TabIndex = 11;
            this.cbRating.TextChanged += new System.EventHandler(this.cbRating_SelectedIndexChanged);
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Location = new System.Drawing.Point(9, 5);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(55, 13);
            this.lbRating.TabIndex = 9;
            this.lbRating.Text = "电影分级";
            // 
            // MovieSpecificConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.lbRating);
            this.Name = "MovieSpecificConfig";
            this.Size = new System.Drawing.Size(408, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.Label lbRating;
    }
}
