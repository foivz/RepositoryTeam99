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
            this.cmbIme = new System.Windows.Forms.ComboBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lblDatumVracanja = new System.Windows.Forms.Label();
            this.lblDatumPosudbe = new System.Windows.Forms.Label();
            this.lblNazivKnjige = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Location = new System.Drawing.Point(211, 114);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(153, 21);
            this.cmbNaziv.TabIndex = 121;
            // 
            // cmbIme
            // 
            this.cmbIme.FormattingEnabled = true;
            this.cmbIme.Location = new System.Drawing.Point(211, 87);
            this.cmbIme.Name = "cmbIme";
            this.cmbIme.Size = new System.Drawing.Size(153, 21);
            this.cmbIme.TabIndex = 120;
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
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // lblDatumVracanja
            // 
            this.lblDatumVracanja.AutoSize = true;
            this.lblDatumVracanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumVracanja.Location = new System.Drawing.Point(66, 171);
            this.lblDatumVracanja.Name = "lblDatumVracanja";
            this.lblDatumVracanja.Size = new System.Drawing.Size(111, 18);
            this.lblDatumVracanja.TabIndex = 114;
            this.lblDatumVracanja.Text = "Datum vracanja";
            // 
            // lblDatumPosudbe
            // 
            this.lblDatumPosudbe.AutoSize = true;
            this.lblDatumPosudbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumPosudbe.Location = new System.Drawing.Point(66, 144);
            this.lblDatumPosudbe.Name = "lblDatumPosudbe";
            this.lblDatumPosudbe.Size = new System.Drawing.Size(113, 18);
            this.lblDatumPosudbe.TabIndex = 113;
            this.lblDatumPosudbe.Text = "Datum posudbe";
            // 
            // lblNazivKnjige
            // 
            this.lblNazivKnjige.AutoSize = true;
            this.lblNazivKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivKnjige.Location = new System.Drawing.Point(66, 117);
            this.lblNazivKnjige.Name = "lblNazivKnjige";
            this.lblNazivKnjige.Size = new System.Drawing.Size(91, 18);
            this.lblNazivKnjige.TabIndex = 112;
            this.lblNazivKnjige.Text = "Naziv knjige:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(66, 90);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(109, 18);
            this.lblIme.TabIndex = 111;
            this.lblIme.Text = "Naziv korisnika";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 122;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(211, 169);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker2.TabIndex = 123;
            // 
            // FrmPosudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(436, 365);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbNaziv);
            this.Controls.Add(this.cmbIme);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.lblDatumVracanja);
            this.Controls.Add(this.lblDatumPosudbe);
            this.Controls.Add(this.lblNazivKnjige);
            this.Controls.Add(this.lblIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPosudba";
            this.Text = "Posudba";
            this.Load += new System.EventHandler(this.FrmPosudba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbNaziv;
        internal System.Windows.Forms.ComboBox cmbIme;
        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Button btnPosalji;
        internal System.Windows.Forms.Label lblDatumVracanja;
        internal System.Windows.Forms.Label lblDatumPosudbe;
        internal System.Windows.Forms.Label lblNazivKnjige;
        internal System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}