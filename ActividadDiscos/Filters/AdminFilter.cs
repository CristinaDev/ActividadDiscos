using ActividadDiscos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadDiscos.Filters
{
    public class AdminFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Usuario usuario = null;

            if (filterContext.HttpContext.Session["USUARIO"] is Usuario)
                usuario = filterContext.HttpContext.Session["USUARIO"] as Usuario;

            if(usuario == null || !usuario.UsuariosGrupos.Any(g => g.Grupo.Nombre == "admin"))
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "AuthError"
                };
            }
        }
    }
}