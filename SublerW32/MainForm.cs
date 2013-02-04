using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SublerW32.CoreData;
using SublerW32.MetaXMLHandler;

namespace SublerW32
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "选择视频文件";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "MP4视频文件 (*.mp4)|*.mp4";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnSelectMeta_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "选择信息头XML文件";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "信息头XML文件 (*.mxml)|*.mxml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbMetaPath.Text = openFileDialog.FileName;
            }
        }

        private void tsmiNewMetaHeader_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "保存信息头XML文件";
            saveFileDialog.AddExtension = true;
            saveFileDialog.AutoUpgradeEnabled = true;
            saveFileDialog.Filter = "Meta Header Data File (*.mxml)|*.mxml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String MetaHeaderXMLFile = saveFileDialog.FileName;
                NewMetaHeader nmh = new NewMetaHeader(MetaHeaderXMLFile,
                                                      NewMetaHeader.OPType.New);
                nmh.ShowDialog();
            }
        }

        private void tsmiSelectVideoFile_Click(object sender, EventArgs e)
        {
            btnSelectFile_Click(sender, e);
        }

        private void tsmiSelectMetaHeader_Click(object sender, EventArgs e)
        {
            btnSelectMeta_Click(sender, e);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiEditMetaHeader_Click(object sender, EventArgs e)
        {
            String metaPath = null;

            if (!tbMetaPath.Text.Contains("\\"))
            {
                //File not selected
                openFileDialog.Title = "选择信息头XML文件";
                openFileDialog.FileName = "";
                openFileDialog.Filter = "信息头XML文件 (*.mxml)|*.mxml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    metaPath = openFileDialog.FileName;
                }
            }

            else
            {
                metaPath = tbMetaPath.Text;
            }

            NewMetaHeader mmh = new NewMetaHeader(metaPath, NewMetaHeader.OPType.Modify);
            mmh.ShowDialog();
        }

        private void tbFilePath_DragDrop(object sender, DragEventArgs e)
        {
            String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
            tbFilePath.Text = files[0];
        }

        private void tbFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true
                && ((string[]) e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".mp4"))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void tbMetaPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true
                && ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".mxml"))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void tbMetaPath_DragDrop(object sender, DragEventArgs e)
        {
            String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
            tbMetaPath.Text = files[0];
        }

        mp4v2Wrapper.mp4v2CoverArt mvca = null;
        mp4v2Wrapper.mp4v2Tagging mvt = null;
        List<MP4BoxWrapper.ImportTrack> lIT = new List<MP4BoxWrapper.ImportTrack>();

        private void btnCompile_Click(object sender, EventArgs e)
        {
            if (!tbFilePath.Text.EndsWith(".mp4") &&
                !tbMetaPath.Text.EndsWith(".mxml"))
            {

                MessageBox.Show(this, "请补全信息再试！", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MetaDataModel mdm;

            if (CoreData.CommonData.mdm == null)
            {
                MetaXMLReader metaReader = new MetaXMLReader();
                mdm = metaReader.readMetaHeaderFile(tbMetaPath.Text);
            }

            else
            {
                mdm = CoreData.CommonData.mdm;
            }

            if (mdm.posterPath != "")
            {
                mvca = new mp4v2Wrapper.mp4v2CoverArt(mdm.posterPath, tbFilePath.Text);
            }

            mvt = new mp4v2Wrapper.mp4v2Tagging(mdm, tbFilePath.Text);

            //Subtitles
            if (mdm.subtitles.Count != 0)
            {
                foreach (KeyValuePair<String, String> pair in mdm.subtitles)
                {
                    MP4BoxWrapper.MP4BoxTrackModel mtm 
                        = new MP4BoxWrapper.MP4BoxTrackModel();

                    mtm.trackName = "Subtitle Track";
                    mtm.trackToAdd = pair.Value;
                    mtm.trackType = MP4BoxWrapper.MP4BoxTrackModel.TrackType.Subtitle;
                    mtm.languageCode = pair.Key;
                    mtm.groupID = 2;
                    mtm.originalVideo = tbFilePath.Text;

                    lIT.Add(new MP4BoxWrapper.ImportTrack(mtm));
                }
            }

            //chapters
            if ( mdm.chaptersFilePath.EndsWith(".txt") || mdm.chaptersFilePath.EndsWith(".ogm") )
            {
                MP4BoxWrapper.MP4BoxTrackModel mtm
                        = new MP4BoxWrapper.MP4BoxTrackModel();

                mtm.trackName = "Chapters";
                mtm.trackToAdd = mdm.chaptersFilePath;
                mtm.trackType = MP4BoxWrapper.MP4BoxTrackModel.TrackType.Chapter;
                mtm.originalVideo = tbFilePath.Text;

                lIT.Add(new MP4BoxWrapper.ImportTrack(mtm));
            }

            gbVideoNMeta.Enabled = false;
            btnCompile.Enabled = false;
            pbCompileProgress.Style = ProgressBarStyle.Marquee;
            pbCompileProgress.MarqueeAnimationSpeed = 100;

            mp4CompileWorker.RunWorkerAsync();
        }

        private void mp4CompileWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (mvca != null)
            {
                mvca.addArt();
            }

            if (mvt != null)
            {
                mvt.addTags();
            }

            foreach (MP4BoxWrapper.ImportTrack it in lIT)
            {
                it.Import();
            }
        }

        private void mp4CompileWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gbVideoNMeta.Enabled = true;
            btnCompile.Enabled = true;
            pbCompileProgress.MarqueeAnimationSpeed = 0;
            CoreData.CommonData.mdm = null;
            lIT.Clear();
        }
    }
}
