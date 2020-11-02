using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CycloRoutes.Models
{
    //public class BikeTrailDeserializer
    //{
    //    public void DeserializeXml(string filePath)
    //    {
    //        XmlSerializer serializer = new XmlSerializer(typeof(Records));
    //        Records records;
    //        using (Stream reader =
    //            new FileStream(filePath, FileMode.Open))
    //        {
    //            records = (Records)serializer.Deserialize(reader);
    //        }
    //    }
    //}
    //[Serializable()]
    //[XmlRoot(ElementName = "dsti_data")]
    //public class Records
    //{   
    //    [XmlElement("record")]
    //    public Trail[] Trails;
    //}
    //[Serializable()]
    //[XmlRoot("record")]
    //public class Trail
    //{
    //    [XmlAttribute("id")]
    //    public int ID;
    //    [XmlAttribute("related")]
    //    public int[] RelatedIDs;
    //    [XmlElement("name")]
    //    public string Name;
    //    [XmlElement("annotation")]
    //    public string Description;
    //    [XmlElement("region")]
    //    public string Region;
    //    [XmlElement("phone")]
    //    public string[] Phone;
    //    [XmlElement("mobile")]
    //    public string[] Mobile;
    //    [XmlElement("www")]
    //    public string[] Page;
    //    [XmlElement("address")]
    //    public Address Address;
    //}
    //[Serializable()]
    //[XmlRoot("address")]
    //public class Address
    //{
    //    [XmlElement("gps")]
    //    public float[] Gps;
    //    [XmlElement("locality")]
    //    public string Locality;
    //    [XmlElement("locality"), XmlAttribute("id")]
    //    public int LocalityID;
    //    [XmlElement("region")]
    //    public string Region;
    //    [XmlElement("region"), XmlAttribute("id")]
    //    public string RegionID;
    //    [XmlElement("street")]
    //    public string Street;
    //    [XmlElement("cp")]
    //    public int HouseNum;
    //    [XmlElement("municipality")]
    //    public string Municipality;
    //    [XmlElement("zip")]
    //    public string Zip;
    //}
}
