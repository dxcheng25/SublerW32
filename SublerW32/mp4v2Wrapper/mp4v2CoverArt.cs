using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace SublerW32.mp4v2Wrapper
{
    class mp4v2CoverArt
    {
        String mp4artPath = null;
        String mp4artArg = null;

        public mp4v2CoverArt(String pathToPoster, String pathToMp4File)
        {
            mp4artPath = Application.StartupPath + "\\libs\\mp4art.exe";
            mp4artArg = "--add " + pathToPoster + " " + pathToMp4File;
        }

        public void addArt()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = mp4artPath;
            proc.StartInfo.Arguments = mp4artArg;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardOutput = true;

            proc.Start();
            proc.BeginOutputReadLine();
            proc.OutputDataReceived += new DataReceivedEventHandler(proc_OutputDataReceived);
            proc.WaitForExit();

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
