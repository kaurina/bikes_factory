using MyBikesFactory.Business;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Data
{
    public static class BikesXmlData
    {
        public static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "bikes.xml";
        }

        public static List<Bikes> Load()
        {
            string filePath = GetFilePath();
            if (!File.Exists(filePath))
                return new List<Bikes>();


            string fileContent = File.ReadAllText(filePath);
            if (fileContent == "")
                return new List<Bikes>();

            using (var reader = new StringReader(fileContent))
            {
                var serializer = new XmlSerializer(typeof(List<Bikes>));
                return (List<Bikes>)serializer.Deserialize(reader)!;
            }
        }

        public static void Save(List<Bikes> list)
        {
            string filePath = GetFilePath();
            using (var writer = new StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(typeof(List<Bikes>));//converts the list even from child classes from c# to xml
                serializer.Serialize(writer, list);
            }
        }
    }
}
