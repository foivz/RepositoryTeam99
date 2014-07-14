namespace Knjižnica
{
    partial class FrmUnosIzdavaca
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
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(101, 287);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(98, 30);
            this.btnIzlaz.TabIndex = 99;
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
            this.btnPosalji.Location = new System.Drawing.Point(237, 287);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(98, 30);
            this.btnPosalji.TabIndex = 98;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKontakt.Location = new System.Drawing.Point(73, 187);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(52, 16);
            this.lblKontakt.TabIndex = 97;
            this.lblKontakt.Text = "Kontakt";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(227, 186);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(128, 20);
            this.txtKontakt.TabIndex = 96;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.Location = new System.Drawing.Point(73, 129);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(52, 16);
            this.lblAdresa.TabIndex = 95;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(73, 76);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(42, 16);
            this.lblNaziv.TabIndex = 94;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(227, 128);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(128, 20);
            this.txtAdresa.TabIndex = 92;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(227, 75);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(128, 20);
            this.txtNaziv.TabIndex = 91;
            // 
            // FrmUnosIzdavaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 365);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.lblKontakt);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmUnosIzdavaca";
            this.Text = "Unos izdavača";
            this.Load += new System.EventHandler(this.FrmUnosIzdavaca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Button btnPosalji;
        internal System.Windows.Forms.Label lblKontakt;
        internal System.Windows.Forms.TextBox txtKontakt;
        internal System.Windows.Forms.Label lblAdresa;
        internal System.Windows.Forms.Label lblNaziv;
        internal System.Windows.Forms.TextBox txtAdresa;
        internal System.Windows.Forms.TextBox txtNaziv;

    }
}