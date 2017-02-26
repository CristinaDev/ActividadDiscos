using ActividadDiscos.BusinessAccessLayer;
using ActividadDiscos.DataAccessLayer;
using ActividadDiscos.Filters;
using ActividadDiscos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadDiscos.Controllers
{
    [Authorize]
    [AdminFilter]
    public class AdminController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCustomer(Cliente cli)
        {
            if(ModelState.IsValid)
            {
                ClientesBusiness bal = new ClientesBusiness();

                if(bal.Insert(cli) != null)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }
    }
}