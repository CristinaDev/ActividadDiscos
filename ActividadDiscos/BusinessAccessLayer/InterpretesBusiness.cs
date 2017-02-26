using ActividadDiscos.DataAccessLayer;
using ActividadDiscos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActividadDiscos.BusinessAccessLayer
{
    public class InterpretesBusiness
    {
        public List<Interprete> Get()
        {
            List<Interprete> interpretes = new List<Interprete>();

            using (DiscosDAL context = new DiscosDAL())
            {
                interpretes = context.Interpretes.ToList();
            }

            return interpretes;
        }
    }
}