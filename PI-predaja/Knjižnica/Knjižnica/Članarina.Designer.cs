namespace Knjižnica
{
    partial class FrmClanarina
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clanarinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piBazaDataSet = new Knjižnica.piBazaDataSet();
            this.cmbKorisnickoIme = new System.Windows.Forms.ComboBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblDatumIsteka = new System.Windows.Forms.Label();
            this.lblDatumPlacanja = new System.Windows.Forms.Label();
            this.lblNazivKor = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNazivKor = new System.Windows.Forms.TextBox();
            this.dtpDatumPlacanja = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumIsteka = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clanarinaTableAdapter = new Knjižnica.piBazaDataSetTableAdapters.clanarinaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piBazaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // clanarinaBindingSource
            // 
            this.clanarinaBindingSource.DataMember = "clanarina";
            this.clanarinaBindingSource.DataSource = this.piBazaDataSet;
            // 
            // piBazaDataSet
            // 
            this.piBazaDataSet.DataSetName = "piBazaDataSet";
            this.piBazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKorisnickoIme
            // 
            this.cmbKorisnickoIme.FormattingEnabled = true;
            this.cmbKorisnickoIme.Location = new System.Drawing.Point(186, 50);
            this.cmbKorisnickoIme.Name = "cmbKorisnickoIme";
            this.cmbKorisnickoIme.Size = new System.Drawing.Size(153, 21);
            this.cmbKorisnickoIme.TabIndex = 118;
            this.cmbKorisnickoIme.SelectedIndexChanged += new System.EventHandler(this.cmbKorisnickoIme_SelectedIndexChanged);
            this.cmbKorisnickoIme.SelectedValueChanged += new System.EventHandler(this.cmbKorisnickoIme_SelectedValueChanged);
            this.cmbKorisnickoIme.Click += new System.EventHandler(this.cmbKorisnickoIme_Click);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(27, 51);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(99, 17);
            this.lblKorisnickoIme.TabIndex = 115;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(179, 221);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(88, 30);
            this.btnIzlaz.TabIndex = 114;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.Transparent;
            this.btnPosalji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPosalji.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPosalji.FlatAppearance.BorderSize = 0;
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosalji.Location = new System.Drawing.Point(273, 221);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(88, 30);
            this.btnPosalji.TabIndex = 113;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCijena.Location = new System.Drawing.Point(69, 196);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(47, 17);
            this.lblCijena.TabIndex = 112;
            this.lblCijena.Text = "Cijena";
            // 
            // lblDatumIsteka
            // 
            this.lblDatumIsteka.AutoSize = true;
            this.lblDatumIsteka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumIsteka.Location = new System.Drawing.Point(69, 170);
            this.lblDatumIsteka.Name = "lblDatumIsteka";
            this.lblDatumIsteka.Size = new System.Drawing.Size(90, 17);
            this.lblDatumIsteka.TabIndex = 111;
            this.lblDatumIsteka.Text = "Datum isteka";
            // 
            // lblDatumPlacanja
            // 
            this.lblDatumPlacanja.AutoSize = true;
            this.lblDatumPlacanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumPlacanja.Location = new System.Drawing.Point(69, 144);
            this.lblDatumPlacanja.Name = "lblDatumPlacanja";
            this.lblDatumPlacanja.Size = new System.Drawing.Size(106, 17);
            this.lblDatumPlacanja.TabIndex = 110;
            this.lblDatumPlacanja.Text = "Datum plaćanja";
            // 
            // lblNazivKor
            // 
            this.lblNazivKor.AutoSize = true;
            this.lblNazivKor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivKor.Location = new System.Drawing.Point(69, 117);
            this.lblNazivKor.Name = "lblNazivKor";
            this.lblNazivKor.Size = new System.Drawing.Size(103, 17);
            this.lblNazivKor.TabIndex = 108;
            this.lblNazivKor.Text = "Naziv korisnika";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(225, 195);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(153, 20);
            this.txtCijena.TabIndex = 106;
            // 
            // txtNazivKor
            // 
            this.txtNazivKor.Location = new System.Drawing.Point(225, 117);
            this.txtNazivKor.Name = "txtNazivKor";
            this.txtNazivKor.Size = new System.Drawing.Size(153, 20);
            this.txtNazivKor.TabIndex = 119;
            // 
            // dtpDatumPlacanja
            // 
            this.dtpDatumPlacanja.Location = new System.Drawing.Point(225, 144);
            this.dtpDatumPlacanja.Name = "dtpDatumPlacanja";
            this.dtpDatumPlacanja.Size = new System.Drawing.Size(153, 20);
            this.dtpDatumPlacanja.TabIndex = 120;
            // 
            // dtpDatumIsteka
            // 
            this.dtpDatumIsteka.Location = new System.Drawing.Point(225, 171);
            this.dtpDatumIsteka.Name = "dtpDatumIsteka";
            this.dtpDatumIsteka.Size = new System.Drawing.Size(153, 20);
            this.dtpDatumIsteka.TabIndex = 121;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clanarinaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Knjižnica.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 257);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(441, 157);
            this.reportViewer1.TabIndex = 122;
            // 
            // clanarinaTableAdapter
            // 
            this.clanarinaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmClanarina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 431);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtpDatumIsteka);
            this.Controls.Add(this.dtpDatumPlacanja);
            this.Controls.Add(this.txtNazivKor);
            this.Controls.Add(this.cmbKorisnickoIme);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblDatumIsteka);
            this.Controls.Add(this.lblDatumPlacanja);
            this.Controls.Add(this.lblNazivKor);
            this.Controls.Add(this.txtCijena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmClanarina";
            this.Text = "Članarina";
            this.Load += new System.EventHandler(this.FrmClanarina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piBazaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbKorisnickoIme;
        internal System.Windows.Forms.Label lblKorisnickoIme;
        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Button btnPosalji;
        internal System.Windows.Forms.Label lblCijena;
        internal System.Windows.Forms.Label lblDatumIsteka;
        internal System.Windows.Forms.Label lblDatumPlacanja;
        internal System.Windows.Forms.Label lblNazivKor;
        internal System.Windows.Forms.TextBox txtCijena;
        internal System.Windows.Forms.TextBox txtNazivKor;
        private System.Windows.Forms.DateTimePicker dtpDatumPlacanja;
        private System.Windows.Forms.DateTimePicker dtpDatumIsteka;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clanarinaBindingSource;
        private piBazaDataSet piBazaDataSet;
        private piBazaDataSetTableAdapters.clanarinaTableAdapter clanarinaTableAdapter;

    }
}