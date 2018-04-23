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
        string idstartstation;
        string idendstation;
        string endstationname;
        string startstationname;


        Stations myStations = new Stations();
        Stations myStationsstart = new Stations();
        Transport myTransport = new Transport();
        ITransport myIEtransport = new Transport();
        Connection myConnection = new Connection();
        ConnectionPoint myConnectionPoint = new ConnectionPoint();
        //Transport tr = new Transport();

        private string FormatDateTime(String DateTime)
        {
            string newformattedString = "";
            for(int i = 0; i< DateTime.Length; i++)
            {
                switch (DateTime[i])
                {
                    case ':':
                    case '.':
                        newformattedString += '-';
                        break;
                    default:
                        newformattedString += DateTime[i];
                        break;


                }
            }
            return newformattedString;
        }
        //Die folgende Methode aktiviert typeahead
        public void typeahead(ComboBox comboboxname)
        {
            Transport t = new Transport();


            if (!string.IsNullOrEmpty(comboboxname.Text))
            {
                if (comboboxname == cb_end)
                {
                    myStations.StationList = t.GetStations(comboboxname.Text).StationList;
                    if (myStations.StationList.Count > 0)
                    {
                        comboboxname.DataSource = null;
                        comboboxname.DataSource = myStations.StationList;
                        comboboxname.DisplayMember = "Name";

                    }
                }
                else if (comboboxname == cb_end)
                {
                    myStations.StationList = t.GetStations(comboboxname.Text).StationList;
                    if (myStations.StationList.Count > 0)
                    {
                        comboboxname.DataSource = null;
                        comboboxname.DataSource = myStations.StationList;
                        comboboxname.DisplayMember = "Name";

                    }
                }

                else if (comboboxname == cb_start)
                {
                    myStationsstart.StationList = t.GetStations(comboboxname.Text).StationList;
                    if (myStationsstart.StationList.Count > 0)
                    {
                        comboboxname.DataSource = null;
                        comboboxname.DataSource = myStationsstart.StationList;
                        comboboxname.DisplayMember = "Name";

                    }
                }
                else
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

            dgV_Verbindungen.Rows.Clear();
            dgV_Verbindungen.Refresh();
            if (cb_start.SelectedItem == null || cb_end.SelectedItem == null)
            {
                MessageBox.Show("Bitte geben Sie überall einen gültigen Wert ein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {




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




                Connections connections = null;

                if (dtp_datum_verbindung.Checked == true && dtp_time_verbindung.Checked == true)


                {
                    DateTime dateTime = dtp_datum_verbindung.Value;
                    String dateTimestring = dateTime.ToShortDateString();
                    string datumformatted = dateTime.ToString("yyyy-MM-dd");


                   DateTime timedatetime = dtp_time_verbindung.Value;
                    string timeformatted = timedatetime.ToString("HH:mm");

                    MessageBox.Show(datumformatted + " "+timeformatted);
                   
                    connections = myTransport.GetConnectionsWidthDateTime(startstationname, endstationname, datumformatted, timeformatted );

                }
                else
                {
                    connections = myTransport.GetConnections(startstationname, endstationname);
                }

                dgV_Verbindungen.ColumnCount = 5;
                dgV_Verbindungen.Columns[0].Name = "ÖV Kategorie";
                dgV_Verbindungen.Columns[1].Name = "ÖV Nummer";
                dgV_Verbindungen.Columns[2].Name = "Fahrzeit";
                dgV_Verbindungen.Columns[3].Name = "Abfahrtszeit";
                dgV_Verbindungen.Columns[4].Name = "Ankunftszeit";




                foreach (Connection connection in connections.ConnectionList)
                {
                    String departureString = connection.From.Departure;
                    DateTime departureDateTime = DateTime.Parse(departureString);
                    String departureFormatted = departureDateTime.ToString("HH:mm:ss dd.MM.yyyy");
                   
                    String arrivalString = connection.To.Arrival;
                    DateTime arrivalDateTime = DateTime.Parse(arrivalString);
                    String arrivalFormatted = arrivalDateTime.ToString("HH:mm:ss dd.MM.yyyy");






                    string[] row = new string[] { connection.From.Station.Name, connection.To.Station.Name, connection.Duration.ToString(), departureFormatted, arrivalFormatted };
                    dgV_Verbindungen.Rows.Add(row);




                    //string[] row = new string[] { entry.Category, entry.Number, departureFormatted, entry.To };
                    //dgV_Verbindungen.Rows.Add(row);


                }

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

        private void cb_start_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_fahrplan_Click(object sender, EventArgs e)
        {

            var form2 = new Form2();

            form2.Show();
        }

        private void cb_start_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
