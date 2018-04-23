namespace SwissTransportGUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_to_Form1 = new System.Windows.Forms.Button();
            this.cb_fahrtafelstationauswahl = new System.Windows.Forms.ComboBox();
            this.btn_searchstation = new System.Windows.Forms.Button();
            this.dataGridView_Fahrplan = new System.Windows.Forms.DataGridView();
            this.öv_kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Öv_Linie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zielort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_calcVerbindungen = new System.Windows.Forms.Button();
            this.btn_to_google_maps = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Emailadresse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fahrplan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_to_Form1
            // 
            this.btn_to_Form1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_to_Form1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_to_Form1.Location = new System.Drawing.Point(770, 651);
            this.btn_to_Form1.Name = "btn_to_Form1";
            this.btn_to_Form1.Size = new System.Drawing.Size(136, 34);
            this.btn_to_Form1.TabIndex = 4;
            this.btn_to_Form1.Text = "Zur Startseite";
            this.btn_to_Form1.UseVisualStyleBackColor = true;
            this.btn_to_Form1.Click += new System.EventHandler(this.btn_to_Form1_Click_1);
            // 
            // cb_fahrtafelstationauswahl
            // 
            this.cb_fahrtafelstationauswahl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_fahrtafelstationauswahl.FormattingEnabled = true;
            this.cb_fahrtafelstationauswahl.Location = new System.Drawing.Point(179, 42);
            this.cb_fahrtafelstationauswahl.Name = "cb_fahrtafelstationauswahl";
            this.cb_fahrtafelstationauswahl.Size = new System.Drawing.Size(486, 24);
            this.cb_fahrtafelstationauswahl.TabIndex = 1;
            // 
            // btn_searchstation
            // 
            this.btn_searchstation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_searchstation.Location = new System.Drawing.Point(683, 43);
            this.btn_searchstation.Name = "btn_searchstation";
            this.btn_searchstation.Size = new System.Drawing.Size(153, 23);
            this.btn_searchstation.TabIndex = 2;
            this.btn_searchstation.Text = "Station suchen";
            this.btn_searchstation.UseVisualStyleBackColor = true;
            this.btn_searchstation.Click += new System.EventHandler(this.btn_searchstation_Click);
            // 
            // dataGridView_Fahrplan
            // 
            this.dataGridView_Fahrplan.AllowUserToAddRows = false;
            this.dataGridView_Fahrplan.AllowUserToDeleteRows = false;
            this.dataGridView_Fahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Fahrplan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Fahrplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fahrplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.öv_kategorie,
            this.Öv_Linie,
            this.Abfahrtszeit,
            this.Zielort});
            this.dataGridView_Fahrplan.Location = new System.Drawing.Point(75, 109);
            this.dataGridView_Fahrplan.Name = "dataGridView_Fahrplan";
            this.dataGridView_Fahrplan.ReadOnly = true;
            this.dataGridView_Fahrplan.RowTemplate.Height = 24;
            this.dataGridView_Fahrplan.Size = new System.Drawing.Size(776, 458);
            this.dataGridView_Fahrplan.TabIndex = 3;
            this.dataGridView_Fahrplan.TabStop = false;
            // 
            // öv_kategorie
            // 
            this.öv_kategorie.HeaderText = "Öv Kategorie";
            this.öv_kategorie.Name = "öv_kategorie";
            this.öv_kategorie.ReadOnly = true;
            this.öv_kategorie.Width = 120;
            // 
            // Öv_Linie
            // 
            this.Öv_Linie.HeaderText = "Öv Linie";
            this.Öv_Linie.Name = "Öv_Linie";
            this.Öv_Linie.ReadOnly = true;
            this.Öv_Linie.Width = 89;
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            this.Abfahrtszeit.ReadOnly = true;
            this.Abfahrtszeit.Width = 112;
            // 
            // Zielort
            // 
            this.Zielort.HeaderText = "Zielort";
            this.Zielort.Name = "Zielort";
            this.Zielort.ReadOnly = true;
            this.Zielort.Width = 77;
            // 
            // btn_calcVerbindungen
            // 
            this.btn_calcVerbindungen.Location = new System.Drawing.Point(314, 72);
            this.btn_calcVerbindungen.Name = "btn_calcVerbindungen";
            this.btn_calcVerbindungen.Size = new System.Drawing.Size(146, 30);
            this.btn_calcVerbindungen.TabIndex = 3;
            this.btn_calcVerbindungen.Text = "Verbindungen anzeigen";
            this.btn_calcVerbindungen.UseVisualStyleBackColor = true;
            this.btn_calcVerbindungen.Click += new System.EventHandler(this.btn_calcVerbindungen_Click);
            // 
            // btn_to_google_maps
            // 
            this.btn_to_google_maps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_to_google_maps.Location = new System.Drawing.Point(12, 638);
            this.btn_to_google_maps.Name = "btn_to_google_maps";
            this.btn_to_google_maps.Size = new System.Drawing.Size(539, 57);
            this.btn_to_google_maps.TabIndex = 5;
            this.btn_to_google_maps.Text = "Station auf Google Maps anzeigen";
            this.btn_to_google_maps.UseVisualStyleBackColor = true;
            this.btn_to_google_maps.Click += new System.EventHandler(this.btn_to_google_maps_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bitte geben sie eine gültige Station ein";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(557, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Email von dem Fahrplan senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Emailadresse
            // 
            this.txt_Emailadresse.Location = new System.Drawing.Point(557, 610);
            this.txt_Emailadresse.Name = "txt_Emailadresse";
            this.txt_Emailadresse.Size = new System.Drawing.Size(176, 22);
            this.txt_Emailadresse.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btn_to_Form1;
            this.ClientSize = new System.Drawing.Size(918, 697);
            this.Controls.Add(this.txt_Emailadresse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_to_google_maps);
            this.Controls.Add(this.btn_calcVerbindungen);
            this.Controls.Add(this.dataGridView_Fahrplan);
            this.Controls.Add(this.btn_searchstation);
            this.Controls.Add(this.cb_fahrtafelstationauswahl);
            this.Controls.Add(this.btn_to_Form1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fahrplan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fahrplan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_to_Form1;
        private System.Windows.Forms.ComboBox cb_fahrtafelstationauswahl;
        private System.Windows.Forms.Button btn_searchstation;
        private System.Windows.Forms.DataGridView dataGridView_Fahrplan;
        private System.Windows.Forms.Button btn_calcVerbindungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn öv_kategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Öv_Linie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zielort;
        private System.Windows.Forms.Button btn_to_google_maps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Emailadresse;
    }
}