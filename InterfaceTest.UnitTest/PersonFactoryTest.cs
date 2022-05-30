using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace InterfaceTest.UnitTest
{
    [TestFixture]
    internal class PersonFactoryTest
    {

        [Test]
        public void CreatePerson_PersonCreated_ReturnsPerson()
        {

            var personFactory = new PersonFactory();


            string _Name = "a";
            string _Affiliation = "b";
            string _Donor = "c";
            string _Donation = "d";


            var person = personFactory.CreatePerson(_Name, _Affiliation, _Donor, _Donation);
            
            

            Assert.That(person.Name, Is.EqualTo(_Name));
            Assert.That(person.Affiliation, Is.EqualTo(_Affiliation));
            Assert.That(person.Donor, Is.EqualTo(_Donor));
            Assert.That(person.Donation, Is.EqualTo(_Donation));
        }


       


    }
}
