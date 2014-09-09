namespace Knjižnica
{
    partial class FrmKnjigaPoZanru
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.zanrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblZanrKnjige = new System.Windows.Forms.Label();
            this.txtNazivŽanra = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.idZanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKnjigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdavacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZanrDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.zanrBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 113);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(751, 176);
            this.dataGridView2.TabIndex = 77;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // zanrBindingSource
            // 
            this.zanrBindingSource.DataSource = typeof(Knjižnica.zanr);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKnjigaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn1,
            this.godinaIzdavanjaDataGridViewTextBoxColumn,
            this.izdavacDataGridViewTextBoxColumn,
            this.zanrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.knjigaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 176);
            this.dataGridView1.TabIndex = 76;
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataSource = typeof(Knjižnica.knjiga);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(462, 47);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(80, 30);
            this.btnPretrazi.TabIndex = 75;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblZanrKnjige
            // 
            this.lblZanrKnjige.AutoSize = true;
            this.lblZanrKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZanrKnjige.Location = new System.Drawing.Point(170, 53);
            this.lblZanrKnjige.Name = "lblZanrKnjige";
            this.lblZanrKnjige.Size = new System.Drawing.Size(90, 18);
            this.lblZanrKnjige.TabIndex = 74;
            this.lblZanrKnjige.Text = "Naziv žanra:";
            // 
            // txtNazivŽanra
            // 
            this.txtNazivŽanra.Location = new System.Drawing.Point(274, 54);
            this.txtNazivŽanra.Name = "txtNazivŽanra";
            this.txtNazivŽanra.Size = new System.Drawing.Size(153, 20);
            this.txtNazivŽanra.TabIndex = 73;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(561, 47);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(80, 30);
            this.btnIzlaz.TabIndex = 72;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // idZanrDataGridViewTextBoxColumn
            // 
            this.idZanrDataGridViewTextBoxColumn.DataPropertyName = "idZanr";
            this.idZanrDataGridViewTextBoxColumn.HeaderText = "Šifra žanra";
            this.idZanrDataGridViewTextBoxColumn.Name = "idZanrDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv žanra";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // idKnjigaDataGridViewTextBoxColumn
            // 
            this.idKnjigaDataGridViewTextBoxColumn.DataPropertyName = "idKnjiga";
            this.idKnjigaDataGridViewTextBoxColumn.HeaderText = "Šifra knjige";
            this.idKnjigaDataGridViewTextBoxColumn.Name = "idKnjigaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv ";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // godinaIzdavanjaDataGridViewTextBoxColumn
            // 
            this.godinaIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "godinaIzdavanja";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.HeaderText = "Godina izdavanja";
            this.godinaIzdavanjaDataGridViewTextBoxColumn.Name = "godinaIzdavanjaDataGridViewTextBoxColumn";
            // 
            // izdavacDataGridViewTextBoxColumn
            // 
            this.izdavacDataGridViewTextBoxColumn.DataPropertyName = "izdavac";
            this.izdavacDataGridViewTextBoxColumn.HeaderText = "Izdavač";
            this.izdavacDataGridViewTextBoxColumn.Name = "izdavacDataGridViewTextBoxColumn";
            // 
            // zanrDataGridViewTextBoxColumn
            // 
            this.zanrDataGridViewTextBoxColumn.DataPropertyName = "zanr";
            this.zanrDataGridViewTextBoxColumn.HeaderText = "Žanr";
            this.zanrDataGridViewTextBoxColumn.Name = "zanrDataGridViewTextBoxColumn";
            this.zanrDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmKnjigaPoZanru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblZanrKnjige);
            this.Controls.Add(this.txtNazivŽanra);
            this.Controls.Add(this.btnIzlaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKnjigaPoZanru";
            this.Text = "Pretraživanje knjige po žanru";
            this.Load += new System.EventHandler(this.FrmKnjigaPoZanru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnPretrazi;
        internal System.Windows.Forms.Label lblZanrKnjige;
        internal System.Windows.Forms.TextBox txtNazivŽanra;
        internal System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.BindingSource zanrBindingSource;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKnjigaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdavacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrDataGridViewTextBoxColumn;

    }
}