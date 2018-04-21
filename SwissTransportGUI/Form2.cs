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
            string station = cb_fahrtaffelstationauswahl.Text;

            //if (cb_fahrtaffelstationauswahl.SelectedItem == null)
            //{
            //    MessageBox.Show("Bitte geben Sie überall einen gültigen Wert ein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if(cb_fahrtaffelstationauswahl.SelectedItem != null)
            //{

            //    MessageBox.Show("Validation correct");


            //    foreach (var station2 in myStationsstart.StationList)
            //    {
            //        if (station2.Name == (cb_fahrtaffelstationauswahl.SelectedItem as Station).Name)
            //        {

            //             distance = station2.Distance.Value;

            //            MessageBox.Show(distance.ToString());

            //        }
            //    }


            //    //MessageBox.Show(idstartstation + " " + startstationname);
            //    //MessageBox.Show(idendstation + " " + endstationname);
            //    Transport t = new Transport();
            //   // MessageBox.Show(distance.ToString());
            //dataGridView_Fahrplan.ColumnCount = 4;
            //dataGridView_Fahrplan.Columns[0].Name = "Product ID";
            //dataGridView_Fahrplan.Columns[1].Name = "Product Name";
            //dataGridView_Fahrplan.Columns[2].Name = "Product Price";
            //dataGridView_Fahrplan.Columns[3].Name = "Gleis";

            //string[] row = new string[] { "Meggen","Luzern", "Product 1", "1000" };
            //dataGridView_Fahrplan.Rows.Add(row);
            //row = new string[] { "Brunnen", "Product 2", "2000" };
            //dataGridView_Fahrplan.Rows.Add(row);
            //row = new string[] { "Arth", "Product 3", "3000" };
            //dataGridView_Fahrplan.Rows.Add(row);
            //for (int increment= 0; increment < 6; increment++){
            //    row = new string[] { "Meggen", "Product "+increment.ToString(), "4000" };
            //    dataGridView_Fahrplan.Rows.Add(row);
            //}

            //MessageBox.Show(cache.ToString());
            //dataGridView_Fahrplan.Rows[0].ReadOnly = true;
            //dataGridView_Fahrplan.Rows[1].ReadOnly = true;
            //dataGridView_Fahrplan.Rows[2].ReadOnly = true;
            //dataGridView_Fahrplan.Rows[3].ReadOnly = true;
            //dataGridView_Fahrplan.Rows[4].ReadOnly = true;

            String stationBoardString = "";

            StationBoardRoot stationBoard = myTransport.GetStationBoard(station, "");
            foreach (var entry in stationBoard.Entries)
            {
                stationBoardString += entry.Name + "\n";
            }

            MessageBox.Show(stationBoardString);
        }

       
    }
    }

