using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceTest.Properties;
using System.Windows.Forms;

namespace InterfaceTest
{
    public class XmlLoaderLogic
    {

        /////////////////
        //DOCUMENT PATH//
        /////////////////
        public object filePath = Resources.regmem2022_02_28;
        

        private readonly Iloading _filePath;


        /////////////////////////////
        //CONSTRUCTOR FOR THE CLASS//
        /////////////////////////////
        public XmlLoaderLogic(Iloading filePath)
        {

            _filePath = filePath;

        }

       




        /////////////////////////////////
        //METHOD TO OUTPUT XML DOCUMENT//
        /////////////////////////////////
        public void XmlOutput()
        {

            try
            {

                _filePath.LoadDocument(filePath);

            }
            catch (Exception)
            {
                
                throw new Exception("The Document Could not be Found.");

            }


        }


    }


}
