namespace Knjižnica
{
    partial class frmPregledSlobodnihKnjiga
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblNaslovKnjige = new System.Windows.Forms.Label();
            this.txtNaslovKnjige = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.posudivanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idKnjigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdavacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijaKnjigeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorKnjigeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdavac1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijaKnjige1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posudbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPosudbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPosudbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVracanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjiga1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnik1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudivanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKnjigaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.godinaIzdavanjaDataGridViewTextBoxColumn,
            this.izdavacDataGridViewTextBoxColumn,
            this.zanrDataGridViewTextBoxColumn,
            this.Column1,
            this.lokacijaKnjigeDataGridViewTextBoxColumn,
            this.autorKnjigeDataGridViewTextBoxColumn,
            this.izdavac1DataGridViewTextBoxColumn,
            this.zanr1DataGridViewTextBoxColumn,
            this.lokacijaKnjige1DataGridViewTextBoxColumn,
            this.posudbaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.knjigaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 168);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(472, 51);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(80, 30);
            this.btnPretrazi.TabIndex = 88;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblNaslovKnjige
            // 
            this.lblNaslovKnjige.AutoSize = true;
            this.lblNaslovKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovKnjige.Location = new System.Drawing.Point(176, 57);
            this.lblNaslovKnjige.Name = "lblNaslovKnjige";
            this.lblNaslovKnjige.Size = new System.Drawing.Size(100, 18);
            this.lblNaslovKnjige.TabIndex = 87;
            this.lblNaslovKnjige.Text = "Naslov knjige:";
            // 
            // txtNaslovKnjige
            // 
            this.txtNaslovKnjige.Location = new System.Drawing.Point(282, 55);
            this.txtNaslovKnjige.Name = "txtNaslovKnjige";
            this.txtNaslovKnjige.Size = new System.Drawing.Size(153, 20);
            this.txtNaslovKnjige.TabIndex = 86;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(571, 51);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(80, 30);
            this.btnIzlaz.TabIndex = 85;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPosudbeDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.knjigaDataGridViewTextBoxColumn,
            this.datumPosudbeDataGridViewTextBoxColumn,
            this.datumVracanjaDataGridViewTextBoxColumn,
            this.knjiga1DataGridViewTextBoxColumn,
            this.korisnik1DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.posudivanjeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 329);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(755, 150);
            this.dataGridView2.TabIndex = 89;
            // 
            // posudivanjeBindingSource
            // 
            this.posudivanjeBindingSource.DataSource = typeof(Knjižnica.posudivanje);
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataSource = typeof(Knjižnica.knjiga);
            // 
            // idKnjigaDataGridViewTextBoxColumn
            // 
            this.idKnjigaDataGridViewTextBoxColumn.DataPropertyName = "idKnjiga";
            this.idKnjigaDataGridViewTextBoxColumn.HeaderText = "Šifra knjige";
            this.idKnjigaDataGridViewTextBoxColumn.Name = "idKnjigaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv knjige";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // godinaIzdavanjaDataGridViewTextBoxColumn
            // 
            this.godinaIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "godinaIzdavanja";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.HeaderText = "godinaIzdavanja";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.Name = "godinaIzdavanjaDataGridViewTextBoxColumn";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // izdavacDataGridViewTextBoxColumn
            // 
            this.izdavacDataGridViewTextBoxColumn.DataPropertyName = "izdavac";
            this.izdavacDataGridViewTextBoxColumn.HeaderText = "izdavac";
            this.izdavacDataGridViewTextBoxColumn.Name = "izdavacDataGridViewTextBoxColumn";
            this.izdavacDataGridViewTextBoxColumn.Visible = false;
            // 
            // zanrDataGridViewTextBoxColumn
            // 
            this.zanrDataGridViewTextBoxColumn.DataPropertyName = "zanr";
            this.zanrDataGridViewTextBoxColumn.HeaderText = "zanr";
            this.zanrDataGridViewTextBoxColumn.Name = "zanrDataGridViewTextBoxColumn";
            this.zanrDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Žanr";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // lokacijaKnjigeDataGridViewTextBoxColumn
            // 
            this.lokacijaKnjigeDataGridViewTextBoxColumn.DataPropertyName = "lokacijaKnjige";
            this.lokacijaKnjigeDataGridViewTextBoxColumn.HeaderText = "lokacijaKnjige";
            this.lokacijaKnjigeDataGridViewTextBoxColumn.Name = "lokacijaKnjigeDataGridViewTextBoxColumn";
            this.lokacijaKnjigeDataGridViewTextBoxColumn.Visible = false;
            // 
            // autorKnjigeDataGridViewTextBoxColumn
            // 
            this.autorKnjigeDataGridViewTextBoxColumn.DataPropertyName = "autorKnjige";
            this.autorKnjigeDataGridViewTextBoxColumn.HeaderText = "autorKnjige";
            this.autorKnjigeDataGridViewTextBoxColumn.Name = "autorKnjigeDataGridViewTextBoxColumn";
            this.autorKnjigeDataGridViewTextBoxColumn.Visible = false;
            // 
            // izdavac1DataGridViewTextBoxColumn
            // 
            this.izdavac1DataGridViewTextBoxColumn.DataPropertyName = "izdavac1";
            this.izdavac1DataGridViewTextBoxColumn.HeaderText = "izdavac1";
            this.izdavac1DataGridViewTextBoxColumn.Name = "izdavac1DataGridViewTextBoxColumn";
            this.izdavac1DataGridViewTextBoxColumn.Visible = false;
            // 
            // zanr1DataGridViewTextBoxColumn
            // 
            this.zanr1DataGridViewTextBoxColumn.DataPropertyName = "zanr1";
            this.zanr1DataGridViewTextBoxColumn.HeaderText = "zanr1";
            this.zanr1DataGridViewTextBoxColumn.Name = "zanr1DataGridViewTextBoxColumn";
            this.zanr1DataGridViewTextBoxColumn.Visible = false;
            // 
            // lokacijaKnjige1DataGridViewTextBoxColumn
            // 
            this.lokacijaKnjige1DataGridViewTextBoxColumn.DataPropertyName = "lokacijaKnjige1";
            this.lokacijaKnjige1DataGridViewTextBoxColumn.HeaderText = "lokacijaKnjige1";
            this.lokacijaKnjige1DataGridViewTextBoxColumn.Name = "lokacijaKnjige1DataGridViewTextBoxColumn";
            this.lokacijaKnjige1DataGridViewTextBoxColumn.Visible = false;
            // 
            // posudbaDataGridViewTextBoxColumn
            // 
            this.posudbaDataGridViewTextBoxColumn.DataPropertyName = "posudba";
            this.posudbaDataGridViewTextBoxColumn.HeaderText = "posudba";
            this.posudbaDataGridViewTextBoxColumn.Name = "posudbaDataGridViewTextBoxColumn";
            this.posudbaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPosudbeDataGridViewTextBoxColumn
            // 
            this.idPosudbeDataGridViewTextBoxColumn.DataPropertyName = "idPosudbe";
            this.idPosudbeDataGridViewTextBoxColumn.HeaderText = "Šifra posudbe";
            this.idPosudbeDataGridViewTextBoxColumn.Name = "idPosudbeDataGridViewTextBoxColumn";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // knjigaDataGridViewTextBoxColumn
            // 
            this.knjigaDataGridViewTextBoxColumn.DataPropertyName = "knjiga";
            this.knjigaDataGridViewTextBoxColumn.HeaderText = "knjiga";
            this.knjigaDataGridViewTextBoxColumn.Name = "knjigaDataGridViewTextBoxColumn";
            this.knjigaDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumPosudbeDataGridViewTextBoxColumn
            // 
            this.datumPosudbeDataGridViewTextBoxColumn.DataPropertyName = "datumPosudbe";
            this.datumPosudbeDataGridViewTextBoxColumn.HeaderText = "Datum posudbe";
            this.datumPosudbeDataGridViewTextBoxColumn.Name = "datumPosudbeDataGridViewTextBoxColumn";
            // 
            // datumVracanjaDataGridViewTextBoxColumn
            // 
            this.datumVracanjaDataGridViewTextBoxColumn.DataPropertyName = "datumVracanja";
            this.datumVracanjaDataGridViewTextBoxColumn.HeaderText = "Datum vraćanja";
            this.datumVracanjaDataGridViewTextBoxColumn.Name = "datumVracanjaDataGridViewTextBoxColumn";
            // 
            // knjiga1DataGridViewTextBoxColumn
            // 
            this.knjiga1DataGridViewTextBoxColumn.DataPropertyName = "knjiga1";
            this.knjiga1DataGridViewTextBoxColumn.HeaderText = "knjiga1";
            this.knjiga1DataGridViewTextBoxColumn.Name = "knjiga1DataGridViewTextBoxColumn";
            this.knjiga1DataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnik1DataGridViewTextBoxColumn
            // 
            this.korisnik1DataGridViewTextBoxColumn.DataPropertyName = "korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.HeaderText = "korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.Name = "korisnik1DataGridViewTextBoxColumn";
            this.korisnik1DataGridViewTextBoxColumn.Visible = false;
            // 
            // frmPregledSlobodnihKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblNaslovKnjige);
            this.Controls.Add(this.txtNaslovKnjige);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPregledSlobodnihKnjiga";
            this.Text = "PregledSlobodnihKnjiga";
            this.Load += new System.EventHandler(this.PregledSlobodnihKnjiga_Load);
            this.Shown += new System.EventHandler(this.PregledSlobodnihKnjiga_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudivanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnPretrazi;
        internal System.Windows.Forms.Label lblNaslovKnjige;
        internal System.Windows.Forms.TextBox txtNaslovKnjige;
        internal System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource posudivanjeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKnjigaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdavacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijaKnjigeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorKnjigeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdavac1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijaKnjige1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posudbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPosudbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPosudbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVracanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjiga1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnik1DataGridViewTextBoxColumn;
    }
}