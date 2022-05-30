using System;

namespace InterfaceTest
{
    public class XmlLoader : Iloading 
    {
   

        ////////////////////////////
        //FUNTION TO LOAD DOCUMENT//
        ////////////////////////////
        public void LoadDocument(object filePath)
        {

            try
            {


                LoadedDocument.document.LoadXml(filePath.ToString());


            }
            catch (global::System.Exception)
            {


                throw new Exception("The Document Could not be Found.");


            }


        }


    }

             
}

