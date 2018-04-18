﻿using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SwissTransportGUI
{
    public partial class Mainform : Form
    {
        string idstartstation;
        string idendstation;
        string endstationname;
        string startstationname;
        string test = "\n";
       
        Stations myStations = new Stations();
        Stations myStationsstart = new Stations();
        Transport myTransport = new Transport();
        ITransport myIEtransport = new Transport();
        Connection myConnection = new Connection();
        //Transport tr = new Transport();


        //Die folgende Methode aktiviert typeahead
        public void typeahead(ComboBox comboboxname)
        {
            Transport t = new Transport();


            if (!string.IsNullOrEmpty(comboboxname.Text))
            {
                if(comboboxname == cb_end)
                {
                    myStations.StationList = t.GetStations(comboboxname.Text).StationList;
                    if (myStations.StationList.Count > 0)
                    {
                        comboboxname.DataSource = null;
                        comboboxname.DataSource = myStations.StationList;
                        comboboxname.DisplayMember = "Name";

                    }
                }
               if(comboboxname == cb_start)
                {
                    myStationsstart.StationList = t.GetStations(comboboxname.Text).StationList;
                    if (myStationsstart.StationList.Count > 0)
                    {
                        comboboxname.DataSource = null;
                        comboboxname.DataSource = myStationsstart.StationList;
                        comboboxname.DisplayMember = "Name";

                    }
                }



            }
        }

        public Mainform()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_VerbindungSuchen_Click(object sender, EventArgs e)
        {
            if (cb_start.SelectedItem == null || cb_end.SelectedItem == null)
            {
                MessageBox.Show("Bitte geben Sie überall einen gültigen Wert ein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
               
                MessageBox.Show("Validation correct");
                int i = 1;
                int testi = 0;
               
                foreach (var station in myStations.StationList)
                {
                    if (station.Name == (cb_end.SelectedItem as Station).Name)
                    {
                        idendstation = station.Id;
                        endstationname = station.Name;
                    }
                   
                }
                foreach (var station2 in myStationsstart.StationList)
                {
                    if (station2.Name == (cb_start.SelectedItem as Station).Name)
                    {
                        idstartstation = station2.Id;
                        startstationname = station2.Name;
                    }
                }

                //int ia = 1;
                //foreach (var station in myStationsstart.StationList)
                //{
                //    if (ia == 1)
                //    {
                //        test += " " + station.Id + "\n" + station.Name;
                //        idstartstation = Int32.Parse(station.Id);
                //        startstationname = station.Name;
                //        testi = cb_start.SelectedIndex;
                //    }
                //    ia++;
                //}
                MessageBox.Show(idstartstation + " " + startstationname);
                MessageBox.Show(idendstation + " " + endstationname);

             
                

            }

        }

        private void btn_searchststation_Click(object sender, EventArgs e)
        {
            typeahead(cb_start);
        }

        private void btn_searchenstation_Click(object sender, EventArgs e)
        {
            typeahead(cb_end);

        }

        private void cb_end_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (cb_start.Text.Length > 1) {
            //    MessageBox.Show(cb_end.Text);
            //}
        }

        private void cb_start_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cb_start.Text.Length > 2)
            //{
            //    MessageBox.Show(cb_start.Text);
            //}

        }

        
    }
}
