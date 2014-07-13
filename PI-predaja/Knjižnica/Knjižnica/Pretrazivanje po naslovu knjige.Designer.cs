namespace Knjižnica
{
    partial class FrmKnjigaPoNaslovu
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
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblNaslovKnjige = new System.Windows.Forms.Label();
            this.txtNaslovKnjige = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.idKnjigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.zanr1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.knjigaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 363);
            this.dataGridView1.TabIndex = 83;
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataSource = typeof(Knjižnica.knjiga);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(450, 43);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(80, 30);
            this.btnPretrazi.TabIndex = 82;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblNaslovKnjige
            // 
            this.lblNaslovKnjige.AutoSize = true;
            this.lblNaslovKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovKnjige.Location = new System.Drawing.Point(154, 49);
            this.lblNaslovKnjige.Name = "lblNaslovKnjige";
            this.lblNaslovKnjige.Size = new System.Drawing.Size(100, 18);
            this.lblNaslovKnjige.TabIndex = 81;
            this.lblNaslovKnjige.Text = "Naslov knjige:";
            // 
            // txtNaslovKnjige
            // 
            this.txtNaslovKnjige.Location = new System.Drawing.Point(260, 47);
            this.txtNaslovKnjige.Name = "txtNaslovKnjige";
            this.txtNaslovKnjige.Size = new System.Drawing.Size(153, 20);
            this.txtNaslovKnjige.TabIndex = 80;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(549, 43);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(80, 30);
            this.btnIzlaz.TabIndex = 79;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
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
            // zanr1DataGridViewTextBoxColumn
            // 
            this.zanr1DataGridViewTextBoxColumn.DataPropertyName = "zanr1";
            this.zanr1DataGridViewTextBoxColumn.HeaderText = "zanr1";
            this.zanr1DataGridViewTextBoxColumn.Name = "zanr1DataGridViewTextBoxColumn";
            this.zanr1DataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmKnjigaPoNaslovu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblNaslovKnjige);
            this.Controls.Add(this.txtNaslovKnjige);
            this.Controls.Add(this.btnIzlaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKnjigaPoNaslovu";
            this.Text = "Pretrazivanje po naslovu knjige";
            this.Load += new System.EventHandler(this.FrmKnjigaPoNaslovu_Load);
            this.Shown += new System.EventHandler(this.FrmKnjigaPoNaslovu_Shown);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idKnjigaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanr1DataGridViewTextBoxColumn;
    }
}