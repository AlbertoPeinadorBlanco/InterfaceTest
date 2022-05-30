using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace InterfaceTest
{
    internal class PersonList : ICloneable
    {

        ////////////////////////////////
        //LIST TO STORE PERSON OBJECTS//
        ////////////////////////////////
        public static List<Person> ListOfPersons = new List<Person>();



        /////////////////////
        //SINGLETON PATTERN//
        /////////////////////
        public static class PersonListHolder
        {


            public static PersonList personList = new PersonList();


        }


        public static PersonList GetList()
        {


            return PersonListHolder.personList;


        }



        ////////////////////////////
        //FUNTION TO CLONE OBJECTS//
        ////////////////////////////
        public object Clone()
        {

            var person = (Person)MemberwiseClone();
            return person;

        }



    }

    
}
