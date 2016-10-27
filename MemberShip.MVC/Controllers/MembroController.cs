using AutoMapper;
using MemberShip.Domain.Entities;
using MemberShip.Domain.Interfaces.Services;
using MemberShip.MVC.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MemberShip.MVC.Controllers
{
    public class MembroController : Controller
    {
        private readonly IMembroServices _membroService;
        private static MapperConfiguration config;
        public MembroController(IMembroServices membroService)
        {
            CriaConfig();
            _membroService = membroService;
        }
        // GET: Membro
        public ActionResult Index()
        {

            return View(config.CreateMapper().Map<IEnumerable<Membro>, IEnumerable<MembroViewModel>>(_membroService.GetAll()));
        }

        // GET: Membro/Details/5
        public ActionResult Details(int id)
        {
            return View(MapearViewModel(_membroService.GetById(id)));
        }

        // GET: Membro/Create
        public ActionResult Create()
        {   var model = new MembroViewModel() { DataNascimento = DateTime.Now, DataEntradada = DateTime.Now };
            //CarregaSelecao(model);
            return View(model);
        }

        // POST: Membro/Create
        [HttpPost]
        public ActionResult Create(MembroViewModel membro)
        {
            try
            {
                _membroService.Add(MapearViewModel(membro));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Membro/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var membro = MapearViewModel(_membroService.GetById(id.Value));
                return View(membro);
            }
            return RedirectToAction("Index");

        }

        // POST: Membro/Edit/5
        [HttpPost]
        public ActionResult Edit(MembroViewModel membro)
        {
            try
            {
                // TODO: Add update logic here
                _membroService.Update(MapearViewModel(membro));
                return RedirectToAction("Index");
            }
            catch
            {
                return View(membro);
            }
        }

        // GET: Membro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Membro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        internal void CriaConfig()
        {
            if (config == null)
            {
                config = new MapperConfiguration(x =>
                {
                    x.CreateMap<Membro, MembroViewModel>();
                    x.CreateMap<MembroViewModel, Membro>();

                });
            }
        }
        internal Membro MapearViewModel(MembroViewModel obj)
        {
            CriaConfig();
            return config.CreateMapper().Map<MembroViewModel, Membro>(obj);
        }

        internal MembroViewModel MapearViewModel(Membro obj)
        {
            CriaConfig();
            return config.CreateMapper().Map<Membro, MembroViewModel>(obj);
        }

        //internal void CarregaSelecao(MembroViewModel model)
        //{

        //    model.Entrada = Enum.GetValues(typeof(TipoEntrada)).Cast<TipoEntrada>().Select(v => new SelectListItem
        //    {
        //        Text = v.ToString(),
        //        Value = ((int)v).ToString()
        //    }).ToList();
        //    //model.Sexos = Enum.GetValues(typeof(Sexo)).Cast<Sexo>().Select(v => new SelectListItem
        //    //{
        //    //    Text = v.ToString(),
        //    //    Value = v.ToString()
        //    //}).ToList();
        //}
    }
}
