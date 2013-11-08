using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Photo_Rainbow
{
    public class Storage
    {
        ImageColorData imagedata = new ImageColorData();
        System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(imagedata.GetType());
        System.IO.StreamWriter file = new System.IO.StreamWriter("C:\Users\praja\Documents\GitHub\Photo-Rainbow\Imagedata.xml");

        writer.serializer(File, imagedata);
        file.Close();
    }
}
