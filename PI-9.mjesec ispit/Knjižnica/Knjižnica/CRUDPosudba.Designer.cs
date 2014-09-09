namespace Knjižnica
{
    partial class CRUDPosudba
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
            this.idPosudbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPosudbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVracanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjiga1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnik1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posudivanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblNazivKorisnika = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudivanjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPosudbeDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.Column1,
            this.knjigaDataGridViewTextBoxColumn,
            this.Column2,
            this.datumPosudbeDataGridViewTextBoxColumn,
            this.datumVracanjaDataGridViewTextBoxColumn,
            this.knjiga1DataGridViewTextBoxColumn,
            this.korisnik1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.posudivanjeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 363);
            this.dataGridView1.TabIndex = 85;
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
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Šifra korisnika";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Korisničko ime";
            this.Column1.Name = "Column1";
            // 
            // knjigaDataGridViewTextBoxColumn
            // 
            this.knjigaDataGridViewTextBoxColumn.DataPropertyName = "knjiga";
            this.knjigaDataGridViewTextBoxColumn.HeaderText = "Šifra knjige";
            this.knjigaDataGridViewTextBoxColumn.Name = "knjigaDataGridViewTextBoxColumn";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Naziv knjige";
            this.Column2.Name = "Column2";
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
            // posudivanjeBindingSource
            // 
            this.posudivanjeBindingSource.DataSource = typeof(Knjižnica.posudivanje);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(460, 50);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(80, 30);
            this.btnPretrazi.TabIndex = 92;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblNazivKorisnika
            // 
            this.lblNazivKorisnika.AutoSize = true;
            this.lblNazivKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivKorisnika.Location = new System.Drawing.Point(153, 53);
            this.lblNazivKorisnika.Name = "lblNazivKorisnika";
            this.lblNazivKorisnika.Size = new System.Drawing.Size(113, 18);
            this.lblNazivKorisnika.TabIndex = 91;
            this.lblNazivKorisnika.Text = "Naziv korisnika:";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(270, 54);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(153, 20);
            this.txtKorisnik.TabIndex = 90;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(658, 81);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(80, 30);
            this.btnIzlaz.TabIndex = 89;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.Transparent;
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzuriraj.Location = new System.Drawing.Point(658, 45);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(80, 30);
            this.btnAzuriraj.TabIndex = 94;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.Location = new System.Drawing.Point(658, 9);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(80, 30);
            this.btnObrisi.TabIndex = 93;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // CRUDPosudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblNazivKorisnika);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDPosudba";
            this.Text = "CRUDPosudba";
            this.Shown += new System.EventHandler(this.CRUDPosudba_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudivanjeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnPretrazi;
        internal System.Windows.Forms.Label lblNazivKorisnika;
        internal System.Windows.Forms.TextBox txtKorisnik;
        internal System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.BindingSource posudivanjeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPosudbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPosudbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVracanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjiga1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnik1DataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button btnAzuriraj;
        internal System.Windows.Forms.Button btnObrisi;
    }
}