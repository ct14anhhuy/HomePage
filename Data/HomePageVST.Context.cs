﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Diagnostics;

    public partial class HomePageVSTEntities : DbContext
    {
        public HomePageVSTEntities()
            : base("name=HomePageVSTEntities")
        {
            Database.Log = s => Debug.WriteLine(s);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Benefit> Benefits { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<HeaderCategory> HeaderCategories { get; set; }
        public virtual DbSet<HeaderDetail> HeaderDetails { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<JobSkill> JobSkills { get; set; }
        public virtual DbSet<Recruitment> Recruitments { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
    }
}
