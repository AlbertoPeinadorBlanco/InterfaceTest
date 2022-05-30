using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InterfaceTest 
{
    public class XmlData : IXmlData
    {


        private string _Name;
        private string _Affiliation;
        private string _Donor;
        private string _Donation;


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        //FUNCTION TO SELECT THE RIGHT VALUES FROM XML DOCUMENT & ASSIGN THEM TO PERSON OBJECTS AT THEIR CREATION//
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public void DataGather(PersonCreationLogic personCreationLogic)
        {


            try
            {


                XmlNodeList xmlNodeList = LoadedDocument.document.SelectNodes("publicwhip/regmem/category[@type='3']/ancestor::regmem/@membername");
                XmlNodeList xmlNodeListAffiliation = LoadedDocument.document.SelectNodes("publicwhip/regmem/category[@type='3']/ancestor::regmem/@personid");
                XmlNodeList xmlNodeListDonor = LoadedDocument.document.SelectNodes("publicwhip/regmem/category[@type='3']/record/item[1]");
                XmlNodeList xmlNodeListDonation = LoadedDocument.document.SelectNodes("publicwhip/regmem/category[@type='3']/record/item[1]/descendant::br[2]");




                if (xmlNodeList != null && xmlNodeListAffiliation != null && xmlNodeListDonation != null && xmlNodeListDonor != null)
                {



                    for (int i = 0; i < xmlNodeList.Count; i++)
                    {


                        personCreationLogic.PersonCreation(_Name, _Affiliation, _Donor, _Donation);

                        _Name = xmlNodeList[i].InnerText;
                        _Affiliation = xmlNodeListAffiliation[i].InnerText;
                        _Donor = xmlNodeListDonor[i].ChildNodes[0].InnerText;


                        if (xmlNodeListDonation.Item(i) != null)
                        {
                            _Donation = xmlNodeListDonation[i].InnerText;
                        }
                        else
                        {
                            _Donation = "null";
                        }


                    }





                }
                else if(xmlNodeList == null && xmlNodeListAffiliation == null && xmlNodeListDonation == null && xmlNodeListDonor == null)
                {
                    personCreationLogic.PersonCreation(_Name, _Affiliation, _Donor, _Donation);


                    _Name = "null";
                    _Donor = "null";
                    _Affiliation = "null";
                    _Donation = "null";

                }
                

                

            }
            catch (Exception)
            {

                throw new Exception("The Document Could not be Found.");

            }



            

        }

    }
}
