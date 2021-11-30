using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TelegramBot
{
    public static class XmlSerializationHelper<T>
    {
        public static void SerializeInFile(T obj, string pathToFile)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }

        public static string SerializeInString(T obj)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            var xmlString = new StringBuilder();

            using (var stringWriter = new StringWriter())
            {
                formatter.Serialize(stringWriter, obj);
                xmlString = stringWriter.GetStringBuilder();
            }

            return xmlString.ToString();
        }

        public static T DeserializeFromFile(string pathToFile)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            T obj;

            using (Stream reader = new FileStream(pathToFile, FileMode.Open))
            {
                obj = (T)formatter.Deserialize(reader);
            }

            return obj;
        }

        public static T DeserializeFromString(string xmlString)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            T deserializedObj;

            using (var stringReader = new StringReader(xmlString))
            {
                deserializedObj = (T)formatter.Deserialize(stringReader);
            }

            return deserializedObj;
        }

        public static T CreateDeepCopy(T obj)
        {
            using (var ms = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                return (T)serializer.Deserialize(ms);
            }
        }
    }
}