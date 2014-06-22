namespace Knjižnica
{
    partial class CRUDClanarina
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
            this.dgvClanarina = new System.Windows.Forms.DataGridView();
            this.idClanarinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPlacanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIstekaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanarinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblZanr = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClanarina
            // 
            this.dgvClanarina.AutoGenerateColumns = false;
            this.dgvClanarina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanarina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClanarinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.datumPlacanjaDataGridViewTextBoxColumn,
            this.datumIstekaDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.Column1});
            this.dgvClanarina.DataSource = this.clanarinaBindingSource;
            this.dgvClanarina.Location = new System.Drawing.Point(0, 119);
            this.dgvClanarina.Name = "dgvClanarina";
            this.dgvClanarina.Size = new System.Drawing.Size(751, 363);
            this.dgvClanarina.TabIndex = 78;
            // 
            // idClanarinaDataGridViewTextBoxColumn
            // 
            this.idClanarinaDataGridViewTextBoxColumn.DataPropertyName = "idClanarina";
            this.idClanarinaDataGridViewTextBoxColumn.HeaderText = "Šifra članarine";
            this.idClanarinaDataGridViewTextBoxColumn.Name = "idClanarinaDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // datumPlacanjaDataGridViewTextBoxColumn
            // 
            this.datumPlacanjaDataGridViewTextBoxColumn.DataPropertyName = "datumPlacanja";
            this.datumPlacanjaDataGridViewTextBoxColumn.HeaderText = "Datum plaćanja";
            this.datumPlacanjaDataGridViewTextBoxColumn.Name = "datumPlacanjaDataGridViewTextBoxColumn";
            // 
            // datumIstekaDataGridViewTextBoxColumn
            // 
            this.datumIstekaDataGridViewTextBoxColumn.DataPropertyName = "datumIsteka";
            this.datumIstekaDataGridViewTextBoxColumn.HeaderText = "Datum isteka";
            this.datumIstekaDataGridViewTextBoxColumn.Name = "datumIstekaDataGridViewTextBoxColumn";
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
            // clanarinaBindingSource
            // 
            this.clanarinaBindingSource.DataSource = typeof(Knjižnica.clanarina);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(452, 51);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(80, 30);
            this.btnPretrazi.TabIndex = 85;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZanr.Location = new System.Drawing.Point(93, 58);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(151, 18);
            this.lblZanr.TabIndex = 84;
            this.lblZanr.Text = "Unesi korisnicko ime:";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(260, 58);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(153, 20);
            this.txtKorIme.TabIndex = 83;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(658, 83);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(80, 30);
            this.btnIzlaz.TabIndex = 82;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.Transparent;
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzuriraj.Location = new System.Drawing.Point(658, 48);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(80, 30);
            this.btnAzuriraj.TabIndex = 93;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.Location = new System.Drawing.Point(658, 12);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(80, 30);
            this.btnObrisi.TabIndex = 92;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // CRUDClanarina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dgvClanarina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDClanarina";
            this.Text = "PretrazivanjeClanarine";
            this.Load += new System.EventHandler(this.CRUDClanarina_Load);
            this.Shown += new System.EventHandler(this.CRUDClanarina_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClanarina;
        internal System.Windows.Forms.Button btnPretrazi;
        internal System.Windows.Forms.Label lblZanr;
        internal System.Windows.Forms.TextBox txtKorIme;
        internal System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.BindingSource clanarinaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClanarinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPlacanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIstekaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.Button btnAzuriraj;
        internal System.Windows.Forms.Button btnObrisi;
    }
}