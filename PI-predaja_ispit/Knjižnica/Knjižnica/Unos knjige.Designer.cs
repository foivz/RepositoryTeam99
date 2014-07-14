namespace Knjižnica
{
    partial class FrmUnosKnjige
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
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            this.cmbNazivZanra = new System.Windows.Forms.ComboBox();
            this.cmbNazivIzdavaca = new System.Windows.Forms.ComboBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.lblKat = new System.Windows.Forms.Label();
            this.lblNazivZanra = new System.Windows.Forms.Label();
            this.lblNazivIzdavaca = new System.Windows.Forms.Label();
            this.lblGodinaIzdavanja = new System.Windows.Forms.Label();
            this.lblNazivKnjige = new System.Windows.Forms.Label();
            this.txtGodinaIzdavanja = new System.Windows.Forms.TextBox();
            this.txtNazivKnjige = new System.Windows.Forms.TextBox();
            this.lblImeAutora = new System.Windows.Forms.Label();
            this.cmbImeAutora = new System.Windows.Forms.ComboBox();
            this.lblSifraKnjige = new System.Windows.Forms.Label();
            this.txtSifraKnjige = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.Label();
            this.Kolicina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(181, 259);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(208, 21);
            this.cmbLokacija.TabIndex = 132;
            // 
            // cmbNazivZanra
            // 
            this.cmbNazivZanra.FormattingEnabled = true;
            this.cmbNazivZanra.Location = new System.Drawing.Point(181, 170);
            this.cmbNazivZanra.Name = "cmbNazivZanra";
            this.cmbNazivZanra.Size = new System.Drawing.Size(208, 21);
            this.cmbNazivZanra.TabIndex = 131;
            // 
            // cmbNazivIzdavaca
            // 
            this.cmbNazivIzdavaca.FormattingEnabled = true;
            this.cmbNazivIzdavaca.Location = new System.Drawing.Point(181, 143);
            this.cmbNazivIzdavaca.Name = "cmbNazivIzdavaca";
            this.cmbNazivIzdavaca.Size = new System.Drawing.Size(208, 21);
            this.cmbNazivIzdavaca.TabIndex = 130;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(123, 359);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(88, 30);
            this.btnIzlaz.TabIndex = 127;
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
            this.btnPosalji.Location = new System.Drawing.Point(249, 359);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(88, 30);
            this.btnPosalji.TabIndex = 126;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Sansita One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacija.Location = new System.Drawing.Point(32, 231);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(70, 15);
            this.lblLokacija.TabIndex = 125;
            this.lblLokacija.Text = "LOKACIJA:";
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKat.Location = new System.Drawing.Point(61, 259);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(53, 15);
            this.lblKat.TabIndex = 122;
            this.lblKat.Text = "Lokacija";
            // 
            // lblNazivZanra
            // 
            this.lblNazivZanra.AutoSize = true;
            this.lblNazivZanra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivZanra.Location = new System.Drawing.Point(62, 171);
            this.lblNazivZanra.Name = "lblNazivZanra";
            this.lblNazivZanra.Size = new System.Drawing.Size(71, 15);
            this.lblNazivZanra.TabIndex = 121;
            this.lblNazivZanra.Text = "Naziv žanra";
            // 
            // lblNazivIzdavaca
            // 
            this.lblNazivIzdavaca.AutoSize = true;
            this.lblNazivIzdavaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivIzdavaca.Location = new System.Drawing.Point(61, 143);
            this.lblNazivIzdavaca.Name = "lblNazivIzdavaca";
            this.lblNazivIzdavaca.Size = new System.Drawing.Size(88, 15);
            this.lblNazivIzdavaca.TabIndex = 120;
            this.lblNazivIzdavaca.Text = "Naziv izdavača";
            // 
            // lblGodinaIzdavanja
            // 
            this.lblGodinaIzdavanja.AutoSize = true;
            this.lblGodinaIzdavanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGodinaIzdavanja.Location = new System.Drawing.Point(62, 90);
            this.lblGodinaIzdavanja.Name = "lblGodinaIzdavanja";
            this.lblGodinaIzdavanja.Size = new System.Drawing.Size(102, 15);
            this.lblGodinaIzdavanja.TabIndex = 117;
            this.lblGodinaIzdavanja.Text = "Godina izdavanja";
            // 
            // lblNazivKnjige
            // 
            this.lblNazivKnjige.AutoSize = true;
            this.lblNazivKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivKnjige.Location = new System.Drawing.Point(62, 64);
            this.lblNazivKnjige.Name = "lblNazivKnjige";
            this.lblNazivKnjige.Size = new System.Drawing.Size(73, 15);
            this.lblNazivKnjige.TabIndex = 116;
            this.lblNazivKnjige.Text = "Naziv knjige";
            // 
            // txtGodinaIzdavanja
            // 
            this.txtGodinaIzdavanja.Location = new System.Drawing.Point(181, 90);
            this.txtGodinaIzdavanja.Name = "txtGodinaIzdavanja";
            this.txtGodinaIzdavanja.Size = new System.Drawing.Size(208, 20);
            this.txtGodinaIzdavanja.TabIndex = 114;
            // 
            // txtNazivKnjige
            // 
            this.txtNazivKnjige.Location = new System.Drawing.Point(181, 64);
            this.txtNazivKnjige.Name = "txtNazivKnjige";
            this.txtNazivKnjige.Size = new System.Drawing.Size(208, 20);
            this.txtNazivKnjige.TabIndex = 113;
            // 
            // lblImeAutora
            // 
            this.lblImeAutora.AutoSize = true;
            this.lblImeAutora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeAutora.Location = new System.Drawing.Point(62, 118);
            this.lblImeAutora.Name = "lblImeAutora";
            this.lblImeAutora.Size = new System.Drawing.Size(75, 15);
            this.lblImeAutora.TabIndex = 118;
            this.lblImeAutora.Text = "Naziv autora";
            // 
            // cmbImeAutora
            // 
            this.cmbImeAutora.FormattingEnabled = true;
            this.cmbImeAutora.Location = new System.Drawing.Point(181, 117);
            this.cmbImeAutora.Name = "cmbImeAutora";
            this.cmbImeAutora.Size = new System.Drawing.Size(208, 21);
            this.cmbImeAutora.TabIndex = 128;
            // 
            // lblSifraKnjige
            // 
            this.lblSifraKnjige.AutoSize = true;
            this.lblSifraKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifraKnjige.Location = new System.Drawing.Point(62, 38);
            this.lblSifraKnjige.Name = "lblSifraKnjige";
            this.lblSifraKnjige.Size = new System.Drawing.Size(68, 15);
            this.lblSifraKnjige.TabIndex = 134;
            this.lblSifraKnjige.Text = "Šifra knjige";
            // 
            // txtSifraKnjige
            // 
            this.txtSifraKnjige.Location = new System.Drawing.Point(181, 38);
            this.txtSifraKnjige.Name = "txtSifraKnjige";
            this.txtSifraKnjige.Size = new System.Drawing.Size(208, 20);
            this.txtSifraKnjige.TabIndex = 133;
            // 
            // txtKolicina
            // 
            this.txtKolicina.AutoSize = true;
            this.txtKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKolicina.Location = new System.Drawing.Point(62, 197);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(51, 15);
            this.txtKolicina.TabIndex = 136;
            this.txtKolicina.Text = "Kolicina";
            // 
            // Kolicina
            // 
            this.Kolicina.Location = new System.Drawing.Point(181, 197);
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Size = new System.Drawing.Size(208, 20);
            this.Kolicina.TabIndex = 137;
            this.Kolicina.TextChanged += new System.EventHandler(this.Kolicina_TextChanged_1);
            // 
            // FrmUnosKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 418);
            this.Controls.Add(this.Kolicina);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblSifraKnjige);
            this.Controls.Add(this.txtSifraKnjige);
            this.Controls.Add(this.cmbLokacija);
            this.Controls.Add(this.cmbNazivZanra);
            this.Controls.Add(this.cmbNazivIzdavaca);
            this.Controls.Add(this.cmbImeAutora);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.lblNazivZanra);
            this.Controls.Add(this.lblNazivIzdavaca);
            this.Controls.Add(this.lblImeAutora);
            this.Controls.Add(this.lblGodinaIzdavanja);
            this.Controls.Add(this.lblNazivKnjige);
            this.Controls.Add(this.txtGodinaIzdavanja);
            this.Controls.Add(this.txtNazivKnjige);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmUnosKnjige";
            this.Text = "Unos knjige";
            this.Load += new System.EventHandler(this.FrmUnosKnjige_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbLokacija;
        internal System.Windows.Forms.ComboBox cmbNazivZanra;
        internal System.Windows.Forms.ComboBox cmbNazivIzdavaca;
        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Button btnPosalji;
        internal System.Windows.Forms.Label lblLokacija;
        internal System.Windows.Forms.Label lblKat;
        internal System.Windows.Forms.Label lblNazivZanra;
        internal System.Windows.Forms.Label lblNazivIzdavaca;
        internal System.Windows.Forms.Label lblGodinaIzdavanja;
        internal System.Windows.Forms.Label lblNazivKnjige;
        internal System.Windows.Forms.TextBox txtGodinaIzdavanja;
        internal System.Windows.Forms.TextBox txtNazivKnjige;
        internal System.Windows.Forms.Label lblImeAutora;
        internal System.Windows.Forms.ComboBox cmbImeAutora;
        internal System.Windows.Forms.Label lblSifraKnjige;
        internal System.Windows.Forms.TextBox txtSifraKnjige;
        internal System.Windows.Forms.Label txtKolicina;
        internal System.Windows.Forms.TextBox Kolicina;

    }
}