using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public interface IPersonCreation
    {

        //////////////////////
        //METHOD DECLARATION//
        //////////////////////
        Person CreatePerson(string _Name, string _Affiliation, string _Donor, string _Donation);


    }
}
