using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SublerW32.MP4BoxWrapper
{
    class MP4BoxTrackModel
    {
        public enum TrackType { Video, Audio, Subtitle, Chapter }

        public TrackType trackType { set; get; }
        public int trackID { set; get; }
        public string languageCode { set; get; }
        public string trackName { set; get; }
        public string hdlrCode { set; get; }
        public bool isDisabled { set; get; }
        public int groupID { set; get; }
        public double fps { set; get; }

        public string fontName { set; get; }
        public string fontSize { set; get; }

        public bool isChapter { set; get; }

        public string trackToAdd { set; get; }
        public string originalVideo { set; get; }
    }
}
