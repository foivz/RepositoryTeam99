﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Knjižnica
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class piBazaEntities : DbContext
    {
        public piBazaEntities()
            : base("name=piBazaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<autor> autor { get; set; }
        public DbSet<autorKnjige> autorKnjige { get; set; }
        public DbSet<clanarina> clanarina { get; set; }
        public DbSet<izdavac> izdavac { get; set; }
        public DbSet<knjiga> knjiga { get; set; }
        public DbSet<korisnik> korisnik { get; set; }
        public DbSet<lokacijaKnjige> lokacijaKnjige { get; set; }
        public DbSet<posudivanje> posudba { get; set; }
        public DbSet<racun> racun { get; set; }
        public DbSet<tipKorisnika> tipKorisnika { get; set; }
        public DbSet<zanr> zanr { get; set; }
    }
}
