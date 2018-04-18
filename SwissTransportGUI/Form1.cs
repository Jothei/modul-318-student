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
    { string test = "\n";
        Stations myStations = new Stations();
        Transport myTransport = new Transport();
        ITransport myIEtransport = new Transport();
        //Transport tr = new Transport();
        public void typeahead(ComboBox comboboxname)
        {
            ITransport t = new Transport();
            if (!string.IsNullOrEmpty(comboboxname.Text))
            {
                myStations.StationList = t.GetStations(comboboxname.Text).StationList;
                if (myStations.StationList.Count > 0)
                {
                    comboboxname.DataSource = null;
                    comboboxname.DataSource = myStations.StationList;
                    comboboxname.DisplayMember = "Name";
                    test = comboboxname.SelectedValue.ToString();
              
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
                foreach(var station in myStations.StationList)
                {

                    test += " " + station.Id+"\n";
                }

                MessageBox.Show(test);
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

        }
    }
}
