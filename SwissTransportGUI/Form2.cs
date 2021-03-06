﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using SwissTransport;
using System.Net.Mail;

namespace SwissTransportGUI
{
    public partial class Form2 : Form
    {
        string station;
        public bool checkifverbindungwaspressed = false;

        public StationBoardRoot currentStation;
        Mainform myForm = new Mainform();
        Stations myStations = new Stations();
        Stations myStationsstart = new Stations();
        Coordinate myCoordinate = new Coordinate();
        Transport myTransport = new Transport();
        ITransport myIEtransport = new Transport();
        Connection myConnection = new Connection();
        public Form2()
        {
            InitializeComponent();
        }

        private string coordinateformatter(string convertstring)
        {
            String myString = convertstring;
            myString = myString.Replace(",", ".");
            return myString;
        }
        private void sending_email(string email, string content)
        {
            if (checkifverbindungwaspressed == true)
            {
                try
                {


                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("m318jo@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "Ihr Fahrplan";
                    mail.Body = content;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("m318jo@gmail.com", "abcmeg11");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Das Email wurde erfolgreich an " + email.ToString() + " gesendet!");
                    checkifverbindungwaspressed = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    checkifverbindungwaspressed = false;
                }
            }

            else if (checkifverbindungwaspressed == false)
            {
                MessageBox.Show("Email wurde nicht abgesendet, da keine gültige Station eingegeben wurde oder nicht auf Verbinden gedrückt wurde");

            }

        }
        //Stellt eine Verbindung zum Browser her
        public void gotoSite(string url)
        {
            System.Diagnostics.Process.Start(url);
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

            myForm.typeahead(cb_fahrtafelstationauswahl);
        }

        private void btn_to_Form1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Mainform myMainform = new Mainform();
            myMainform.Focus();

        }

        private void btn_calcVerbindungen_Click(object sender, EventArgs e)
        {
            try
            {
                checkifverbindungwaspressed = true;
                if (!string.IsNullOrEmpty(cb_fahrtafelstationauswahl.Text))
                {



                    dataGridView_Fahrplan.Rows.Clear();
                    dataGridView_Fahrplan.Refresh();
                    station = cb_fahrtafelstationauswahl.Text;



                    String övgesellschaft = "";


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


                        _bodycontentformail += "ÖV Kategorie: " + entry.Category + " ÖV Nummer: " + entry.Number + " Abfahrt: " + departureFormatted + " Zielstation: " + entry.To + "\n\n";


                    }


                }

                else
                {
                    MessageBox.Show("Bitte geben Sie eine gültige ÖV Station ein");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte geben Sie überall einen gültigen Wert ein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }




        private void btn_to_email_Click(object sender, EventArgs e)
        {
            sending_email(txt_Emailadresse.Text, _bodycontentformail);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cb_fahrtafelstationauswahl.Text) && !string.IsNullOrEmpty(txt_Emailadresse.Text))
            {
                sending_email(txt_Emailadresse.Text, _bodycontentformail);
            }


            else
            {
                MessageBox.Show("Error\nBitte geben Sie eine gültige Station ein", "Fehler");
            }


        }
        public string _bodycontentformail;

        public string dataformail
        {
            get { return _bodycontentformail; }
            set { _bodycontentformail = value; }
        }

        private void btn_to_google_maps_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cb_fahrtafelstationauswahl.Text))
                {

                    StationBoardRoot stationBoard = myTransport.GetStationBoard(station, "");

                    string xcord = stationBoard.Station.Coordinate.XCoordinate.ToString();
                    string ycord = stationBoard.Station.Coordinate.YCoordinate.ToString();

                    if (xcord != null || ycord != null)
                    {
                        xcord = coordinateformatter(xcord);
                        ycord = coordinateformatter(ycord);
                        gotoSite("https://www.google.com/maps/place/" + xcord.ToString() + "," + ycord.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("Station nicht gefunden.\nBitte überprüfen Sie ob die richtige Station eingegeben wurde", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }

}

