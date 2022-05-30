using NUnit.Framework;
using System.Xml;

namespace InterfaceTest.UnitTest
{


    [TestFixture]
    internal class XmlLoaderTest
    {

        [Test]
        public void LoadDocument_IsFilePathNull_FilepathIsNotNull()
        {
            var logic = new XmlLoaderLogic(new XmlLoader());

            var filePath = logic.filePath;

            Assert.That(filePath != null, Is.True);


        }


        [Test]
        public void LoadDocument_DocumentLoad_ReturnsDocument()
        {

            var outputData = new XmlLoader();
            var logic = new XmlLoaderLogic(new XmlLoader());


            var filePath = logic.filePath;



            outputData.LoadDocument(filePath);


            Assert.IsNotNull(LoadedDocument.document);



        }

        


        [Test]
        public void LoadDocument_DoesModuleFunctions_ModuleFunctions()
        {


            var logic = new XmlLoaderLogic(new XmlLoader());


            logic.XmlOutput();


            Assert.IsNotEmpty(LoadedDocument.document);
        }



    }
}
