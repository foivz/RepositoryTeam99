namespace Knjižnica
{
    partial class CRUDLokacija
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
            this.idLokacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odjeljakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stalazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijaKnjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.txtPretraziLokaciju = new System.Windows.Forms.TextBox();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaKnjigeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLokacijeDataGridViewTextBoxColumn,
            this.katDataGridViewTextBoxColumn,
            this.odjeljakDataGridViewTextBoxColumn,
            this.stalazaDataGridViewTextBoxColumn,
            this.policaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lokacijaKnjigeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 363);
            this.dataGridView1.TabIndex = 75;
            // 
            // idLokacijeDataGridViewTextBoxColumn
            // 
            this.idLokacijeDataGridViewTextBoxColumn.DataPropertyName = "idLokacije";
            this.idLokacijeDataGridViewTextBoxColumn.HeaderText = "Šifra lokacije";
            this.idLokacijeDataGridViewTextBoxColumn.Name = "idLokacijeDataGridViewTextBoxColumn";
            // 
            // katDataGridViewTextBoxColumn
            // 
            this.katDataGridViewTextBoxColumn.DataPropertyName = "kat";
            this.katDataGridViewTextBoxColumn.HeaderText = "Kat";
            this.katDataGridViewTextBoxColumn.Name = "katDataGridViewTextBoxColumn";
            // 
            // odjeljakDataGridViewTextBoxColumn
            // 
            this.odjeljakDataGridViewTextBoxColumn.DataPropertyName = "odjeljak";
            this.odjeljakDataGridViewTextBoxColumn.HeaderText = "Odjeljak";
            this.odjeljakDataGridViewTextBoxColumn.Name = "odjeljakDataGridViewTextBoxColumn";
            // 
            // stalazaDataGridViewTextBoxColumn
            // 
            this.stalazaDataGridViewTextBoxColumn.DataPropertyName = "stalaza";
            this.stalazaDataGridViewTextBoxColumn.HeaderText = "Stalaza";
            this.stalazaDataGridViewTextBoxColumn.Name = "stalazaDataGridViewTextBoxColumn";
            // 
            // policaDataGridViewTextBoxColumn
            // 
            this.policaDataGridViewTextBoxColumn.DataPropertyName = "polica";
            this.policaDataGridViewTextBoxColumn.HeaderText = "Polica";
            this.policaDataGridViewTextBoxColumn.Name = "policaDataGridViewTextBoxColumn";
            // 
            // lokacijaKnjigeBindingSource
            // 
            this.lokacijaKnjigeBindingSource.DataSource = typeof(Knjižnica.lokacijaKnjige);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(658, 84);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(80, 30);
            this.btnIzlaz.TabIndex = 76;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // txtPretraziLokaciju
            // 
            this.txtPretraziLokaciju.Location = new System.Drawing.Point(274, 56);
            this.txtPretraziLokaciju.Name = "txtPretraziLokaciju";
            this.txtPretraziLokaciju.Size = new System.Drawing.Size(153, 20);
            this.txtPretraziLokaciju.TabIndex = 77;
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLokacija.Location = new System.Drawing.Point(179, 55);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(86, 18);
            this.lblLokacija.TabIndex = 78;
            this.lblLokacija.Text = "Unesite kat:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(476, 49);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(80, 30);
            this.btnPretrazi.TabIndex = 79;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
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
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
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
            // CRUDLokacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.txtPretraziLokaciju);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDLokacija";
            this.Text = "PretrazivanjeLokacija";
            this.Load += new System.EventHandler(this.PretrazivanjeLokacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaKnjigeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.TextBox txtPretraziLokaciju;
        internal System.Windows.Forms.Label lblLokacija;
        internal System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.BindingSource lokacijaKnjigeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLokacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odjeljakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stalazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policaDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button btnAzuriraj;
        internal System.Windows.Forms.Button btnObrisi;
    }
}