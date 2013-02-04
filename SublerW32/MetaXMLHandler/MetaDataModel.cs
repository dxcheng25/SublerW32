using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SublerW32.MetaXMLHandler
{
    public class MetaDataModel
    {
        [XmlElement("Title")]
        public String title {get; set;}

        [XmlElement("ReleaseDate")]
        public String releaseDate {get; set;}

        [XmlElement("Director")]
        public String director{get; set;}

        [XmlElement("Writer")]
        public String writer{get; set;}

        [XmlElement("Cast")]
        public String cast{get; set;} 

        [XmlElement("Description")]
        public String description{get; set;}

        [XmlElement("LongDescription")]
        public String longDescription{get; set;}

        [XmlElement("Poster")]
        public String posterPath{get; set;}

        [XmlElement("MediaType")]
        public String mediaType{get; set;} 

        [XmlElement("ContentRate")]
        public String contentRate{get; set;}

        [XmlElement("HD")]
        public String hd{get; set;}

        [XmlElement("TVShow")]
        public String tvShow{get; set;}

        [XmlElement("Season#")]
        public String seasonNum{get; set;}

        [XmlElement("Episode#")]
        public String episodeNum{get; set;}

        [XmlElement("TVNetwork")]
        public String tvNetwork { get; set; }

        [XmlElement("Rating")]
        public String rating{get; set;}

        [XmlElement("Genre")]
        public String genre{get; set;}

        [XmlIgnore()]
        public String chaptersFilePath{get; set;}

        [XmlIgnore()]
        public List<KeyValuePair<String, String>> subtitles { get; set; }

        public MetaDataModel()
        {
            this.title = "";
            this.releaseDate = "";
            this.cast = "";
            this.director = "";
            this.writer = "";
            this.description = "";
            this.longDescription = "";
            this.posterPath = "";
            this.mediaType = "";
            this.contentRate = "";
            this.hd = "";
            this.tvShow = "";
            this.seasonNum = "";
            this.episodeNum = "";
            this.tvNetwork = "";
            this.genre = "";
            this.rating = "";
            this.chaptersFilePath = "";
            this.subtitles = new List<KeyValuePair<string,string>>();
        }

        public MetaDataModel(String title, String releaseDate,
                             String director, String writer,
                             String cast, String description,
                             String longDescription, String posterPath,
                             String mediaType, String contentRate,
                             String hd, String tvShow,
                             String seasonNum, String episodeNum, String tvNetwork,
                             String rating, String genre,
                             String chaptersFilePath, List<KeyValuePair<String, String>> subtitles)
        {
            this.title = title;
            this.releaseDate = releaseDate;
            this.cast = cast;
            this.director = director;
            this.writer = writer;
            this.description = description;
            this.longDescription = longDescription;
            this.posterPath = posterPath;
            this.mediaType = mediaType;
            this.contentRate = contentRate;
            this.hd = hd;
            this.tvShow = tvShow;
            this.seasonNum = seasonNum;
            this.episodeNum = episodeNum;
            this.tvNetwork = tvNetwork;
            this.genre = genre;
            this.rating = rating;
            this.chaptersFilePath = chaptersFilePath;
            this.subtitles = subtitles;
        }
    }
}
