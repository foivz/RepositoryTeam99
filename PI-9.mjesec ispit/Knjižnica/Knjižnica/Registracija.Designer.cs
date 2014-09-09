namespace Knjižnica
{
    partial class FrmRegistracija
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
            this.lblOib = new System.Windows.Forms.Label();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.cmbTipKorisnika = new System.Windows.Forms.ComboBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblTipKorisnika = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOib
            // 
            this.lblOib.AutoSize = true;
            this.lblOib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOib.Location = new System.Drawing.Point(70, 97);
            this.lblOib.Name = "lblOib";
            this.lblOib.Size = new System.Drawing.Size(31, 17);
            this.lblOib.TabIndex = 124;
            this.lblOib.Text = "OIB";
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(214, 96);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(197, 20);
            this.txtOib.TabIndex = 123;
            // 
            // cmbTipKorisnika
            // 
            this.cmbTipKorisnika.FormattingEnabled = true;
            this.cmbTipKorisnika.Location = new System.Drawing.Point(214, 122);
            this.cmbTipKorisnika.Name = "cmbTipKorisnika";
            this.cmbTipKorisnika.Size = new System.Drawing.Size(197, 21);
            this.cmbTipKorisnika.TabIndex = 122;
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.Transparent;
            this.btnPosalji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPosalji.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPosalji.FlatAppearance.BorderSize = 0;
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosalji.Location = new System.Drawing.Point(146, 311);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(88, 30);
            this.btnPosalji.TabIndex = 121;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(255, 311);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(88, 30);
            this.btnIzlaz.TabIndex = 120;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.Location = new System.Drawing.Point(70, 228);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(57, 17);
            this.lblLozinka.TabIndex = 119;
            this.lblLozinka.Text = "Lozinka";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(69, 202);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(99, 17);
            this.lblKorisnickoIme.TabIndex = 118;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojTelefona.Location = new System.Drawing.Point(69, 176);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(88, 17);
            this.lblBrojTelefona.TabIndex = 117;
            this.lblBrojTelefona.Text = "Broj telefona";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(70, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 116;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(70, 71);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 17);
            this.lblPrezime.TabIndex = 114;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(70, 45);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 17);
            this.lblIme.TabIndex = 113;
            this.lblIme.Text = "Ime";
            // 
            // lblTipKorisnika
            // 
            this.lblTipKorisnika.AutoSize = true;
            this.lblTipKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTipKorisnika.Location = new System.Drawing.Point(70, 123);
            this.lblTipKorisnika.Name = "lblTipKorisnika";
            this.lblTipKorisnika.Size = new System.Drawing.Size(88, 17);
            this.lblTipKorisnika.TabIndex = 112;
            this.lblTipKorisnika.Text = "Tip korisnika";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(214, 227);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(197, 20);
            this.txtLozinka.TabIndex = 110;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(214, 201);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(197, 20);
            this.txtKorisnickoIme.TabIndex = 109;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(214, 175);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(197, 20);
            this.txtBrojTelefona.TabIndex = 108;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(214, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmail.TabIndex = 107;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(214, 70);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(197, 20);
            this.txtPrezime.TabIndex = 105;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(214, 44);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(197, 20);
            this.txtIme.TabIndex = 104;
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.lblOib);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.cmbTipKorisnika);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblTipKorisnika);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistracija";
            this.ShowIcon = false;
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.FrmRegistracija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblOib;
        internal System.Windows.Forms.TextBox txtOib;
        internal System.Windows.Forms.ComboBox cmbTipKorisnika;
        internal System.Windows.Forms.Button btnPosalji;
        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Label lblLozinka;
        internal System.Windows.Forms.Label lblKorisnickoIme;
        internal System.Windows.Forms.Label lblBrojTelefona;
        internal System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.Label lblPrezime;
        internal System.Windows.Forms.Label lblIme;
        internal System.Windows.Forms.Label lblTipKorisnika;
        internal System.Windows.Forms.TextBox txtLozinka;
        internal System.Windows.Forms.TextBox txtKorisnickoIme;
        internal System.Windows.Forms.TextBox txtBrojTelefona;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtPrezime;
        internal System.Windows.Forms.TextBox txtIme;

    }
}