using MemberShip.Domain.Entities;
using MemberShip.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberShip.Infra.Data.Context;

namespace MemberShip.Infra.Data.Repositories
{
    public class MembroRepository : Repository<Membro>, IMembroRepository
    {
        public MembroRepository(MemberContexto context) : base(context)
        {
        }
    }
}
