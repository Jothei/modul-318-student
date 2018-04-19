using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportGUI
{
    public partial class Form2 : Form
    {
        double distance;
        string idstartstation;
        string idendstation;
        string endstationname;
        string startstationname;
        public StationBoardRoot currentStation;
        Mainform myForm = new Mainform();
        Stations myStations = new Stations();
        Stations myStationsstart = new Stations();

        Transport myTransport = new Transport();
        ITransport myIEtransport = new Transport();
        Connection myConnection = new Connection();
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_to_Form1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            myForm.Show();
        }

        private void btn_searchstation_Click(object sender, EventArgs e)
        {
            
            myForm.typeahead(cb_fahrtaffelstationauswahl);
        }

        private void btn_to_Form1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_calcVerbindungen_Click(object sender, EventArgs e)
        {

            if (cb_fahrtaffelstationauswahl.SelectedItem == null)
            {
                MessageBox.Show("Bitte geben Sie überall einen gültigen Wert ein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cb_fahrtaffelstationauswahl.SelectedItem != null)
            {

                MessageBox.Show("Validation correct");


                foreach (var station2 in myStationsstart.StationList)
                {
                    if (station2.Name == (cb_fahrtaffelstationauswahl.SelectedItem as Station).Name)
                    {

                         distance = station2.Distance.Value;

                        MessageBox.Show(distance.ToString());

                    }
                }


                //MessageBox.Show(idstartstation + " " + startstationname);
                //MessageBox.Show(idendstation + " " + endstationname);
                Transport t = new Transport();
                MessageBox.Show(distance.ToString());




            }
        }
    }
}
