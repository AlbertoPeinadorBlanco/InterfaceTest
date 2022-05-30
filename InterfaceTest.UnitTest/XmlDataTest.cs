using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Xml;

namespace InterfaceTest.UnitTest
{
    [TestFixture]
    internal class XmlDataTest
    {

        [Test]
        public void LoadedDocument_CanOtherDocumentBeLoaded_ReturnsDocument()
        {


            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = true;


            using (XmlWriter writer = XmlWriter.Create("XmlTest.xml", settings))
            {

                writer.WriteStartElement("user");
                writer.WriteElementString("name", "A");
                writer.WriteElementString("id", "01");
                writer.WriteElementString("address", "B");
                writer.WriteEndElement();
                writer.Flush();


            }

            XmlDocument doc = new XmlDocument();

            doc.Load("XmlTest.xml");

            LoadedDocument.document = doc;

            XmlNodeList nodeList = LoadedDocument.document.SelectNodes("user");


            Assert.That(nodeList[0].InnerText, Is.EqualTo("A01B"));

        }


        [Test]
        public void DataGather_DoesFunctionWork_FunctionWorks()
        {

            var personCreationLogic = new PersonCreationLogic(new PersonFactory());
            var data = new XmlData();



            try
            {
                data.DataGather(personCreationLogic);

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
