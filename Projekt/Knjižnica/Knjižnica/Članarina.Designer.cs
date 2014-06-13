namespace Knjižnica
{
    partial class FrmClanarina
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
            this.cmbKorisnickoIme = new System.Windows.Forms.ComboBox();
            this.cmbPrezime = new System.Windows.Forms.ComboBox();
            this.cmbIme = new System.Windows.Forms.ComboBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblDatumIsteka = new System.Windows.Forms.Label();
            this.lblDatumPlacanja = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblSifraClanarine = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtDatumIsteka = new System.Windows.Forms.TextBox();
            this.txtDatumPlacanja = new System.Windows.Forms.TextBox();
            this.txtSifraClanarine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbKorisnickoIme
            // 
            this.cmbKorisnickoIme.FormattingEnabled = true;
            this.cmbKorisnickoIme.Location = new System.Drawing.Point(238, 129);
            this.cmbKorisnickoIme.Name = "cmbKorisnickoIme";
            this.cmbKorisnickoIme.Size = new System.Drawing.Size(153, 21);
            this.cmbKorisnickoIme.TabIndex = 118;
            // 
            // cmbPrezime
            // 
            this.cmbPrezime.DisplayMember = "prezime";
            this.cmbPrezime.FormattingEnabled = true;
            this.cmbPrezime.Location = new System.Drawing.Point(238, 103);
            this.cmbPrezime.Name = "cmbPrezime";
            this.cmbPrezime.Size = new System.Drawing.Size(153, 21);
            this.cmbPrezime.TabIndex = 117;
            this.cmbPrezime.ValueMember = "prezime";
            // 
            // cmbIme
            // 
            this.cmbIme.DisplayMember = "ime";
            this.cmbIme.FormattingEnabled = true;
            this.cmbIme.Location = new System.Drawing.Point(238, 77);
            this.cmbIme.Name = "cmbIme";
            this.cmbIme.Size = new System.Drawing.Size(153, 21);
            this.cmbIme.TabIndex = 116;
            this.cmbIme.ValueMember = "ime";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(79, 130);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(99, 17);
            this.lblKorisnickoIme.TabIndex = 115;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(111, 285);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(88, 30);
            this.btnIzlaz.TabIndex = 114;
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
            this.btnPosalji.Location = new System.Drawing.Point(252, 285);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(88, 30);
            this.btnPosalji.TabIndex = 113;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCijena.Location = new System.Drawing.Point(79, 223);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(47, 17);
            this.lblCijena.TabIndex = 112;
            this.lblCijena.Text = "Cijena";
            // 
            // lblDatumIsteka
            // 
            this.lblDatumIsteka.AutoSize = true;
            this.lblDatumIsteka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumIsteka.Location = new System.Drawing.Point(79, 197);
            this.lblDatumIsteka.Name = "lblDatumIsteka";
            this.lblDatumIsteka.Size = new System.Drawing.Size(90, 17);
            this.lblDatumIsteka.TabIndex = 111;
            this.lblDatumIsteka.Text = "Datum isteka";
            // 
            // lblDatumPlacanja
            // 
            this.lblDatumPlacanja.AutoSize = true;
            this.lblDatumPlacanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumPlacanja.Location = new System.Drawing.Point(79, 171);
            this.lblDatumPlacanja.Name = "lblDatumPlacanja";
            this.lblDatumPlacanja.Size = new System.Drawing.Size(106, 17);
            this.lblDatumPlacanja.TabIndex = 110;
            this.lblDatumPlacanja.Text = "Datum plaćanja";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(79, 104);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 17);
            this.lblPrezime.TabIndex = 109;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(79, 78);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 108;
            this.lblIme.Text = "Ime ";
            // 
            // lblSifraClanarine
            // 
            this.lblSifraClanarine.AutoSize = true;
            this.lblSifraClanarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifraClanarine.Location = new System.Drawing.Point(27, 41);
            this.lblSifraClanarine.Name = "lblSifraClanarine";
            this.lblSifraClanarine.Size = new System.Drawing.Size(114, 17);
            this.lblSifraClanarine.TabIndex = 107;
            this.lblSifraClanarine.Text = "Šifra članarine";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(238, 222);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(153, 20);
            this.txtCijena.TabIndex = 106;
            // 
            // txtDatumIsteka
            // 
            this.txtDatumIsteka.Location = new System.Drawing.Point(238, 196);
            this.txtDatumIsteka.Name = "txtDatumIsteka";
            this.txtDatumIsteka.Size = new System.Drawing.Size(153, 20);
            this.txtDatumIsteka.TabIndex = 105;
            // 
            // txtDatumPlacanja
            // 
            this.txtDatumPlacanja.Location = new System.Drawing.Point(238, 170);
            this.txtDatumPlacanja.Name = "txtDatumPlacanja";
            this.txtDatumPlacanja.Size = new System.Drawing.Size(153, 20);
            this.txtDatumPlacanja.TabIndex = 104;
            // 
            // txtSifraClanarine
            // 
            this.txtSifraClanarine.Location = new System.Drawing.Point(147, 40);
            this.txtSifraClanarine.Name = "txtSifraClanarine";
            this.txtSifraClanarine.Size = new System.Drawing.Size(68, 20);
            this.txtSifraClanarine.TabIndex = 103;
            // 
            // FrmClanarina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 365);
            this.Controls.Add(this.cmbKorisnickoIme);
            this.Controls.Add(this.cmbPrezime);
            this.Controls.Add(this.cmbIme);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblDatumIsteka);
            this.Controls.Add(this.lblDatumPlacanja);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblSifraClanarine);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtDatumIsteka);
            this.Controls.Add(this.txtDatumPlacanja);
            this.Controls.Add(this.txtSifraClanarine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmClanarina";
            this.Text = "Članarina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbKorisnickoIme;
        internal System.Windows.Forms.ComboBox cmbPrezime;
        internal System.Windows.Forms.ComboBox cmbIme;
        internal System.Windows.Forms.Label lblKorisnickoIme;
        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Button btnPosalji;
        internal System.Windows.Forms.Label lblCijena;
        internal System.Windows.Forms.Label lblDatumIsteka;
        internal System.Windows.Forms.Label lblDatumPlacanja;
        internal System.Windows.Forms.Label lblPrezime;
        internal System.Windows.Forms.Label lblIme;
        internal System.Windows.Forms.Label lblSifraClanarine;
        internal System.Windows.Forms.TextBox txtCijena;
        internal System.Windows.Forms.TextBox txtDatumIsteka;
        internal System.Windows.Forms.TextBox txtDatumPlacanja;
        internal System.Windows.Forms.TextBox txtSifraClanarine;

    }
}