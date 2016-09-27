using MemberShip.Domain.Entities;
using MemberShip.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberShip.Domain.Interfaces.Repositories;
using MemberShip.Domain.Interfaces;

namespace MemberShip.Domain.Services
{
    public class MembroService : Service<Membro>, IMembroServices
    {
        public MembroService(IMembroRepository clienteRepository,IUnitOfWork uow) : base(clienteRepository,uow)
        {
        }
    }
}
