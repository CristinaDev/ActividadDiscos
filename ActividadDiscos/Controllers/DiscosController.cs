using ActividadDiscos.DataAccessLayer;
using ActividadDiscos.Models;
using ActividadDiscos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadDiscos.Controllers
{
    public class DiscosController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<DiscosViewModel> vm = new List<DiscosViewModel>();
            DiscosViewModel dvm;
            DiscosBusiness bal = new DiscosBusiness();

            int? maxPunt = 0;

            foreach(var item in bal.Get())
            {
                maxPunt = 0;

                dvm = new DiscosViewModel();

                dvm.IdDisco = item.IdDisco;
                dvm.Titulo = item.Titulo;
                dvm.Agno = item.agno;
                dvm.Interprete = item.Interprete.Interprete1;

                foreach (var itemPunt in item.Puntuaciones)
                {
                    maxPunt += itemPunt.PuntuacionVal;
                }

                dvm.PuntuacionMax = maxPunt;

                vm.Add(dvm);
            }

            return View("Index", vm);
        }
    }
}