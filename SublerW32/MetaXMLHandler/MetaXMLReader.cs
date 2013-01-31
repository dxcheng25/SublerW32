using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace SublerW32.MetaXMLHandler
{
    class MetaXMLReader
    {
        public MetaDataModel readMetaHeaderFile(String filePath)
        {
            TextReader textReader = new StreamReader(filePath);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(MetaDataModel));
            MetaDataModel mdm = (MetaDataModel) xmlSerializer.Deserialize(textReader);

            textReader.Close();

            return mdm;
        }
    }
}
