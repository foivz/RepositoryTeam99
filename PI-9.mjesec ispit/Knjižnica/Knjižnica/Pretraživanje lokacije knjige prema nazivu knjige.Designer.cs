namespace Knjižnica
{
    partial class FrmKnjigaPoNazivu
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
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblNazivKnjige = new System.Windows.Forms.Label();
            this.txtNazivKnjige = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idKnjigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijaKnjigeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdavacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorKnjigeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdavac1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijaKnjige1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posudbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(483, 48);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(80, 30);
            this.btnPretrazi.TabIndex = 76;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblNazivKnjige
            // 
            this.lblNazivKnjige.AutoSize = true;
            this.lblNazivKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivKnjige.Location = new System.Drawing.Point(178, 54);
            this.lblNazivKnjige.Name = "lblNazivKnjige";
            this.lblNazivKnjige.Size = new System.Drawing.Size(91, 18);
            this.lblNazivKnjige.TabIndex = 75;
            this.lblNazivKnjige.Text = "Naziv knjige:";
            // 
            // txtNazivKnjige
            // 
            this.txtNazivKnjige.Location = new System.Drawing.Point(275, 52);
            this.txtNazivKnjige.Name = "txtNazivKnjige";
            this.txtNazivKnjige.Size = new System.Drawing.Size(153, 20);
            this.txtNazivKnjige.TabIndex = 74;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(582, 48);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(80, 30);
            this.btnIzlaz.TabIndex = 73;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKnjigaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.lokacijaKnjigeDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.godinaIzdavanjaDataGridViewTextBoxColumn,
            this.izdavacDataGridViewTextBoxColumn,
            this.zanrDataGridViewTextBoxColumn,
            this.autorKnjigeDataGridViewTextBoxColumn,
            this.izdavac1DataGridViewTextBoxColumn,
            this.zanr1DataGridViewTextBoxColumn,
            this.lokacijaKnjige1DataGridViewTextBoxColumn,
            this.posudbaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.knjigaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 363);
            this.dataGridView1.TabIndex = 84;
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
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // lokacijaKnjigeDataGridViewTextBoxColumn
            // 
            this.lokacijaKnjigeDataGridViewTextBoxColumn.DataPropertyName = "lokacijaKnjige";
            this.lokacijaKnjigeDataGridViewTextBoxColumn.HeaderText = "Lokacija knjige";
            this.lokacijaKnjigeDataGridViewTextBoxColumn.Name = "lokacijaKnjigeDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kat";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "idKnjiga";
            this.Column2.HeaderText = "Odjeljak";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "idKnjiga";
            this.Column3.HeaderText = "Stalaža";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "idKnjiga";
            this.Column4.HeaderText = "Polica";
            this.Column4.Name = "Column4";
            // 
            // godinaIzdavanjaDataGridViewTextBoxColumn
            // 
            this.godinaIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "godinaIzdavanja";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.HeaderText = "Godina izdavanja";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.Name = "godinaIzdavanjaDataGridViewTextBoxColumn";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // izdavacDataGridViewTextBoxColumn
            // 
            this.izdavacDataGridViewTextBoxColumn.DataPropertyName = "izdavac";
            this.izdavacDataGridViewTextBoxColumn.HeaderText = "Izdavač";
            this.izdavacDataGridViewTextBoxColumn.Name = "izdavacDataGridViewTextBoxColumn";
            this.izdavacDataGridViewTextBoxColumn.Visible = false;
            // 
            // zanrDataGridViewTextBoxColumn
            // 
            this.zanrDataGridViewTextBoxColumn.DataPropertyName = "zanr";
            this.zanrDataGridViewTextBoxColumn.HeaderText = "Žanr";
            this.zanrDataGridViewTextBoxColumn.Name = "zanrDataGridViewTextBoxColumn";
            this.zanrDataGridViewTextBoxColumn.Visible = false;
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
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataSource = typeof(Knjižnica.knjiga);
            // 
            // FrmKnjigaPoNazivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblNazivKnjige);
            this.Controls.Add(this.txtNazivKnjige);
            this.Controls.Add(this.btnIzlaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKnjigaPoNazivu";
            this.Text = "Pretraživanje lokacije knjige prema nazivu knjige";
            this.Load += new System.EventHandler(this.FrmKnjigaPoNazivu_Load);
            this.Shown += new System.EventHandler(this.FrmKnjigaPoNazivu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnPretrazi;
        internal System.Windows.Forms.Label lblNazivKnjige;
        internal System.Windows.Forms.TextBox txtNazivKnjige;
        internal System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKnjigaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijaKnjigeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdavacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorKnjigeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdavac1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijaKnjige1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posudbaDataGridViewTextBoxColumn;

    }
}