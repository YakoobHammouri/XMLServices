using System;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Models
{
    [XmlRoot(ElementName = "TestModel")]
    public class TestModel
    {

        [XmlElement(ElementName = "ID")]
        public int id { set; get; }
        public string Name { set; get; }

        /// <summary>
        ///  Handle Nullable Property
        /// </summary>
        [XmlIgnore] public int? age;
        [XmlElement("Age")]
        public string Age
        {
            get => age?.ToString();
            set
            {
                if (value != null)
                    age = int.Parse(value);
                else
                    age = null;
            }
        }


    }
}