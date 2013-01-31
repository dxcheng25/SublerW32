using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SublerW32.mp4v2Wrapper
{
    class mp4v2Tagging
    {
        String mp4tagsPath = null;
        String mp4tagsArg = null;

        public mp4v2Tagging(MetaXMLHandler.MetaDataModel mdm, String pathToMp4File)
        {
            mp4tagsPath = Application.StartupPath + "\\libs\\mp4tags.exe";
            mp4tagsArg = "-genre " + mdm.genre + " -longdesc " + quote(mdm.longDescription) +
                         " -description " + quote(mdm.description) + " -rating " + 
                         mdm.contentRate + " -year " + mdm.releaseDate;

            if (mdm.hd == "SD")
            {
                mp4tagsArg += " -hdvideo 0";
            }

            else
            {
                mp4tagsArg += " -hdvideo 1";
            }

            if (mdm.mediaType == "电视剧")
            {
                mp4tagsArg += " -type tvshow -network " + mdm.tvNetwork + " -show " +
                              quote(mdm.tvShow) + " -episode " + mdm.episodeNum + " -season " +
                              mdm.seasonNum;
            }

            mp4tagsArg += " " + quote(pathToMp4File);
        }

        public void addTags()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = mp4tagsPath;
            proc.StartInfo.Arguments = mp4tagsArg;
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

        private String quote(String s)
        {
            return "\"" + s + "\"";
        }
    }
}
