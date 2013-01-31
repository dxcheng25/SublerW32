using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace SublerW32.MP4BoxWrapper
{
    class ImportTrack
    {
        public String MP4BoxPath = null;
        public String MP4BoxArg = null;
        public MP4BoxTrackModel mbtm = null;

        public ImportTrack ( MP4BoxTrackModel mbtm )
        {
            MP4BoxPath = Application.StartupPath + "\\libs\\MP4Box.exe";
            this.mbtm = mbtm;
        }

        public void Import()
        {
            switch (mbtm.trackType)
            {
                case MP4BoxTrackModel.TrackType.Subtitle:
                    MP4BoxArg = "-add " + mbtm.trackToAdd + ":name=" + mbtm.trackName + 
                                ":hdlr=sbtl:lang=" + mbtm.languageCode +
                                ":group=" + mbtm.groupID + " " + mbtm.originalVideo;
                    break;

                case MP4BoxTrackModel.TrackType.Chapter:
                    MP4BoxArg = "-add " + mbtm.trackToAdd + ":chap " + mbtm.originalVideo;
                    break;

                default:
                    break;
            }

            Process proc = new Process();
            proc.StartInfo.FileName = MP4BoxPath;
            proc.StartInfo.Arguments = MP4BoxArg;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardOutput = true;

            proc.Start();
            proc.BeginOutputReadLine();
            proc.OutputDataReceived += new DataReceivedEventHandler(proc_OutputDataReceived);

        }

        private void proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                Console.WriteLine(e.Data + Environment.NewLine);
            }
        }
    }
}
