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

        public void SaveFile( MetaDataModel mdm )
        {
            if (mdm.posterPath == null)
            {
                mdm.posterPath = "";
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(MetaDataModel));
            TextWriter textWriter = new StreamWriter(MHDFPath);
            xmlSerializer.Serialize(textWriter, mdm);
            textWriter.Close();
        }
    }
}
