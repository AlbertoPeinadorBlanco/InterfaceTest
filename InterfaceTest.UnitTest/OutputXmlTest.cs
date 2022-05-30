using System;
using NUnit.Framework;

namespace InterfaceTest.UnitTest
{
    [TestFixture]
    public class OutputXmlTest
    {

        [Test]
        public void OutputXml_IsDataOutputted_DataIsOutputted()
        {

            OutputXml outputXml;

            outputXml = new OutputXml();


            try
            {
                outputXml.DataOutput();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
            

        }
    }
}
