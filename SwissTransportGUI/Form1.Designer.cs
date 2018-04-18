﻿namespace SwissTransportGUI
{
    partial class Mainform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Startposition = new System.Windows.Forms.Label();
            this.lbl_Endstation = new System.Windows.Forms.Label();
            this.btn_VerbindungSuchen = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.cb_start = new System.Windows.Forms.ComboBox();
            this.cb_end = new System.Windows.Forms.ComboBox();
            this.btn_searchststation = new System.Windows.Forms.Button();
            this.btn_searchenstation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Startposition
            // 
            this.lbl_Startposition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Startposition.AutoSize = true;
            this.lbl_Startposition.Location = new System.Drawing.Point(244, 30);
            this.lbl_Startposition.Name = "lbl_Startposition";
            this.lbl_Startposition.Size = new System.Drawing.Size(235, 17);
            this.lbl_Startposition.TabIndex = 2;
            this.lbl_Startposition.Text = "Bitte geben Sie Ihre Startstation ein:";
            // 
            // lbl_Endstation
            // 
            this.lbl_Endstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Endstation.AutoSize = true;
            this.lbl_Endstation.Location = new System.Drawing.Point(244, 100);
            this.lbl_Endstation.Name = "lbl_Endstation";
            this.lbl_Endstation.Size = new System.Drawing.Size(230, 17);
            this.lbl_Endstation.TabIndex = 3;
            this.lbl_Endstation.Text = "Bitte geben Sie Ihre Endstation ein:";
            // 
            // btn_VerbindungSuchen
            // 
            this.btn_VerbindungSuchen.Location = new System.Drawing.Point(247, 173);
            this.btn_VerbindungSuchen.Name = "btn_VerbindungSuchen";
            this.btn_VerbindungSuchen.Size = new System.Drawing.Size(227, 40);
            this.btn_VerbindungSuchen.TabIndex = 5;
            this.btn_VerbindungSuchen.Text = "Verbindung suchen";
            this.btn_VerbindungSuchen.UseVisualStyleBackColor = true;
            this.btn_VerbindungSuchen.Click += new System.EventHandler(this.btn_VerbindungSuchen_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(692, 415);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(96, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "Schliessen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cb_start
            // 
            this.cb_start.FormattingEnabled = true;
            this.cb_start.Location = new System.Drawing.Point(247, 60);
            this.cb_start.Name = "cb_start";
            this.cb_start.Size = new System.Drawing.Size(227, 24);
            this.cb_start.TabIndex = 1;
            // 
            // cb_end
            // 
            this.cb_end.FormattingEnabled = true;
            this.cb_end.Location = new System.Drawing.Point(247, 130);
            this.cb_end.Name = "cb_end";
            this.cb_end.Size = new System.Drawing.Size(232, 24);
            this.cb_end.TabIndex = 3;
            this.cb_end.SelectedIndexChanged += new System.EventHandler(this.cb_end_SelectedIndexChanged);
            // 
            // btn_searchststation
            // 
            this.btn_searchststation.Location = new System.Drawing.Point(496, 60);
            this.btn_searchststation.Name = "btn_searchststation";
            this.btn_searchststation.Size = new System.Drawing.Size(156, 24);
            this.btn_searchststation.TabIndex = 2;
            this.btn_searchststation.Text = "Station suchen";
            this.btn_searchststation.UseVisualStyleBackColor = true;
            this.btn_searchststation.Click += new System.EventHandler(this.btn_searchststation_Click);
            // 
            // btn_searchenstation
            // 
            this.btn_searchenstation.Location = new System.Drawing.Point(496, 129);
            this.btn_searchenstation.Name = "btn_searchenstation";
            this.btn_searchenstation.Size = new System.Drawing.Size(156, 24);
            this.btn_searchenstation.TabIndex = 4;
            this.btn_searchenstation.Text = "Station suchen";
            this.btn_searchenstation.UseVisualStyleBackColor = true;
            this.btn_searchenstation.Click += new System.EventHandler(this.btn_searchenstation_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_searchenstation);
            this.Controls.Add(this.btn_searchststation);
            this.Controls.Add(this.cb_end);
            this.Controls.Add(this.cb_start);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_VerbindungSuchen);
            this.Controls.Add(this.lbl_Endstation);
            this.Controls.Add(this.lbl_Startposition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transport App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Startposition;
        private System.Windows.Forms.Label lbl_Endstation;
        private System.Windows.Forms.Button btn_VerbindungSuchen;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cb_start;
        private System.Windows.Forms.ComboBox cb_end;
        private System.Windows.Forms.Button btn_searchststation;
        private System.Windows.Forms.Button btn_searchenstation;
    }
}

