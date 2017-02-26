using ActividadDiscos.BusinessAccessLayer;
using ActividadDiscos.Models;
using ActividadDiscos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadDiscos.Controllers
{
    public class InterpretesController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<InterpretesViewModel> vm = new List<InterpretesViewModel>();
            InterpretesBusiness bal = new InterpretesBusiness();

            InterpretesViewModel ivm;

            foreach(var item in bal.Get())
            {
                ivm = new InterpretesViewModel();

                ivm.IdInterprete = item.IdInterprete;
                ivm.Interprete1 = item.Interprete1;

                vm.Add(ivm);
            }

            return View("Index", vm);
        }
    }
}