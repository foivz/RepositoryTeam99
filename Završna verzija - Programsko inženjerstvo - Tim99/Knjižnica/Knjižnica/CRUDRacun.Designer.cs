namespace Knjižnica
{
    partial class CRUDRacun
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
            this.idRacunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanarinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanarina1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblSifraRacuna = new System.Windows.Forms.Label();
            this.txtSifraRacuna = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRacunaDataGridViewTextBoxColumn,
            this.vrijemeIzdavanjaDataGridViewTextBoxColumn,
            this.ukupnaCijenaDataGridViewTextBoxColumn,
            this.clanarinaDataGridViewTextBoxColumn,
            this.clanarina1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.racunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 363);
            this.dataGridView1.TabIndex = 86;
            // 
            // idRacunaDataGridViewTextBoxColumn
            // 
            this.idRacunaDataGridViewTextBoxColumn.DataPropertyName = "idRacuna";
            this.idRacunaDataGridViewTextBoxColumn.HeaderText = "Šifra računa";
            this.idRacunaDataGridViewTextBoxColumn.Name = "idRacunaDataGridViewTextBoxColumn";
            // 
            // vrijemeIzdavanjaDataGridViewTextBoxColumn
            // 
            this.vrijemeIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "vrijemeIzdavanja";
            this.vrijemeIzdavanjaDataGridViewTextBoxColumn.HeaderText = "Vrijeme izdavanja";
            this.vrijemeIzdavanjaDataGridViewTextBoxColumn.Name = "vrijemeIzdavanjaDataGridViewTextBoxColumn";
            // 
            // ukupnaCijenaDataGridViewTextBoxColumn
            // 
            this.ukupnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "ukupnaCijena";
            this.ukupnaCijenaDataGridViewTextBoxColumn.HeaderText = "Ukupna cijena";
            this.ukupnaCijenaDataGridViewTextBoxColumn.Name = "ukupnaCijenaDataGridViewTextBoxColumn";
            // 
            // clanarinaDataGridViewTextBoxColumn
            // 
            this.clanarinaDataGridViewTextBoxColumn.DataPropertyName = "clanarina";
            this.clanarinaDataGridViewTextBoxColumn.HeaderText = "Članarina";
            this.clanarinaDataGridViewTextBoxColumn.Name = "clanarinaDataGridViewTextBoxColumn";
            // 
            // clanarina1DataGridViewTextBoxColumn
            // 
            this.clanarina1DataGridViewTextBoxColumn.DataPropertyName = "clanarina1";
            this.clanarina1DataGridViewTextBoxColumn.HeaderText = "clanarina1";
            this.clanarina1DataGridViewTextBoxColumn.Name = "clanarina1DataGridViewTextBoxColumn";
            this.clanarina1DataGridViewTextBoxColumn.Visible = false;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataSource = typeof(Knjižnica.racun);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(465, 50);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(80, 30);
            this.btnPretrazi.TabIndex = 96;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblSifraRacuna
            // 
            this.lblSifraRacuna.AutoSize = true;
            this.lblSifraRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifraRacuna.Location = new System.Drawing.Point(158, 53);
            this.lblSifraRacuna.Name = "lblSifraRacuna";
            this.lblSifraRacuna.Size = new System.Drawing.Size(91, 18);
            this.lblSifraRacuna.TabIndex = 95;
            this.lblSifraRacuna.Text = "Sifra racuna:";
            // 
            // txtSifraRacuna
            // 
            this.txtSifraRacuna.Location = new System.Drawing.Point(275, 54);
            this.txtSifraRacuna.Name = "txtSifraRacuna";
            this.txtSifraRacuna.Size = new System.Drawing.Size(153, 20);
            this.txtSifraRacuna.TabIndex = 94;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(658, 84);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(80, 30);
            this.btnIzlaz.TabIndex = 93;
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
            this.btnAzuriraj.TabIndex = 98;
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
            this.btnObrisi.TabIndex = 97;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // CRUDRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblSifraRacuna);
            this.Controls.Add(this.txtSifraRacuna);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDRacun";
            this.Text = "CRUDRacun";
            this.Load += new System.EventHandler(this.CRUDRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnPretrazi;
        internal System.Windows.Forms.Label lblSifraRacuna;
        internal System.Windows.Forms.TextBox txtSifraRacuna;
        internal System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRacunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanarinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanarina1DataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button btnAzuriraj;
        internal System.Windows.Forms.Button btnObrisi;
    }
}