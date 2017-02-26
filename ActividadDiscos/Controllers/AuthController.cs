using ActividadDiscos.BusinessAccessLayer;
using ActividadDiscos.DataAccessLayer;
using ActividadDiscos.Models;
using ActividadDiscos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ActividadDiscos.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario u)
        {
            if(ModelState.IsValid)
            {
                UsuariosBusiness bal = new UsuariosBusiness();
                Usuario authUser = bal.IsAuthenticated(u);

                if(authUser != null)
                {
                    FormsAuthentication.SetAuthCookie(authUser.Login, false);
                    Session["USUARIO"] = authUser;

                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ModelState.AddModelError("CredentialError", "Usuario y contraseña incorrectos.");

                    return View();
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["USUARIO"] = null;

            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterUsuarioViewModel vu)
        {
            if(ModelState.IsValid)
            {
                UsuariosBusiness bal = new UsuariosBusiness();
                Usuario usuario = new Usuario();

                usuario.Login = vu.Login;
                usuario.Password = vu.Password;

                if(bal.Insert(usuario) != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("CredentialError", "Asegúrese de que los datos son correctos");

                return View();
            }

            return View();
        }
    }
}