using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SublerW32.MetaXMLHandler;
using System.IO;

namespace SublerW32
{
    public partial class NewMetaHeader : Form
    {
        String MHDFPath = null;
        TVSpecificConfig tvsc = null;
        MovieSpecificConfig msc = null;
        MetaDataModel mdm = null;

        public enum OPType { New, Modify }

        public NewMetaHeader()
        {
            InitializeComponent();
        }

        public NewMetaHeader(String MHDFPath, OPType opType)
        {
            InitializeComponent();
            tcMetaInfo.TabPages.Remove(tpMISummary);
            this.MHDFPath = MHDFPath;

            if (opType == OPType.Modify)
            {
                //Deserialize XML file
                MetaXMLReader mxReader = new MetaXMLReader();
                mdm = mxReader.readMetaHeaderFile(MHDFPath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MetaXMLWriter xmlReader = new MetaXMLWriter(MHDFPath);
            List<KeyValuePair<String, String>> subtitles = new List<KeyValuePair<string, string>>();
            String tvNetwork = "";
            String genre = "";
            String rating = "";
            String tvShow = "";
            String episodeNum = "";
            String seasonNum = "";

            foreach (ListViewItem item in lvSubtitles.Items)
            {
                subtitles.Add(new KeyValuePair<String, String>(item.SubItems[0].Text, item.SubItems[1].Text));
            }

            if (tvsc != null)
            {
                tvShow = tvsc.tvShow;
                tvNetwork = tvsc.tvNetwork;
                seasonNum = tvsc.seasonNum;
                episodeNum = tvsc.episodeNum;

                if (cbMediaType.Text == "电视剧")
                {
                    genre = tvsc.genre;
                    rating = tvsc.rating;
                }
            }

            if (msc != null)
            {
                if (cbMediaType.Text == "电影")
                {
                    genre = msc.genre;
                    rating = msc.rating;
                }
            }

            xmlReader.SaveFile(tbTitle.Text, tbReleaseDate.Text, tbDirector.Text,
                               tbWriter.Text, tbCast.Text, tbDescription.Text,
                               tbLongDescription.Text, pbPoster.ImageLocation,
                               cbMediaType.Text, cbContentRating.Text,
                               cbHD.Text, tvShow, seasonNum, episodeNum,
                               tvNetwork, rating, genre,
                               tbChaptersFile.Text, subtitles);

            this.Close();
        }

        private void btnSelectChapters_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "章节文件 (*.xml)|*.xml";
            openFileDialog.Title = "选择章节文件";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbChaptersFile.Text = openFileDialog.FileName;
            }
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            AddSubtitle addSubtitle = new AddSubtitle();
            if (addSubtitle.ShowDialog() == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem(addSubtitle.subLang);
                lvi.SubItems.Add(addSubtitle.subFilePath);

                lvSubtitles.Items.Add(lvi);
            }

            lvSubtitles.Refresh();
        }

        private void tbReleaseDate_Click(object sender, EventArgs e)
        {
            tbReleaseDate.Text = "";
            tbReleaseDate.TextAlign = HorizontalAlignment.Left;
        }

        private void cbMediaType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbMediaType.Text == "电视剧")
            {
                if (tvsc == null)
                {
                    tvsc = new TVSpecificConfig();
                }

                pMediaSpecific.Controls.Clear();
                pMediaSpecific.Controls.Add(tvsc);
            }

            else if (cbMediaType.Text == "电影")
            {
                if (msc == null)
                {
                    msc = new MovieSpecificConfig();
                }

                pMediaSpecific.Controls.Clear();
                pMediaSpecific.Controls.Add(msc);
            }

            else
            {
                pMediaSpecific.Controls.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbChaptersFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true
                && ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".xml"))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void tbChaptersFile_DragDrop(object sender, DragEventArgs e)
        {
            String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
            tbChaptersFile.Text = files[0];
        }

        private void tpMetaData_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true
                && (((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".png")
                || ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".jpg")))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void tpMetaData_DragDrop(object sender, DragEventArgs e)
        {
            String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
            pbPoster.ImageLocation = files[0];
            pbPoster.Load();
        }

        private void NewMetaHeader_Load(object sender, EventArgs e)
        {
            lvSubtitles.Items.Clear();

            tvsc = new TVSpecificConfig(mdm);
            msc = new MovieSpecificConfig(mdm);

            //set component
            tbTitle.Text = mdm.title;
            tbReleaseDate.Text = mdm.releaseDate;
            tbDirector.Text = mdm.director;
            tbWriter.Text = mdm.writer;
            tbCast.Text = mdm.cast;
            tbDescription.Text = mdm.description;
            tbLongDescription.Text = mdm.longDescription;
            cbMediaType.Text = mdm.mediaType;
            cbContentRating.Text = mdm.contentRate;
            cbHD.Text = mdm.hd;
            tbChaptersFile.Text = mdm.chaptersFilePath;

            foreach (KeyValuePair<String, String> pair in mdm.subtitles)
            {
                lvSubtitles.Items.Add(new ListViewItem(new String[] { pair.Key, pair.Value }));
            }

            //picture box
            if (mdm.posterPath != "" && File.Exists(mdm.posterPath))
            {
                pbPoster.ImageLocation = mdm.posterPath;
            }
        }

        private void lvSubtitles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
