using MemberShip.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Infra.Data.EntityConfig
{
    public class MembroConfig : EntityTypeConfiguration<Membro>
    {
        public MembroConfig()
        {
            HasKey(x => x.MembroId);
            Property(x => x.Nome).IsRequired().HasMaxLength(200);
            
        }
    }
}
