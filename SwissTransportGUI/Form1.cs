using SwissTransport;
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
        Stations myStations = new Stations();
        Transport myTransport = new Transport();
        ITransport myIEtransport = new Transport();
        //Transport tr = new Transport();
        public void typeahead(ComboBox comboboxname)
        {
            ITransport t = new Transport();
            if (!string.IsNullOrEmpty(comboboxname.Text))
            {
                List<Station> stations = t.GetStations(comboboxname.Text).StationList;
                if (stations.Count > 0)
                {
                    comboboxname.DataSource = null;
                    comboboxname.DataSource = stations;
                    comboboxname.DisplayMember = "Name";
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
                //foreach (var station in myStations.StationList)
                //{
                //  MessageBox.Show(station.Id);
                //}
                

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
    }
}
