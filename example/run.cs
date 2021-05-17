using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Xml;
using Models;
using XMLService;

namespace Controllers
{
    public class TestController
    {


        /// <summary>
        ///  Example to how convert Model to XMl and how can write xml in file
        /// </summary>
        public string getXML()
        {
            var pro1 = new TestModel
            {
                id = 5,
                Name = "Test",
                Age = 15

            };

            // Test Write xml to File
            XmlHelper.ObjectToXmlToFile(pro1, "yourPath");

            // Retrun Xml
            var xmlData = XmlHelper.ObjectToXmlString(pro1);

            return new StringContent(xmlData, Encoding.UTF8, "application/xml");

        }



        /// <summary>
        ///  Example to how convert XML to Model
        /// </summary>
        public TestModel StringXMLToModel()
        {
            var xmlText = @"
            <TestModel>
                <ID>5</ID>
                <Name>5</Name>
                <Age>15</Age>
            <TestModel/>";
            var temp = XmlHelper.XmlStringToObject<TestModel>(xmlText);
            return temp;
        }
    }
}
