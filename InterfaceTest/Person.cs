using System;

namespace InterfaceTest
{
    public class Person : ICloneable
    {


        ///////////////////////////////
        //DECLARING PERSON PROPERTIES//
        ///////////////////////////////
        public string Name { get; set; }
        public string Affiliation { get; set; }
        public string Donor { get; set; }
        public string Donation { get; set; }


        ////////////////////////////////////
        //CLON METHOD TO CLONE THE OBJECTS//
        ////////////////////////////////////
        public object Clone()
        {

            var person = (Person)MemberwiseClone();
            return person;


        }

       
    }
}
