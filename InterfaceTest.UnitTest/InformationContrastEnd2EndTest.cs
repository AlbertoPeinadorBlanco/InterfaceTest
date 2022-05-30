using System;
using NUnit.Framework;
using System.Xml;

namespace InterfaceTest.UnitTest
{
    [TestFixture]
    public class InformationContrastEnd2EndTest
    {
        [Test]
        public void DataOutput_IsProcessedDataBeingOutputted_DataIsOutputedCorrectly()
        {
            var logic = new XmlLoaderLogic(new XmlLoader());


            logic.XmlOutput();

            XmlNodeList xmlNodeList = LoadedDocument.document.SelectNodes("publicwhip / regmem / category[@type = '3'] / ancestor::regmem / @membername");
            XmlNodeList xmlNodeListAffiliation = LoadedDocument.document.SelectNodes("publicwhip/regmem/category[@type='3']/ancestor::regmem/@personid");
            XmlNodeList xmlNodeListDonor = LoadedDocument.document.SelectNodes("publicwhip/regmem/category[@type='3']/record/item[1]");
            XmlNodeList xmlNodeListDonation = LoadedDocument.document.SelectNodes("publicwhip/regmem/category[@type='3']/record/item[1]/descendant::br[2]");


            Assert.That(xmlNodeList[0].InnerText, Is.EqualTo("Nigel Adams"));
            Assert.That(xmlNodeList[3].InnerText, Is.EqualTo("Fleur Anderson"));
            Assert.That(xmlNodeList[20].InnerText, Is.EqualTo("Suella Braverman"));

            Assert.That(xmlNodeListAffiliation[0].InnerText, Is.EqualTo("uk.org.publicwhip/person/24878"));
            Assert.That(xmlNodeListAffiliation[3].InnerText, Is.EqualTo("uk.org.publicwhip/person/25813"));
            Assert.That(xmlNodeListAffiliation[20].InnerText, Is.EqualTo("uk.org.publicwhip/person/25272"));

            Assert.That(xmlNodeListDonor[0].ChildNodes[0].InnerText, Is.EqualTo("Name of donor: Betting and Gaming Council (BGC)"));
            Assert.That(xmlNodeListDonor[3].ChildNodes[0].InnerText, Is.EqualTo("Name of donor: All England Lawn Tennis Club"));
            Assert.That(xmlNodeListDonor[20].ChildNodes[0].InnerText, Is.EqualTo("Name of donor: PG Paper Company Ltd"));

            Assert.That(xmlNodeListDonation[0].InnerText, Is.EqualTo("Amount of donation or nature and value if donation in kind: Ticket with hospitality to attend the Euro 2020 tournament, value £1,999.14"));
            Assert.That(xmlNodeListDonation[3].InnerText, Is.EqualTo("Amount of donation, or nature and value if donation in kind: Two tickets for the Royal Box at the Wimbledon Championships, with associated hospitality;  estimated value £480"));
            Assert.That(xmlNodeListDonation[20].InnerText, Is.EqualTo("Amount of donation or nature and value if donation in kind: Flight and taxi costs between Glasgow and London associated with speaking at a Diwali social gathering, value £350.48"));


        }
    }
}
