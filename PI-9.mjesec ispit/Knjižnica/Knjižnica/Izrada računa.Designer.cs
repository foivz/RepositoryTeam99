namespace Knjižnica
{
    partial class frmIzradaRacuna
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
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piBazaDataSet = new Knjižnica.piBazaDataSet();
            this.cmbSifraClanarine = new System.Windows.Forms.ComboBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.lblSifraClanarine = new System.Windows.Forms.Label();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            this.lblVrijemeIzdavanja = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.racunTableAdapter = new Knjižnica.piBazaDataSetTableAdapters.racunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piBazaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "racun";
            this.racunBindingSource.DataSource = this.piBazaDataSet;
            // 
            // piBazaDataSet
            // 
            this.piBazaDataSet.DataSetName = "piBazaDataSet";
            this.piBazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSifraClanarine
            // 
            this.cmbSifraClanarine.FormattingEnabled = true;
            this.cmbSifraClanarine.Location = new System.Drawing.Point(226, 68);
            this.cmbSifraClanarine.Name = "cmbSifraClanarine";
            this.cmbSifraClanarine.Size = new System.Drawing.Size(153, 21);
            this.cmbSifraClanarine.TabIndex = 124;
            this.cmbSifraClanarine.SelectedIndexChanged += new System.EventHandler(this.cmbSifraClanarine_SelectedIndexChanged);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(319, 161);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(88, 30);
            this.btnIzlaz.TabIndex = 121;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // lblSifraClanarine
            // 
            this.lblSifraClanarine.AutoSize = true;
            this.lblSifraClanarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSifraClanarine.Location = new System.Drawing.Point(72, 69);
            this.lblSifraClanarine.Name = "lblSifraClanarine";
            this.lblSifraClanarine.Size = new System.Drawing.Size(99, 17);
            this.lblSifraClanarine.TabIndex = 119;
            this.lblSifraClanarine.Text = "Šifra članarine";
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUkupnaCijena.Location = new System.Drawing.Point(72, 121);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(98, 17);
            this.lblUkupnaCijena.TabIndex = 117;
            this.lblUkupnaCijena.Text = "Ukupna cijena";
            // 
            // lblVrijemeIzdavanja
            // 
            this.lblVrijemeIzdavanja.AutoSize = true;
            this.lblVrijemeIzdavanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVrijemeIzdavanja.Location = new System.Drawing.Point(72, 95);
            this.lblVrijemeIzdavanja.Name = "lblVrijemeIzdavanja";
            this.lblVrijemeIzdavanja.Size = new System.Drawing.Size(119, 17);
            this.lblVrijemeIzdavanja.TabIndex = 116;
            this.lblVrijemeIzdavanja.Text = "Vrijeme izdavanja";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(226, 120);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(153, 20);
            this.txtUkupnaCijena.TabIndex = 112;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 125;
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.Transparent;
            this.btnPosalji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPosalji.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPosalji.FlatAppearance.BorderSize = 0;
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosalji.Location = new System.Drawing.Point(225, 161);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(88, 30);
            this.btnPosalji.TabIndex = 126;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // rptViewer
            // 
            reportDataSource1.Name = "dsReport";
            reportDataSource1.Value = this.racunBindingSource;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "Knjižnica.Report1.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(12, 197);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(494, 196);
            this.rptViewer.TabIndex = 127;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // frmIzradaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 407);
            this.Controls.Add(this.rptViewer);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbSifraClanarine);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.lblSifraClanarine);
            this.Controls.Add(this.lblUkupnaCijena);
            this.Controls.Add(this.lblVrijemeIzdavanja);
            this.Controls.Add(this.txtUkupnaCijena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmIzradaRacuna";
            this.Text = "Izrada računa";
            this.Load += new System.EventHandler(this.frmIzradaRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piBazaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbSifraClanarine;
        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Label lblSifraClanarine;
        internal System.Windows.Forms.Label lblUkupnaCijena;
        internal System.Windows.Forms.Label lblVrijemeIzdavanja;
        internal System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Button btnPosalji;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private piBazaDataSet piBazaDataSet;
        private piBazaDataSetTableAdapters.racunTableAdapter racunTableAdapter;

    }
}