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
            this.cb_fahrtaffelstationauswahl = new System.Windows.Forms.ComboBox();
            this.btn_searchstation = new System.Windows.Forms.Button();
            this.dataGridView_Fahrplan = new System.Windows.Forms.DataGridView();
            this.Startstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zielstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_calcVerbindungen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fahrplan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_to_Form1
            // 
            this.btn_to_Form1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_to_Form1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_to_Form1.Location = new System.Drawing.Point(652, 415);
            this.btn_to_Form1.Name = "btn_to_Form1";
            this.btn_to_Form1.Size = new System.Drawing.Size(136, 34);
            this.btn_to_Form1.TabIndex = 0;
            this.btn_to_Form1.Text = "Zur Startseite";
            this.btn_to_Form1.UseVisualStyleBackColor = true;
            this.btn_to_Form1.Click += new System.EventHandler(this.btn_to_Form1_Click_1);
            // 
            // cb_fahrtaffelstationauswahl
            // 
            this.cb_fahrtaffelstationauswahl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_fahrtaffelstationauswahl.FormattingEnabled = true;
            this.cb_fahrtaffelstationauswahl.Location = new System.Drawing.Point(179, 42);
            this.cb_fahrtaffelstationauswahl.Name = "cb_fahrtaffelstationauswahl";
            this.cb_fahrtaffelstationauswahl.Size = new System.Drawing.Size(368, 24);
            this.cb_fahrtaffelstationauswahl.TabIndex = 1;
            // 
            // btn_searchstation
            // 
            this.btn_searchstation.Location = new System.Drawing.Point(580, 42);
            this.btn_searchstation.Name = "btn_searchstation";
            this.btn_searchstation.Size = new System.Drawing.Size(153, 23);
            this.btn_searchstation.TabIndex = 2;
            this.btn_searchstation.Text = "Station suchen";
            this.btn_searchstation.UseVisualStyleBackColor = true;
            this.btn_searchstation.Click += new System.EventHandler(this.btn_searchstation_Click);
            // 
            // dataGridView_Fahrplan
            // 
            this.dataGridView_Fahrplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fahrplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Startstation,
            this.Zielstation,
            this.Zeit,
            this.Gleis});
            this.dataGridView_Fahrplan.Location = new System.Drawing.Point(179, 130);
            this.dataGridView_Fahrplan.Name = "dataGridView_Fahrplan";
            this.dataGridView_Fahrplan.RowTemplate.Height = 24;
            this.dataGridView_Fahrplan.Size = new System.Drawing.Size(466, 258);
            this.dataGridView_Fahrplan.TabIndex = 3;
            // 
            // Startstation
            // 
            this.Startstation.HeaderText = "Startstation";
            this.Startstation.Name = "Startstation";
            // 
            // Zielstation
            // 
            this.Zielstation.HeaderText = "Zielstation";
            this.Zielstation.Name = "Zielstation";
            // 
            // Zeit
            // 
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.Name = "Zeit";
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.Name = "Gleis";
            // 
            // btn_calcVerbindungen
            // 
            this.btn_calcVerbindungen.Location = new System.Drawing.Point(272, 73);
            this.btn_calcVerbindungen.Name = "btn_calcVerbindungen";
            this.btn_calcVerbindungen.Size = new System.Drawing.Size(146, 30);
            this.btn_calcVerbindungen.TabIndex = 4;
            this.btn_calcVerbindungen.Text = "Verbindungen anzeigen";
            this.btn_calcVerbindungen.UseVisualStyleBackColor = true;
            this.btn_calcVerbindungen.Click += new System.EventHandler(this.btn_calcVerbindungen_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btn_to_Form1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calcVerbindungen);
            this.Controls.Add(this.dataGridView_Fahrplan);
            this.Controls.Add(this.btn_searchstation);
            this.Controls.Add(this.cb_fahrtaffelstationauswahl);
            this.Controls.Add(this.btn_to_Form1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fahrplan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fahrplan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_to_Form1;
        private System.Windows.Forms.ComboBox cb_fahrtaffelstationauswahl;
        private System.Windows.Forms.Button btn_searchstation;
        private System.Windows.Forms.DataGridView dataGridView_Fahrplan;
        private System.Windows.Forms.Button btn_calcVerbindungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Startstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zielstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
    }
}