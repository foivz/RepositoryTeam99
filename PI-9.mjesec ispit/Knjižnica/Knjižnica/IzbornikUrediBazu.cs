using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjižnica
{
    public partial class IzbornikUrediBazu : Form
    {
        public IzbornikUrediBazu()
        {
            InitializeComponent();
        }


        private void IzbornikUrediBazu_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Na događaj "Click"  otvara formu CRUD izdavac
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzdavac</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzdavac_Click(object sender, EventArgs e)
        {
            CRUDIzdavac crud = new CRUDIzdavac();
            crud.MdiParent = this;
            crud.StartPosition = FormStartPosition.Manual;
            crud.Show();
        }
        /// <summary>
        /// Na događaj "Click"  otvara formu CRUD izdavac
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzdavac</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnZanr_Click(object sender, EventArgs e)
        {
            CRUDZanr crud = new CRUDZanr();
            crud.MdiParent = this;
            crud.StartPosition = FormStartPosition.Manual;
            crud.Show();
        }
        /// <summary>
        /// Na događaj "Click"  otvara formu CRUD lokacija
        /// </summary>
        /// <param name="sender">Referenca na gumb btnLokacij</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnLokacija_Click(object sender, EventArgs e)
        {
            CRUDLokacija crud = new CRUDLokacija();
            crud.MdiParent = this;
            crud.StartPosition = FormStartPosition.Manual;
            crud.Show();
        }
        /// <summary>
        /// Na događaj "Click"  otvara formu CRUD Autor
        /// </summary>
        /// <param name="sender">Referenca na gumb btnAutor</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnAutor_Click(object sender, EventArgs e)
        {
            CRUDAutor crud = new CRUDAutor();
            crud.MdiParent = this;
            crud.StartPosition = FormStartPosition.Manual;
            crud.Show();
        }
        /// <summary>
        /// Na događaj "Click"  otvara formu CRUD Posudba
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosudba</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPosudba_Click(object sender, EventArgs e)
        {
            CRUDPosudba crud = new CRUDPosudba();
            crud.MdiParent = this;
            crud.StartPosition = FormStartPosition.Manual;
            crud.Show();
        }
        /// <summary>
        /// Na događaj "Click"  otvara formu CRUD Clanarina
        /// </summary>
        /// <param name="sender">Referenca na gumb btnClanarina</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnClanarina_Click(object sender, EventArgs e)
        {
            CRUDClanarina crud = new CRUDClanarina();
            crud.MdiParent = this;
            crud.StartPosition = FormStartPosition.Manual;
            crud.Show();
           
            crud.Show();
        }
        /// <summary>
        /// Na događaj "Click"  otvara formu CRUD Korisici
        /// </summary>
        /// <param name="sender">Referenca na gumb btnKorisici</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnKorisici_Click(object sender, EventArgs e)
        {
            CRUDKorisnik crud = new CRUDKorisnik();
            crud.MdiParent = this;
            crud.StartPosition = FormStartPosition.Manual;
            crud.Show();
        }
        /// <summary>
        /// Na događaj "Click"  otvara formu CRUD Knjige
        /// </summary>
        /// <param name="sender">Referenca na gumb btnKnjige</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnKnjige_Click(object sender, EventArgs e)
        {
            CRUDKnjiga crud = new CRUDKnjiga();
            crud.MdiParent = this;
            crud.StartPosition = FormStartPosition.Manual;
            crud.Show();
        }
        /// <summary>
        /// Na događaj "Click"  zatvara izbornik "IzbornikUrediBazu"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Na događaj "Click"  otvara formu CRUD Racun
        /// </summary>
        /// <param name="sender">Referenca na gumb btnRacun</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnRacun_Click(object sender, EventArgs e)
        {
            CRUDRacun crud = new CRUDRacun();
            crud.MdiParent = this;
            crud.StartPosition = FormStartPosition.Manual;
            crud.Show();
        }

    }


    
}
