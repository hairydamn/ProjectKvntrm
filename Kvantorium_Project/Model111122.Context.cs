﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kvantorium_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Kvantorium_ProjectEntities6 : DbContext
    {
        public Kvantorium_ProjectEntities6()
            : base("name=Kvantorium_ProjectEntities6")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GetOborud> GetOborud { get; set; }
        public virtual DbSet<Postav> Postav { get; set; }
        public virtual DbSet<Sotrud> Sotrud { get; set; }
        public virtual DbSet<UchetPostav> UchetPostav { get; set; }
    }
}