using System;

namespace InterfaceTest
{
    class XmlDataLogic
    {

        private readonly IXmlData _xmlData;
        private readonly PersonCreationLogic _personCreation;

        /////////////////////////////
        //CONSTRUCTOR FOR THE CLASS//
        /////////////////////////////
        
        public XmlDataLogic(IXmlData xmlData, PersonCreationLogic personCreation)
        {
            _xmlData = xmlData;
            _personCreation = personCreation;

            
        }

        //////////////////////////////////////////////////
        //CALLING A FUNCTION TO GATHER DATA FROM OBJECTS//
        //////////////////////////////////////////////////
        public object LoadData()
        {
            try
            {
                
                _xmlData.DataGather(_personCreation);


                return new XmlData();

            }
            catch (Exception)
            {

                throw new Exception("No Data Found!");


            }
            
        }

    }
}
