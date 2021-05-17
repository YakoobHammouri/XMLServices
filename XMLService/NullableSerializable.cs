using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Eservices.XMLService
{
    public class NullableSerializable : IXmlSerializable
    {

        private string _prop;

        public NullableSerializable(string name)
        {
            _prop = name;
        }

        public NullableSerializable()
        {
            _prop = null;
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(_prop);
        }

        public void ReadXml(XmlReader reader)
        {
            _prop = reader.ReadString();
        }

        public XmlSchema GetSchema()
        {
            return (null);
        }

        public override string ToString()
        {
            return (_prop);
        }
    }
}