using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace SublerW32.MetaXMLHandler
{
    class MetaXMLWriter
    {
        public String MHDFPath = null;

        public MetaXMLWriter(String MHDFPath)
        {
            this.MHDFPath = MHDFPath;
        }

        public void SaveFile(String title, String releaseDate, 
                             String director, String writer,
                             String cast, String description,
                             String longDescription, String posterPath,
                             String mediaType, String contentRate,
                             String hd, String tvShow, 
                             String seasonNum, String episodeNum, String tvNetwork,
                             String rating, String genre,
                             String chaptersFilePath, List<KeyValuePair<String, String>> subtitles)
        {
            if (posterPath == null)
            {
                posterPath = "";
            }

            MetaDataModel metaDataModel = new MetaDataModel(title, releaseDate, director, writer,
                                                            cast, description, longDescription,
                                                            posterPath, mediaType, contentRate,
                                                            hd, tvShow, seasonNum, episodeNum,
                                                            tvNetwork, rating, genre, chaptersFilePath,
                                                            subtitles);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(MetaDataModel));
            TextWriter textWriter = new StreamWriter(MHDFPath);
            xmlSerializer.Serialize(textWriter, metaDataModel);
            textWriter.Close();
        }
    }
}
