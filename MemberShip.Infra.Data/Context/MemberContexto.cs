using MemberShip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Infra.Data.Context
{
    public class MemberContexto : DbContext

    {
        public MemberContexto()
            : base("DefaultConnection")
        {

        }
        public DbSet<Membro> Membros { get; set; }

        public DbSet<Familia> Familias { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(x => x.Name == x.ReflectedType.Name + "Id")
                .Configure(x => x.IsKey());
            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(200));

        }

        //public override int SaveChanges()
        //{
        //    foreach(var entry in ChangeTracker.Entries().Where(entry=> entry.Entity.GetType))
        //}
    }
}
