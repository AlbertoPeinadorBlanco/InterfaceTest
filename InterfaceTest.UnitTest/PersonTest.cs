using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace InterfaceTest.UnitTest
{

    [TestFixture]
    internal class PersonTest
    {

        [Test]
        public void PersonObject_CanBeCreated_ItCanBeCretaed()
        {
            Person person = new Person();

            person.Name = "a";
            person.Affiliation = "b";
            person.Donor = "c";
            person.Donation = "d";

            Assert.IsNotNull(person);
        }
    }
}
