using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Photo_Rainbow
{
    public class XMLWrite
    {
        public class Image
        {
            public Data ColorData;
        }

        public class Data
        {
            public string brightness;
            public string violet;
            public string indigo;
            public string blue;
            public string green;
            public string yellow;
            public string orange;
            public string red;
        }

        private void SerializeImage(string filename)
        {
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(Data));
            Data ColorData = new Data();

            ColorData.brightness = ImageColorData._brightnessColorDict;
            ColorData.violet = ImageColorData.pixelColorHue;
            ColorData.indigo = ImageColorData.pixelColorHue;
            ColorData.blue = ImageColorData.pixelColorHue;
            ColorData.green = ImageColorData.pixelColorHue;
            ColorData.yellow = ImageColorData.pixelColorHue;
            ColorData.orange = ImageColorData.pixelColorHue;
            ColorData.red = ImageColorData.pixelColorHue;

            FileStream fs = new FileStream(filename, FileMode.Create);
            TextWriter writer = new StreamWriter(fs, new UTF8Encoding());
            // Serialize using the XmlTextWriter.
            xs.Serialize(writer, ColorData);
            writer.Close();
        }
    }
}
