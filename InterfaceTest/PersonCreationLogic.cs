using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class PersonCreationLogic
    {
        

        private readonly IPersonCreation _person;



        /////////////////////////////
        //CONSTRUCTOR FOR THE CLASS//
        /////////////////////////////
        
        public PersonCreationLogic(IPersonCreation person)
        {


            _person = person;
            

        }

        //////////////////////////////////////////////////////////////////////
        //CALLING A FUNCTION TO CREATE PERSONS AND DETERMINED THE ATTRIBUTES//
        //////////////////////////////////////////////////////////////////////
        
        public Person PersonCreation(string _Name, string _Affiliation, string _Donor, string _Donation)
        {
            try
            {

                _person.CreatePerson(_Name, _Affiliation, _Donor, _Donation);

                return new Person();


            }
            catch (Exception)
            {

                throw new Exception("Members Could not be Found!!");


            }

            

            
        }
        

        
    }
}
