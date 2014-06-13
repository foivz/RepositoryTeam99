namespace Knjižnica
{
    partial class Izrada_računa
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
            this.cmbSifraClanarine = new System.Windows.Forms.ComboBox();
            this.cmbPrezime = new System.Windows.Forms.ComboBox();
            this.cmbIme = new System.Windows.Forms.ComboBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblSifraClanarine = new System.Windows.Forms.Label();
            this.lblRacunIzdao = new System.Windows.Forms.Label();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            this.lblVrijemeIzdavanja = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblSifraRacuna = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.txtVrijemeIzdavanja = new System.Windows.Forms.TextBox();
            this.txtSifraRacuna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbSifraClanarine
            // 
            this.cmbSifraClanarine.FormattingEnabled = true;
            this.cmbSifraClanarine.Location = new System.Drawing.Point(244, 84);
            this.cmbSifraClanarine.Name = "cmbSifraClanarine";
            this.cmbSifraClanarine.Size = new System.Drawing.Size(153, 21);
            this.cmbSifraClanarine.TabIndex = 124;
            // 
            // cmbPrezime
            // 
            this.cmbPrezime.FormattingEnabled = true;
            this.cmbPrezime.Location = new System.Drawing.Point(244, 236);
            this.cmbPrezime.Name = "cmbPrezime";
            this.cmbPrezime.Size = new System.Drawing.Size(153, 21);
            this.cmbPrezime.TabIndex = 123;
            // 
            // cmbIme
            // 
            this.cmbIme.FormattingEnabled = true;
            this.cmbIme.Location = new System.Drawing.Point(244, 210);
            this.cmbIme.Name = "cmbIme";
            this.cmbIme.Size = new System.Drawing.Size(153, 21);
            this.cmbIme.TabIndex = 122;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(244, 298);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(88, 30);
            this.btnIzlaz.TabIndex = 121;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrint.Location = new System.Drawing.Point(126, 298);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 30);
            this.btnPrint.TabIndex = 120;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // lblSifraClanarine
            // 
            this.lblSifraClanarine.AutoSize = true;
            this.lblSifraClanarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSifraClanarine.Location = new System.Drawing.Point(90, 85);
            this.lblSifraClanarine.Name = "lblSifraClanarine";
            this.lblSifraClanarine.Size = new System.Drawing.Size(99, 17);
            this.lblSifraClanarine.TabIndex = 119;
            this.lblSifraClanarine.Text = "Šifra članarine";
            // 
            // lblRacunIzdao
            // 
            this.lblRacunIzdao.AutoSize = true;
            this.lblRacunIzdao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblRacunIzdao.Location = new System.Drawing.Point(39, 178);
            this.lblRacunIzdao.Name = "lblRacunIzdao";
            this.lblRacunIzdao.Size = new System.Drawing.Size(103, 17);
            this.lblRacunIzdao.TabIndex = 118;
            this.lblRacunIzdao.Text = "Račun izdao:";
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUkupnaCijena.Location = new System.Drawing.Point(90, 137);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(98, 17);
            this.lblUkupnaCijena.TabIndex = 117;
            this.lblUkupnaCijena.Text = "Ukupna cijena";
            // 
            // lblVrijemeIzdavanja
            // 
            this.lblVrijemeIzdavanja.AutoSize = true;
            this.lblVrijemeIzdavanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVrijemeIzdavanja.Location = new System.Drawing.Point(90, 111);
            this.lblVrijemeIzdavanja.Name = "lblVrijemeIzdavanja";
            this.lblVrijemeIzdavanja.Size = new System.Drawing.Size(119, 17);
            this.lblVrijemeIzdavanja.TabIndex = 116;
            this.lblVrijemeIzdavanja.Text = "Vrijeme izdavanja";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrezime.Location = new System.Drawing.Point(90, 237);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 17);
            this.lblPrezime.TabIndex = 115;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIme.Location = new System.Drawing.Point(90, 211);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 114;
            this.lblIme.Text = "Ime ";
            // 
            // lblSifraRacuna
            // 
            this.lblSifraRacuna.AutoSize = true;
            this.lblSifraRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSifraRacuna.Location = new System.Drawing.Point(39, 37);
            this.lblSifraRacuna.Name = "lblSifraRacuna";
            this.lblSifraRacuna.Size = new System.Drawing.Size(97, 17);
            this.lblSifraRacuna.TabIndex = 113;
            this.lblSifraRacuna.Text = "Šifra računa";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(244, 136);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(153, 20);
            this.txtUkupnaCijena.TabIndex = 112;
            // 
            // txtVrijemeIzdavanja
            // 
            this.txtVrijemeIzdavanja.Location = new System.Drawing.Point(244, 110);
            this.txtVrijemeIzdavanja.Name = "txtVrijemeIzdavanja";
            this.txtVrijemeIzdavanja.Size = new System.Drawing.Size(153, 20);
            this.txtVrijemeIzdavanja.TabIndex = 111;
            // 
            // txtSifraRacuna
            // 
            this.txtSifraRacuna.Location = new System.Drawing.Point(142, 36);
            this.txtSifraRacuna.Name = "txtSifraRacuna";
            this.txtSifraRacuna.Size = new System.Drawing.Size(68, 20);
            this.txtSifraRacuna.TabIndex = 110;
            // 
            // Izrada_računa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 365);
            this.Controls.Add(this.cmbSifraClanarine);
            this.Controls.Add(this.cmbPrezime);
            this.Controls.Add(this.cmbIme);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblSifraClanarine);
            this.Controls.Add(this.lblRacunIzdao);
            this.Controls.Add(this.lblUkupnaCijena);
            this.Controls.Add(this.lblVrijemeIzdavanja);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblSifraRacuna);
            this.Controls.Add(this.txtUkupnaCijena);
            this.Controls.Add(this.txtVrijemeIzdavanja);
            this.Controls.Add(this.txtSifraRacuna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Izrada_računa";
            this.Text = "Izrada računa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbSifraClanarine;
        internal System.Windows.Forms.ComboBox cmbPrezime;
        internal System.Windows.Forms.ComboBox cmbIme;
        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Label lblSifraClanarine;
        internal System.Windows.Forms.Label lblRacunIzdao;
        internal System.Windows.Forms.Label lblUkupnaCijena;
        internal System.Windows.Forms.Label lblVrijemeIzdavanja;
        internal System.Windows.Forms.Label lblPrezime;
        internal System.Windows.Forms.Label lblIme;
        internal System.Windows.Forms.Label lblSifraRacuna;
        internal System.Windows.Forms.TextBox txtUkupnaCijena;
        internal System.Windows.Forms.TextBox txtVrijemeIzdavanja;
        internal System.Windows.Forms.TextBox txtSifraRacuna;

    }
}