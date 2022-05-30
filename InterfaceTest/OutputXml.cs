using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class OutputXml
    {

        ////////////////////////////////////////////
        //FUNCTION TO OUTPUT ALL THE DATA GATHERED//
        ////////////////////////////////////////////
        public void DataOutput()
        {

            PersonCreationLogic personCreation;
            XmlLoaderLogic xmlLoaderLogic;
            XmlDataLogic xmlLogic;

            XmlData xmlData;

            IPersonCreation person;
            Iloading filePath;

            filePath = new XmlLoader();
            person = new PersonFactory();


            xmlData = new XmlData();


            personCreation = new PersonCreationLogic(person);
            xmlLoaderLogic = new XmlLoaderLogic(filePath);
            xmlLogic = new XmlDataLogic(xmlData, personCreation);


            xmlLoaderLogic.XmlOutput();


            xmlLogic.LoadData();

        }

    }
}
