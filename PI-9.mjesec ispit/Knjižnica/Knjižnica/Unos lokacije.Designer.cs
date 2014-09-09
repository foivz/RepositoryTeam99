namespace Knjižnica
{
    partial class FrmUnosLokacije
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
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lblPolica = new System.Windows.Forms.Label();
            this.txtPolica = new System.Windows.Forms.TextBox();
            this.lblStalaza = new System.Windows.Forms.Label();
            this.lblOdjeljak = new System.Windows.Forms.Label();
            this.lblKat = new System.Windows.Forms.Label();
            this.txtStalaza = new System.Windows.Forms.TextBox();
            this.txtOdjeljak = new System.Windows.Forms.TextBox();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(98, 285);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(98, 30);
            this.btnIzlaz.TabIndex = 103;
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
            this.btnPosalji.Location = new System.Drawing.Point(234, 285);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(98, 30);
            this.btnPosalji.TabIndex = 102;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // lblPolica
            // 
            this.lblPolica.AutoSize = true;
            this.lblPolica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPolica.Location = new System.Drawing.Point(85, 215);
            this.lblPolica.Name = "lblPolica";
            this.lblPolica.Size = new System.Drawing.Size(46, 17);
            this.lblPolica.TabIndex = 101;
            this.lblPolica.Text = "Polica";
            // 
            // txtPolica
            // 
            this.txtPolica.Location = new System.Drawing.Point(224, 214);
            this.txtPolica.Name = "txtPolica";
            this.txtPolica.Size = new System.Drawing.Size(128, 20);
            this.txtPolica.TabIndex = 100;
            // 
            // lblStalaza
            // 
            this.lblStalaza.AutoSize = true;
            this.lblStalaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStalaza.Location = new System.Drawing.Point(85, 157);
            this.lblStalaza.Name = "lblStalaza";
            this.lblStalaza.Size = new System.Drawing.Size(55, 17);
            this.lblStalaza.TabIndex = 99;
            this.lblStalaza.Text = "Stalaža";
            // 
            // lblOdjeljak
            // 
            this.lblOdjeljak.AutoSize = true;
            this.lblOdjeljak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdjeljak.Location = new System.Drawing.Point(85, 104);
            this.lblOdjeljak.Name = "lblOdjeljak";
            this.lblOdjeljak.Size = new System.Drawing.Size(59, 17);
            this.lblOdjeljak.TabIndex = 98;
            this.lblOdjeljak.Text = "Odjeljak";
            this.lblOdjeljak.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKat.Location = new System.Drawing.Point(85, 51);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(29, 17);
            this.lblKat.TabIndex = 97;
            this.lblKat.Text = "Kat";
            // 
            // txtStalaza
            // 
            this.txtStalaza.Location = new System.Drawing.Point(224, 156);
            this.txtStalaza.Name = "txtStalaza";
            this.txtStalaza.Size = new System.Drawing.Size(128, 20);
            this.txtStalaza.TabIndex = 96;
            // 
            // txtOdjeljak
            // 
            this.txtOdjeljak.Location = new System.Drawing.Point(224, 103);
            this.txtOdjeljak.Name = "txtOdjeljak";
            this.txtOdjeljak.Size = new System.Drawing.Size(128, 20);
            this.txtOdjeljak.TabIndex = 95;
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(224, 50);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(128, 20);
            this.txtKat.TabIndex = 94;
            // 
            // FrmUnosLokacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 365);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.lblPolica);
            this.Controls.Add(this.txtPolica);
            this.Controls.Add(this.lblStalaza);
            this.Controls.Add(this.lblOdjeljak);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.txtStalaza);
            this.Controls.Add(this.txtOdjeljak);
            this.Controls.Add(this.txtKat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmUnosLokacije";
            this.Text = "Unos lokacije";
            this.Load += new System.EventHandler(this.FrmUnosLokacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnIzlaz;
        internal System.Windows.Forms.Button btnPosalji;
        internal System.Windows.Forms.Label lblPolica;
        internal System.Windows.Forms.TextBox txtPolica;
        internal System.Windows.Forms.Label lblStalaza;
        internal System.Windows.Forms.Label lblOdjeljak;
        internal System.Windows.Forms.Label lblKat;
        internal System.Windows.Forms.TextBox txtStalaza;
        internal System.Windows.Forms.TextBox txtOdjeljak;
        internal System.Windows.Forms.TextBox txtKat;

    }
}