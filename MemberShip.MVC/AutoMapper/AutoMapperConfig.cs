using AutoMapper;
using MemberShip.Domain.Entities;
using MemberShip.MVC.Models;

namespace MemberShip.MVC.AutoMapper
{
    public class AutoMapperConfig<TClass,TViewClass> where TClass : class where TViewClass : class
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<Membro, MembroViewModel>();
                x.CreateMap<MembroViewModel, Membro>();

            });
        }
    }
}