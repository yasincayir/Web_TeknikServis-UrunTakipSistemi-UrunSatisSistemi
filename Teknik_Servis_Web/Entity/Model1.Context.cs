﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teknik_Servis_Web.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbTeknikServisEntities : DbContext
    {
        public DbTeknikServisEntities()
            : base("name=DbTeknikServisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblUrunTakip> TblUrunTakip { get; set; }
        public virtual DbSet<TblHakkımızda> TblHakkımızda { get; set; }
        public virtual DbSet<TblUrun> TblUrun { get; set; }
        public virtual DbSet<Tblİletisim> Tblİletisim { get; set; }
    }
}
