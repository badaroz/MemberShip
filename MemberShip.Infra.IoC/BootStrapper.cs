using MemberShip.Domain.Interfaces;
using MemberShip.Domain.Interfaces.Repositories;
using MemberShip.Domain.Interfaces.Services;
using MemberShip.Domain.Services;
using MemberShip.Infra.Data.Context;
using MemberShip.Infra.Data.Repositories;
using MemberShip.Infra.Data.UOW;
using SimpleInjector;

namespace MemberShip.Infra.IoC
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<MemberContexto>(Lifestyle.Scoped);
            container.Register<IMembroRepository, MembroRepository>(Lifestyle.Scoped);
            container.Register<IMembroServices, MembroService>(Lifestyle.Scoped);
        }
    }
}
