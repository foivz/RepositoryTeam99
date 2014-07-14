namespace Knjižnica
{
    partial class FrmRegistriraniKorisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistriraniKorisnik));
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnKnjigaPoNaslovu = new System.Windows.Forms.Button();
            this.btnLokacijaKnjige = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnKnjigePoZanru = new System.Windows.Forms.Button();
            this.btnKnjigePoAutoru = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Splitter1 = new System.Windows.Forms.Splitter();
            this.btnSlobodneKnjige = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIzlaz.Location = new System.Drawing.Point(1, 450);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(200, 24);
            this.btnIzlaz.TabIndex = 42;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnKnjigaPoNaslovu
            // 
            this.btnKnjigaPoNaslovu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKnjigaPoNaslovu.Location = new System.Drawing.Point(1, 142);
            this.btnKnjigaPoNaslovu.Name = "btnKnjigaPoNaslovu";
            this.btnKnjigaPoNaslovu.Size = new System.Drawing.Size(200, 24);
            this.btnKnjigaPoNaslovu.TabIndex = 41;
            this.btnKnjigaPoNaslovu.Text = "Pretraživanje knjige po naslovu";
            this.btnKnjigaPoNaslovu.UseVisualStyleBackColor = true;
            this.btnKnjigaPoNaslovu.Click += new System.EventHandler(this.Button11_Click);
            // 
            // btnLokacijaKnjige
            // 
            this.btnLokacijaKnjige.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLokacijaKnjige.Location = new System.Drawing.Point(1, 112);
            this.btnLokacijaKnjige.Name = "btnLokacijaKnjige";
            this.btnLokacijaKnjige.Size = new System.Drawing.Size(200, 24);
            this.btnLokacijaKnjige.TabIndex = 40;
            this.btnLokacijaKnjige.Text = "Lokacije knjige prema nazivu";
            this.btnLokacijaKnjige.UseVisualStyleBackColor = true;
            this.btnLokacijaKnjige.Click += new System.EventHandler(this.Button10_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(37, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(133, 17);
            this.Label2.TabIndex = 39;
            this.Label2.Text = "PRETRAŽIVANJE";
            // 
            // btnKnjigePoZanru
            // 
            this.btnKnjigePoZanru.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKnjigePoZanru.Location = new System.Drawing.Point(1, 82);
            this.btnKnjigePoZanru.Name = "btnKnjigePoZanru";
            this.btnKnjigePoZanru.Size = new System.Drawing.Size(200, 24);
            this.btnKnjigePoZanru.TabIndex = 38;
            this.btnKnjigePoZanru.Text = "Knjige po žanru";
            this.btnKnjigePoZanru.UseVisualStyleBackColor = true;
            this.btnKnjigePoZanru.Click += new System.EventHandler(this.Button8_Click);
            // 
            // btnKnjigePoAutoru
            // 
            this.btnKnjigePoAutoru.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKnjigePoAutoru.Location = new System.Drawing.Point(1, 52);
            this.btnKnjigePoAutoru.Name = "btnKnjigePoAutoru";
            this.btnKnjigePoAutoru.Size = new System.Drawing.Size(200, 24);
            this.btnKnjigePoAutoru.TabIndex = 37;
            this.btnKnjigePoAutoru.Text = "Knjige po autoru";
            this.btnKnjigePoAutoru.UseVisualStyleBackColor = true;
            this.btnKnjigePoAutoru.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label4.Location = new System.Drawing.Point(666, 553);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(116, 25);
            this.Label4.TabIndex = 36;
            this.Label4.Text = "\"Knjižnica\"";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PictureBox1.Location = new System.Drawing.Point(202, 473);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(752, 172);
            this.PictureBox1.TabIndex = 35;
            this.PictureBox1.TabStop = false;
            // 
            // Splitter1
            // 
            this.Splitter1.BackColor = System.Drawing.Color.White;
            this.Splitter1.Location = new System.Drawing.Point(0, 0);
            this.Splitter1.Name = "Splitter1";
            this.Splitter1.Size = new System.Drawing.Size(200, 647);
            this.Splitter1.TabIndex = 34;
            this.Splitter1.TabStop = false;
            // 
            // btnSlobodneKnjige
            // 
            this.btnSlobodneKnjige.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSlobodneKnjige.Location = new System.Drawing.Point(1, 172);
            this.btnSlobodneKnjige.Name = "btnSlobodneKnjige";
            this.btnSlobodneKnjige.Size = new System.Drawing.Size(200, 24);
            this.btnSlobodneKnjige.TabIndex = 44;
            this.btnSlobodneKnjige.Text = "Pregled slobodnih knjiga";
            this.btnSlobodneKnjige.UseVisualStyleBackColor = true;
            this.btnSlobodneKnjige.Click += new System.EventHandler(this.btnSlobodneKnjige_Click);
            // 
            // FrmRegistriraniKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 647);
            this.Controls.Add(this.btnSlobodneKnjige);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnKnjigaPoNaslovu);
            this.Controls.Add(this.btnLokacijaKnjige);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnKnjigePoZanru);
            this.Controls.Add(this.btnKnjigePoAutoru);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Splitter1);
            this.IsMdiContainer = true;
            this.Name = "FrmRegistriraniKorisnik";
            this.ShowIcon = false;
            this.Text = "Registrirani korisnik";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Button btnKnjigaPoNaslovu;
        internal System.Windows.Forms.Button btnLokacijaKnjige;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnKnjigePoZanru;
        internal System.Windows.Forms.Button btnKnjigePoAutoru;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Splitter Splitter1;
        internal System.Windows.Forms.Button btnSlobodneKnjige;
    }
}