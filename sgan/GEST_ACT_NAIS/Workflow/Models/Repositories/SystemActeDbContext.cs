using P7GestAct.Models.DataClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace P7GestAct.Models.Repositories
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class SystemActeDbContext : DbContext
    {
        public SystemActeDbContext()
            : base("systemActeDb")
        {
            this.Configuration.ValidateOnSaveEnabled = false; //mysql
            Database.SetInitializer<SystemActeDbContext>(new SystemActeDbContextInitializer());
        }

        static SystemActeDbContext()//mysql
    {
            DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
    }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //mysql
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Arrondissement> Arrondissements { get; set; }
        public DbSet<Centre> Centres { get; set; }
        public DbSet<Commune> Communes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Declaration> Declarations { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Domicile> Domiciles { get; set; }
        public DbSet<EtatCivil> EtatCivils { get; set; }
        public DbSet<Langue> Langues { get; set; }
        public DbSet<Pere> Peres { get; set; }
        public DbSet<Mere> Meres { get; set; }
        public DbSet<Naissance> Naissances { get; set; }
        public DbSet<Pays> Pays { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}