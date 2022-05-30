using System;

namespace InterfaceTest
{
    public class PersonFactory : IPersonCreation, ICloneable
    {


        /////////////////////////////
        //FUNCTION TO CREATE PERSONS//
        /////////////////////////////
        public Person CreatePerson(string _Name, string _Affiliation, string _Donor, string _Donation)
        {
            
            Person person = new Person()
            {

                Name = _Name,
                Affiliation = _Affiliation,
                Donor = _Donor,
                Donation = _Donation
                
            };


            PersonList.ListOfPersons.Add(person);
            return person;



        }

        /////////////////////////////
        //FUNCTION TO CLONE OBJECTS//
        /////////////////////////////
        public object Clone()
        {

            var person = (Person)MemberwiseClone();
            return person;

        }


    }
}
