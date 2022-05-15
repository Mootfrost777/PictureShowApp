using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PicturePackagerLibrary
{
    /// <summary>
    /// Сегмент изображения
    /// </summary>
    public class PicturePackage
    {
        private string name;
        private int id;
        private int segmentNumber;
        private int numberOfSegments;
        private byte[] segmentBuffer;  

        public string Name { get { return name; } }
        public int Id { get { return id; } }
        public int SegmentNumber { get { return segmentNumber; } }
        public int NumberOfSegments { get { return numberOfSegments;} }
        public byte[] SegmentBuffer { get { return segmentBuffer; } }

        /// <summary>
        /// Создание сегмента изображения.
        /// Использует серверным приложением
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="numberOfSegments"></param>
        /// <param name="segmentBuffer"></param>
        public PicturePackage(string name, int id, int segmentNumber,
            int numberOfSegments, byte[] segmentBuffer)
        {
            this.name = name;
            this.id = id;
            this.segmentNumber = segmentNumber;
            this.numberOfSegments = numberOfSegments;
            this.segmentBuffer = segmentBuffer;
        }

        /// <summary>
        /// Создание сегмента изображения по XML-коду.
        /// Используется в клиентском приложении
        /// </summary>
        /// <param name="xml"></param>
        public PicturePackage(XmlDocument xml)   // мб строка будет как параметр
        {
            XmlNode rootNode = xml.SelectSingleNode("PicturePackage");
            id = int.Parse(rootNode.Attributes["Number"].Value);

            XmlNode nodeName = rootNode.SelectSingleNode("Name");
            name = nodeName.InnerXml;

            XmlNode nodeData = rootNode.SelectSingleNode("Data");
            segmentNumber = int.Parse(nodeData.Attributes["SegmentNumber"].Value);
            numberOfSegments = int.Parse(nodeData.Attributes["LastSegmentNumber"].Value);
            int size = int.Parse(nodeData.Attributes["Size"].Value);

            // декодирование из base64
            segmentBuffer = Convert.FromBase64String(nodeData.InnerText);
        }

        /// <summary>
        /// Преобразование сегмента изображения в XmlDocument
        /// </summary>
        /// <returns></returns>
        public string GetXml()
        {
            XmlDocument doc = new XmlDocument();

            // Корневой элемент <PicturePackage>
            XmlElement picturePackage = doc.CreateElement("PicturePackage");

            XmlAttribute pictureNumber = doc.CreateAttribute("Number");
            pictureNumber.Value = id.ToString();
            picturePackage.Attributes.Append(pictureNumber);

            // <Name> ... </Name>
            XmlElement pictureName = doc.CreateElement("Name");
            pictureName.InnerText = name;
            picturePackage.AppendChild(pictureNumber);

            // <Data SegmentNumber=... Size=...>
            XmlElement data = doc.CreateElement("Data");
            XmlAttribute numberAttribute = doc.CreateAttribute("SegmentNumber");
            numberAttribute.Value = segmentNumber.ToString();
            data.Attributes.Append(numberAttribute);

            XmlAttribute lastNumberAttribute = doc.CreateAttribute("LastSegmentNumber");
            lastNumberAttribute.Value = numberOfSegments.ToString();
            data.Attributes.Append(lastNumberAttribute);

            XmlAttribute sizeAttribute = doc.CreateAttribute("Size");
            sizeAttribute.Value = segmentBuffer.Length.ToString();
            data.Attributes.Append(sizeAttribute);

            data.InnerText = Convert.ToBase64String(segmentBuffer);

            picturePackage.AppendChild(data);

            doc.AppendChild(picturePackage);

            return doc.InnerXml;
        }
    }
}
