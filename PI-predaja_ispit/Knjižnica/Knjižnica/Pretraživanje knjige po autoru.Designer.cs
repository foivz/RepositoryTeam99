namespace Knjižnica
{
    partial class FrmKnjigaPoAutoru
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
            this.idzapisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjiga1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorKnjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblAutorKnjige = new System.Windows.Forms.Label();
            this.txtAutorKnjige = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorKnjigeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzapisaDataGridViewTextBoxColumn,
            this.knjigaDataGridViewTextBoxColumn,
            this.Column1,
            this.autorDataGridViewTextBoxColumn,
            this.Column2,
            this.autor1DataGridViewTextBoxColumn,
            this.knjiga1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autorKnjigeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 363);
            this.dataGridView1.TabIndex = 74;
            // 
            // idzapisaDataGridViewTextBoxColumn
            // 
            this.idzapisaDataGridViewTextBoxColumn.DataPropertyName = "id_zapisa";
            this.idzapisaDataGridViewTextBoxColumn.HeaderText = "id_zapisa";
            this.idzapisaDataGridViewTextBoxColumn.Name = "idzapisaDataGridViewTextBoxColumn";
            // 
            // knjigaDataGridViewTextBoxColumn
            // 
            this.knjigaDataGridViewTextBoxColumn.DataPropertyName = "knjiga";
            this.knjigaDataGridViewTextBoxColumn.HeaderText = "knjiga";
            this.knjigaDataGridViewTextBoxColumn.Name = "knjigaDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // autor1DataGridViewTextBoxColumn
            // 
            this.autor1DataGridViewTextBoxColumn.DataPropertyName = "autor1";
            this.autor1DataGridViewTextBoxColumn.HeaderText = "autor1";
            this.autor1DataGridViewTextBoxColumn.Name = "autor1DataGridViewTextBoxColumn";
            this.autor1DataGridViewTextBoxColumn.Visible = false;
            // 
            // knjiga1DataGridViewTextBoxColumn
            // 
            this.knjiga1DataGridViewTextBoxColumn.DataPropertyName = "knjiga1";
            this.knjiga1DataGridViewTextBoxColumn.HeaderText = "knjiga1";
            this.knjiga1DataGridViewTextBoxColumn.Name = "knjiga1DataGridViewTextBoxColumn";
            this.knjiga1DataGridViewTextBoxColumn.Visible = false;
            // 
            // autorKnjigeBindingSource
            // 
            this.autorKnjigeBindingSource.DataSource = typeof(Knjižnica.autorKnjige);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(441, 43);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(80, 30);
            this.btnPretrazi.TabIndex = 73;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblAutorKnjige
            // 
            this.lblAutorKnjige.AutoSize = true;
            this.lblAutorKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAutorKnjige.Location = new System.Drawing.Point(144, 49);
            this.lblAutorKnjige.Name = "lblAutorKnjige";
            this.lblAutorKnjige.Size = new System.Drawing.Size(89, 18);
            this.lblAutorKnjige.TabIndex = 72;
            this.lblAutorKnjige.Text = "Autor knjige:";
            // 
            // txtAutorKnjige
            // 
            this.txtAutorKnjige.Location = new System.Drawing.Point(239, 50);
            this.txtAutorKnjige.Name = "txtAutorKnjige";
            this.txtAutorKnjige.Size = new System.Drawing.Size(153, 20);
            this.txtAutorKnjige.TabIndex = 71;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(540, 43);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(80, 30);
            this.btnIzlaz.TabIndex = 70;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // FrmKnjigaPoAutoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblAutorKnjige);
            this.Controls.Add(this.txtAutorKnjige);
            this.Controls.Add(this.btnIzlaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKnjigaPoAutoru";
            this.Text = "Pretraživanje knjige po autoru";
            this.Shown += new System.EventHandler(this.FrmKnjigaPoAutoru_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorKnjigeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnPretrazi;
        internal System.Windows.Forms.Label lblAutorKnjige;
        internal System.Windows.Forms.TextBox txtAutorKnjige;
        internal System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.BindingSource autorKnjigeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzapisaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjigaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjiga1DataGridViewTextBoxColumn;

    }
}