namespace Knjižnica
{
    partial class CRUDKnjiga
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
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idKnjigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trenutnaKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.zanrDataGridViewTextBoxColumn,
            this.Column1,
            this.kolicina,
            this.trenutnaKolicina});
            this.dataGridView1.DataSource = this.knjigaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 363);
            this.dataGridView1.TabIndex = 85;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(443, 48);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(80, 30);
            this.btnPretrazi.TabIndex = 92;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblNaslovKnjige
            // 
            this.lblNaslovKnjige.AutoSize = true;
            this.lblNaslovKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovKnjige.Location = new System.Drawing.Point(136, 51);
            this.lblNaslovKnjige.Name = "lblNaslovKnjige";
            this.lblNaslovKnjige.Size = new System.Drawing.Size(91, 18);
            this.lblNaslovKnjige.TabIndex = 91;
            this.lblNaslovKnjige.Text = "Naziv knjige:";
            // 
            // txtNaslovKnjige
            // 
            this.txtNaslovKnjige.Location = new System.Drawing.Point(253, 52);
            this.txtNaslovKnjige.Name = "txtNaslovKnjige";
            this.txtNaslovKnjige.Size = new System.Drawing.Size(153, 20);
            this.txtNaslovKnjige.TabIndex = 90;
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
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv ";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // godinaIzdavanjaDataGridViewTextBoxColumn
            // 
            this.godinaIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "godinaIzdavanja";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.HeaderText = "Godina izdavanja";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.Name = "godinaIzdavanjaDataGridViewTextBoxColumn";
            // 
            // zanrDataGridViewTextBoxColumn
            // 
            this.zanrDataGridViewTextBoxColumn.DataPropertyName = "zanr";
            this.zanrDataGridViewTextBoxColumn.HeaderText = "Šifra žanra";
            this.zanrDataGridViewTextBoxColumn.Name = "zanrDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Žanr";
            this.Column1.Name = "Column1";
            // 
            // kolicina
            // 
            this.kolicina.DataPropertyName = "kolicina";
            this.kolicina.HeaderText = "Kolicina";
            this.kolicina.Name = "kolicina";
            // 
            // trenutnaKolicina
            // 
            this.trenutnaKolicina.DataPropertyName = "trenutnaKolicina";
            this.trenutnaKolicina.HeaderText = "Trenutna kolicina";
            this.trenutnaKolicina.Name = "trenutnaKolicina";
            // 
            // CRUDKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(750, 478);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblNaslovKnjige);
            this.Controls.Add(this.txtNaslovKnjige);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDKnjiga";
            this.Text = "PretrazivanjeKnjige";
            this.Shown += new System.EventHandler(this.CRUDKnjiga_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        internal System.Windows.Forms.Button btnAzuriraj;
        internal System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKnjigaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn trenutnaKolicina;
    }
}