namespace Knjižnica
{
    partial class Zaposlenik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zaposlenik));
            this.Label4 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnPosudba = new System.Windows.Forms.Button();
            this.btnClanarina = new System.Windows.Forms.Button();
            this.btnKnjigaPoNalsovu = new System.Windows.Forms.Button();
            this.btnLokacija = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnKnjigePoZanru = new System.Windows.Forms.Button();
            this.btnKnjigePoAutoru = new System.Windows.Forms.Button();
            this.btnUnosZanra = new System.Windows.Forms.Button();
            this.btnUnosLokacije = new System.Windows.Forms.Button();
            this.btnUnosKnjige = new System.Windows.Forms.Button();
            this.btnUnosIzdavaca = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnUnosAutora = new System.Windows.Forms.Button();
            this.Splitter1 = new System.Windows.Forms.Splitter();
            this.btnUrediBazu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label4.Location = new System.Drawing.Point(680, 561);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(116, 25);
            this.Label4.TabIndex = 63;
            this.Label4.Text = "\"Knjižnica\"";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PictureBox1.Location = new System.Drawing.Point(202, 474);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(752, 172);
            this.PictureBox1.TabIndex = 62;
            this.PictureBox1.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(23, 376);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(150, 17);
            this.Label3.TabIndex = 61;
            this.Label3.Text = "PROCES POSUDBE";
            // 
            // btnPosudba
            // 
            this.btnPosudba.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPosudba.Location = new System.Drawing.Point(0, 426);
            this.btnPosudba.Name = "btnPosudba";
            this.btnPosudba.Size = new System.Drawing.Size(200, 24);
            this.btnPosudba.TabIndex = 59;
            this.btnPosudba.Text = "Posudba knjige";
            this.btnPosudba.UseVisualStyleBackColor = true;
            this.btnPosudba.Click += new System.EventHandler(this.btnPosudba_Click);
            // 
            // btnClanarina
            // 
            this.btnClanarina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClanarina.Location = new System.Drawing.Point(1, 396);
            this.btnClanarina.Name = "btnClanarina";
            this.btnClanarina.Size = new System.Drawing.Size(200, 24);
            this.btnClanarina.TabIndex = 58;
            this.btnClanarina.Text = "Evidencija članarine";
            this.btnClanarina.UseVisualStyleBackColor = true;
            this.btnClanarina.Click += new System.EventHandler(this.btnClanarina_Click);
            // 
            // btnKnjigaPoNalsovu
            // 
            this.btnKnjigaPoNalsovu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKnjigaPoNalsovu.Location = new System.Drawing.Point(1, 297);
            this.btnKnjigaPoNalsovu.Name = "btnKnjigaPoNalsovu";
            this.btnKnjigaPoNalsovu.Size = new System.Drawing.Size(200, 24);
            this.btnKnjigaPoNalsovu.TabIndex = 57;
            this.btnKnjigaPoNalsovu.Text = "Pretraživanje knjige po naslovu";
            this.btnKnjigaPoNalsovu.UseVisualStyleBackColor = true;
            this.btnKnjigaPoNalsovu.Click += new System.EventHandler(this.btnKnjigaPoNalsovu_Click);
            // 
            // btnLokacija
            // 
            this.btnLokacija.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLokacija.Location = new System.Drawing.Point(0, 267);
            this.btnLokacija.Name = "btnLokacija";
            this.btnLokacija.Size = new System.Drawing.Size(200, 24);
            this.btnLokacija.TabIndex = 56;
            this.btnLokacija.Text = "Lokacije knjige prema nazivu";
            this.btnLokacija.UseVisualStyleBackColor = true;
            this.btnLokacija.Click += new System.EventHandler(this.btnLokacija_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(40, 187);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(133, 17);
            this.Label2.TabIndex = 55;
            this.Label2.Text = "PRETRAŽIVANJE";
            // 
            // btnKnjigePoZanru
            // 
            this.btnKnjigePoZanru.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKnjigePoZanru.Location = new System.Drawing.Point(1, 237);
            this.btnKnjigePoZanru.Name = "btnKnjigePoZanru";
            this.btnKnjigePoZanru.Size = new System.Drawing.Size(200, 24);
            this.btnKnjigePoZanru.TabIndex = 53;
            this.btnKnjigePoZanru.Text = "Knjige po žanru";
            this.btnKnjigePoZanru.UseVisualStyleBackColor = true;
            this.btnKnjigePoZanru.Click += new System.EventHandler(this.btnKnjigePoZanru_Click);
            // 
            // btnKnjigePoAutoru
            // 
            this.btnKnjigePoAutoru.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKnjigePoAutoru.Location = new System.Drawing.Point(1, 207);
            this.btnKnjigePoAutoru.Name = "btnKnjigePoAutoru";
            this.btnKnjigePoAutoru.Size = new System.Drawing.Size(200, 24);
            this.btnKnjigePoAutoru.TabIndex = 52;
            this.btnKnjigePoAutoru.Text = "Knjige po autoru";
            this.btnKnjigePoAutoru.UseVisualStyleBackColor = true;
            this.btnKnjigePoAutoru.Click += new System.EventHandler(this.btnKnjigePoAutoru_Click);
            // 
            // btnUnosZanra
            // 
            this.btnUnosZanra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUnosZanra.Location = new System.Drawing.Point(1, 149);
            this.btnUnosZanra.Name = "btnUnosZanra";
            this.btnUnosZanra.Size = new System.Drawing.Size(200, 24);
            this.btnUnosZanra.TabIndex = 51;
            this.btnUnosZanra.Text = "Unos žanra";
            this.btnUnosZanra.UseVisualStyleBackColor = true;
            this.btnUnosZanra.Click += new System.EventHandler(this.btnUnosZanra_Click);
            // 
            // btnUnosLokacije
            // 
            this.btnUnosLokacije.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUnosLokacije.Location = new System.Drawing.Point(1, 119);
            this.btnUnosLokacije.Name = "btnUnosLokacije";
            this.btnUnosLokacije.Size = new System.Drawing.Size(200, 24);
            this.btnUnosLokacije.TabIndex = 50;
            this.btnUnosLokacije.Text = "Unos lokacije";
            this.btnUnosLokacije.UseVisualStyleBackColor = true;
            this.btnUnosLokacije.Click += new System.EventHandler(this.btnUnosLokacije_Click);
            // 
            // btnUnosKnjige
            // 
            this.btnUnosKnjige.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUnosKnjige.Location = new System.Drawing.Point(1, 89);
            this.btnUnosKnjige.Name = "btnUnosKnjige";
            this.btnUnosKnjige.Size = new System.Drawing.Size(200, 24);
            this.btnUnosKnjige.TabIndex = 49;
            this.btnUnosKnjige.Text = "Unos knjige";
            this.btnUnosKnjige.UseVisualStyleBackColor = true;
            this.btnUnosKnjige.Click += new System.EventHandler(this.btnUnosKnjige_Click);
            // 
            // btnUnosIzdavaca
            // 
            this.btnUnosIzdavaca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUnosIzdavaca.Location = new System.Drawing.Point(1, 59);
            this.btnUnosIzdavaca.Name = "btnUnosIzdavaca";
            this.btnUnosIzdavaca.Size = new System.Drawing.Size(200, 24);
            this.btnUnosIzdavaca.TabIndex = 48;
            this.btnUnosIzdavaca.Text = "Unos izdavača";
            this.btnUnosIzdavaca.UseVisualStyleBackColor = true;
            this.btnUnosIzdavaca.Click += new System.EventHandler(this.btnUnosIzdavaca_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(78, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 17);
            this.Label1.TabIndex = 47;
            this.Label1.Text = "UNOS";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIzlaz.Location = new System.Drawing.Point(1, 596);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(200, 24);
            this.btnIzlaz.TabIndex = 46;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnUnosAutora
            // 
            this.btnUnosAutora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUnosAutora.Location = new System.Drawing.Point(1, 29);
            this.btnUnosAutora.Name = "btnUnosAutora";
            this.btnUnosAutora.Size = new System.Drawing.Size(200, 24);
            this.btnUnosAutora.TabIndex = 45;
            this.btnUnosAutora.Text = "Unos autora";
            this.btnUnosAutora.UseVisualStyleBackColor = true;
            this.btnUnosAutora.Click += new System.EventHandler(this.btnUnosAutora_Click);
            // 
            // Splitter1
            // 
            this.Splitter1.BackColor = System.Drawing.Color.White;
            this.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Splitter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Splitter1.Location = new System.Drawing.Point(0, 0);
            this.Splitter1.Name = "Splitter1";
            this.Splitter1.Size = new System.Drawing.Size(200, 647);
            this.Splitter1.TabIndex = 44;
            this.Splitter1.TabStop = false;
            // 
            // btnUrediBazu
            // 
            this.btnUrediBazu.Location = new System.Drawing.Point(1, 567);
            this.btnUrediBazu.Name = "btnUrediBazu";
            this.btnUrediBazu.Size = new System.Drawing.Size(200, 23);
            this.btnUrediBazu.TabIndex = 65;
            this.btnUrediBazu.Text = "Uredi bazu";
            this.btnUrediBazu.UseVisualStyleBackColor = true;
            this.btnUrediBazu.Click += new System.EventHandler(this.btnUrediBazu_Click);
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(1, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 24);
            this.button1.TabIndex = 67;
            this.button1.Text = "Pregled slobodnih knjiga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUrediBazu);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnPosudba);
            this.Controls.Add(this.btnClanarina);
            this.Controls.Add(this.btnKnjigaPoNalsovu);
            this.Controls.Add(this.btnLokacija);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnKnjigePoZanru);
            this.Controls.Add(this.btnKnjigePoAutoru);
            this.Controls.Add(this.btnUnosZanra);
            this.Controls.Add(this.btnUnosLokacije);
            this.Controls.Add(this.btnUnosKnjige);
            this.Controls.Add(this.btnUnosIzdavaca);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnUnosAutora);
            this.Controls.Add(this.Splitter1);
            this.IsMdiContainer = true;
            this.Name = "Zaposlenik";
            this.ShowIcon = false;
            this.Text = "Zaposlenik";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnPosudba;
        internal System.Windows.Forms.Button btnClanarina;
        internal System.Windows.Forms.Button btnKnjigaPoNalsovu;
        internal System.Windows.Forms.Button btnLokacija;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnKnjigePoZanru;
        internal System.Windows.Forms.Button btnKnjigePoAutoru;
        internal System.Windows.Forms.Button btnUnosZanra;
        internal System.Windows.Forms.Button btnUnosLokacije;
        internal System.Windows.Forms.Button btnUnosKnjige;
        internal System.Windows.Forms.Button btnUnosIzdavaca;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Button btnUnosAutora;
        internal System.Windows.Forms.Splitter Splitter1;
        private System.Windows.Forms.Button btnUrediBazu;
        internal System.Windows.Forms.Button button1;

    }
}