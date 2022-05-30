using System;
using System.Windows.Forms;


namespace InterfaceTest
{
    public partial class Form1 : Form
    {
    

        OutputXml outputXml;


        public Form1()
        {

            InitializeComponent();

            outputXml = new OutputXml();

            outputXml.DataOutput();

            FilComboBox();

        }


        //////////////////////////////////////////////////////////////////////////////////////////
        //POPULATES THE COMBOBOX WITH THE NAME VALUE FROM THE PERSONS STORED IN THE PERSONS LIST//
        //////////////////////////////////////////////////////////////////////////////////////////
        private void FilComboBox()
        {


            if (PersonList.ListOfPersons != null)
            {

                foreach (Person person in PersonList.ListOfPersons)
                {
                    if(person.Name != null)
                    {
                        cbNames.Items.Add(person.Name);

                    }
                    else
                    {
                        person.Name = "Null";
                        cbNames.Items.Add(person.Name);
                    }
                }
            }
            else
            {

                cbNames.Items.Add("No Names.");

            }

        }


        //////////////////////////
        //METHOD TO FILL LISTBOX//
        //////////////////////////
        private void lstBoxFil()
        {

            if (cbNames.Items.Count > 0)
            {

                int index = cbNames.FindString(cbNames.Text);
                cbNames.SelectedIndex = index;


                lstDtaDisplay.Items.Add((string)cbNames.SelectedItem);

                string donor = PersonList.ListOfPersons[index].Donor;

                string donation = PersonList.ListOfPersons[index].Donation;

                string affiliation = PersonList.ListOfPersons[index].Affiliation;


                if(donor != null)
                {
                    lstDtaDisplay.Items.Add(donor);

                }
                else if (donor == null)
                {
                    lstDtaDisplay.Items.Add("Null");
                }
                if (donation != null)
                {
                    lstDtaDisplay.Items.Add(donation);

                }
                else if (donation == null)
                {
                    lstDtaDisplay.Items.Add("Null");
                }
                if (affiliation != null)
                {
                    lstDtaDisplay.Items.Add(affiliation);

                }
                else if (affiliation == null)
                {
                    lstDtaDisplay.Items.Add("Null");
                }

            }
            else
            {
                lstDtaDisplay.Items.Add("No Items to Display.");
            }

        }

        //////////////////////////////////////////////////////////////////////////////////////////
        //EVENT TO HANDLE THE CHANGES IN THE DROPDOWN LIST WITH THE METHOD LSTBOXFIL IMPLEMENTED//
        //////////////////////////////////////////////////////////////////////////////////////////
        private void cbNames_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstDtaDisplay.Items.Clear();

            lstBoxFil();

        }

    }
}
