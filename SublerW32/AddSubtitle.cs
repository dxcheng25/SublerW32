using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SublerW32
{
    public partial class AddSubtitle : Form
    {
        public String subLang = null;
        public String subFilePath = null;

        public AddSubtitle()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "选择字幕文件";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "SRT字幕文件 (*.srt) | *.srt";
            
            if( openFileDialog.ShowDialog() == DialogResult.OK )
            {
                tbSubFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbSubLang.Text == "" || !tbSubFilePath.Text.Contains("\\"))
            {
                MessageBox.Show(this, "需补全相关内容", "错误！",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                subLang = cbSubLang.Text;
                subFilePath = tbSubFilePath.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void tbSubFilePath_DragDrop(object sender, DragEventArgs e)
        {
            String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
            tbSubFilePath.Text = files[0];
        }

        private void tbSubFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true
            && ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".srt"))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void cbSubLang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
