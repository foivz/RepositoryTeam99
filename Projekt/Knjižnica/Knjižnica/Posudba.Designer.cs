namespace Knjižnica
{
    partial class FrmPosudba
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
            this.cmbNaziv = new System.Windows.Forms.ComboBox();
            this.cmbSifraKnjige = new System.Windows.Forms.ComboBox();
            this.cmbPrezime = new System.Windows.Forms.ComboBox();
            this.cmbIme = new System.Windows.Forms.ComboBox();
            this.cmbSifraKorisnika = new System.Windows.Forms.ComboBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblSifraKnjige = new System.Windows.Forms.Label();
            this.lblDatumVracanja = new System.Windows.Forms.Label();
            this.lblDatumPosudbe = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblSifraKorisnika = new System.Windows.Forms.Label();
            this.txtDatumVracanja = new System.Windows.Forms.TextBox();
            this.txtDatumPosudbe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Location = new System.Drawing.Point(238, 160);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(153, 21);
            this.cmbNaziv.TabIndex = 123;
            // 
            // cmbSifraKnjige
            // 
            this.cmbSifraKnjige.FormattingEnabled = true;
            this.cmbSifraKnjige.Location = new System.Drawing.Point(238, 134);
            this.cmbSifraKnjige.Name = "cmbSifraKnjige";
            this.cmbSifraKnjige.Size = new System.Drawing.Size(153, 21);
            this.cmbSifraKnjige.TabIndex = 122;
            // 
            // cmbPrezime
            // 
            this.cmbPrezime.FormattingEnabled = true;
            this.cmbPrezime.Location = new System.Drawing.Point(238, 108);
            this.cmbPrezime.Name = "cmbPrezime";
            this.cmbPrezime.Size = new System.Drawing.Size(153, 21);
            this.cmbPrezime.TabIndex = 121;
            // 
            // cmbIme
            // 
            this.cmbIme.FormattingEnabled = true;
            this.cmbIme.Location = new System.Drawing.Point(238, 82);
            this.cmbIme.Name = "cmbIme";
            this.cmbIme.Size = new System.Drawing.Size(153, 21);
            this.cmbIme.TabIndex = 120;
            // 
            // cmbSifraKorisnika
            // 
            this.cmbSifraKorisnika.FormattingEnabled = true;
            this.cmbSifraKorisnika.Location = new System.Drawing.Point(238, 56);
            this.cmbSifraKorisnika.Name = "cmbSifraKorisnika";
            this.cmbSifraKorisnika.Size = new System.Drawing.Size(153, 21);
            this.cmbSifraKorisnika.TabIndex = 119;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(104, 279);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(88, 30);
            this.btnIzlaz.TabIndex = 118;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.Transparent;
            this.btnPosalji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPosalji.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPosalji.FlatAppearance.BorderSize = 0;
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosalji.Location = new System.Drawing.Point(246, 279);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(88, 30);
            this.btnPosalji.TabIndex = 117;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(46, 159);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(45, 18);
            this.lblNaziv.TabIndex = 116;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblSifraKnjige
            // 
            this.lblSifraKnjige.AutoSize = true;
            this.lblSifraKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifraKnjige.Location = new System.Drawing.Point(46, 133);
            this.lblSifraKnjige.Name = "lblSifraKnjige";
            this.lblSifraKnjige.Size = new System.Drawing.Size(80, 18);
            this.lblSifraKnjige.TabIndex = 115;
            this.lblSifraKnjige.Text = "Šifra knjige";
            // 
            // lblDatumVracanja
            // 
            this.lblDatumVracanja.AutoSize = true;
            this.lblDatumVracanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumVracanja.Location = new System.Drawing.Point(46, 211);
            this.lblDatumVracanja.Name = "lblDatumVracanja";
            this.lblDatumVracanja.Size = new System.Drawing.Size(111, 18);
            this.lblDatumVracanja.TabIndex = 114;
            this.lblDatumVracanja.Text = "Datum vracanja";
            // 
            // lblDatumPosudbe
            // 
            this.lblDatumPosudbe.AutoSize = true;
            this.lblDatumPosudbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumPosudbe.Location = new System.Drawing.Point(46, 185);
            this.lblDatumPosudbe.Name = "lblDatumPosudbe";
            this.lblDatumPosudbe.Size = new System.Drawing.Size(113, 18);
            this.lblDatumPosudbe.TabIndex = 113;
            this.lblDatumPosudbe.Text = "Datum posudbe";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(46, 107);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 18);
            this.lblPrezime.TabIndex = 112;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(46, 81);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(36, 18);
            this.lblIme.TabIndex = 111;
            this.lblIme.Text = "Ime ";
            // 
            // lblSifraKorisnika
            // 
            this.lblSifraKorisnika.AutoSize = true;
            this.lblSifraKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifraKorisnika.Location = new System.Drawing.Point(46, 55);
            this.lblSifraKorisnika.Name = "lblSifraKorisnika";
            this.lblSifraKorisnika.Size = new System.Drawing.Size(102, 18);
            this.lblSifraKorisnika.TabIndex = 110;
            this.lblSifraKorisnika.Text = "Šifra korisnika";
            // 
            // txtDatumVracanja
            // 
            this.txtDatumVracanja.Location = new System.Drawing.Point(238, 212);
            this.txtDatumVracanja.Name = "txtDatumVracanja";
            this.txtDatumVracanja.Size = new System.Drawing.Size(153, 20);
            this.txtDatumVracanja.TabIndex = 109;
            // 
            // txtDatumPosudbe
            // 
            this.txtDatumPosudbe.Location = new System.Drawing.Point(238, 186);
            this.txtDatumPosudbe.Name = "txtDatumPosudbe";
            this.txtDatumPosudbe.Size = new System.Drawing.Size(153, 20);
            this.txtDatumPosudbe.TabIndex = 108;
            // 
            // FrmPosudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(436, 365);
            this.Controls.Add(this.cmbNaziv);
            this.Controls.Add(this.cmbSifraKnjige);
            this.Controls.Add(this.cmbPrezime);
            this.Controls.Add(this.cmbIme);
            this.Controls.Add(this.cmbSifraKorisnika);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblSifraKnjige);
            this.Controls.Add(this.lblDatumVracanja);
            this.Controls.Add(this.lblDatumPosudbe);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblSifraKorisnika);
            this.Controls.Add(this.txtDatumVracanja);
            this.Controls.Add(this.txtDatumPosudbe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPosudba";
            this.Text = "Posudba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbNaziv;
        internal System.Windows.Forms.ComboBox cmbSifraKnjige;
        internal System.Windows.Forms.ComboBox cmbPrezime;
        internal System.Windows.Forms.ComboBox cmbIme;
        internal System.Windows.Forms.ComboBox cmbSifraKorisnika;
        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Button btnPosalji;
        internal System.Windows.Forms.Label lblNaziv;
        internal System.Windows.Forms.Label lblSifraKnjige;
        internal System.Windows.Forms.Label lblDatumVracanja;
        internal System.Windows.Forms.Label lblDatumPosudbe;
        internal System.Windows.Forms.Label lblPrezime;
        internal System.Windows.Forms.Label lblIme;
        internal System.Windows.Forms.Label lblSifraKorisnika;
        internal System.Windows.Forms.TextBox txtDatumVracanja;
        internal System.Windows.Forms.TextBox txtDatumPosudbe;
    }
}