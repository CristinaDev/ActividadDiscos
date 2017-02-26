using ActividadDiscos.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActividadDiscos.Models
{
    public class DiscosBusiness
    {
        public List<Disco> Get()
        {
            List<Disco> discos = new List<Disco>();

            using (DiscosDAL context = new DiscosDAL())
            {
                discos = context.Discos
                                .Include("Interprete")
                                .Include("Puntuaciones").ToList();
            }

            return discos;
        }
    }
}