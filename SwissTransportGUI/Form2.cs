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
        //    double distance;
        //    string idstartstation;
        //    string idendstation;
        //    string endstationname;
        //    string startstationname;
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
            if (!string.IsNullOrEmpty(cb_fahrtaffelstationauswahl.Text))
            {
                dataGridView_Fahrplan.Rows.Clear();
                dataGridView_Fahrplan.Refresh();
                string station = cb_fahrtaffelstationauswahl.Text;



                String övgesellschaft = "";
                String to_destination = "";

                StationBoardRoot stationBoard = myTransport.GetStationBoard(station, "");
                foreach (var entry in stationBoard.Entries)
                {


                    övgesellschaft += entry.Operator + "\n";
                    DateTime departureString = entry.Stop.Departure;
                    DateTime departureDateTime = (departureString);
                    String departureFormatted = departureDateTime.ToString("HH:mm:ss");


                    dataGridView_Fahrplan.ColumnCount = 4;
                    dataGridView_Fahrplan.Columns[0].Name = "ÖV Kategorie";
                    dataGridView_Fahrplan.Columns[1].Name = "ÖV Nummer";
                    dataGridView_Fahrplan.Columns[2].Name = "Abfahrt";
                    dataGridView_Fahrplan.Columns[3].Name = "Zielstation";

                    string[] row = new string[] { entry.Category, entry.Number, departureFormatted, entry.To };
                    dataGridView_Fahrplan.Rows.Add(row);





                }

            
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige Station ein");
            }

        }


    }
}

