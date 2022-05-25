using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SATRpaToJson.Extensions
{
    public static class XmlExtensions
    {
        public static T DeserializeXML<T>(this string xmlString)
        {
            T returnValue = default(T);

            XmlSerializer serial = new XmlSerializer(typeof(T));
            StringReader reader = new StringReader(xmlString);
            object result = serial.Deserialize(reader);

            if (result != null && result is T)
            {
                returnValue = ((T)result);
            }

            reader.Close();

            return returnValue;
        }
    }
}
