using ActividadDiscos.BusinessAccessLayer;
using ActividadDiscos.Filters;
using ActividadDiscos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadDiscos.Controllers
{
    [Authorize]
    public class ClientesController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("GetClientes");
        }

        [HttpGet]
        public ActionResult GetClientes()
        {
            List<ClientesViewModel> vm = new List<ClientesViewModel>();
            ClientesBusiness bal = new ClientesBusiness();
            ClientesViewModel cvm;

            foreach (var item in bal.Get())
            {
                cvm = new ClientesViewModel();

                cvm.Id = item.Id;
                cvm.Nombre = item.Nombre;
                cvm.Email = item.Email;
                cvm.FechaNacimiento = item.FechaNacimiento;
                cvm.FechaRegistro = item.FechaRegistro;

                vm.Add(cvm);
            }

            return View("GetClientes", vm);
        }

        [HttpGet]
        public ActionResult GetPuntuaciones(int Id)
        {
            List<PuntuacionesViewModel> vm = new List<PuntuacionesViewModel>();
            PuntuacionesBusiness bal = new PuntuacionesBusiness();
            PuntuacionesViewModel pvm;

            foreach(var item in bal.Get(Id))
            {
                pvm = new PuntuacionesViewModel();

                pvm.Id = item.Id;
                pvm.IdCliente = item.IdCliente;
                pvm.TituloDisco = item.Disco.Titulo;
                pvm.PuntuacionVal = item.PuntuacionVal;
                pvm.Fecha = item.Fecha;

                vm.Add(pvm);
            }

            return View("GetPuntuaciones", vm);
        }
    }
}