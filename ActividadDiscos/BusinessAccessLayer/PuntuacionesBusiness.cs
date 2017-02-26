using ActividadDiscos.DataAccessLayer;
using ActividadDiscos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActividadDiscos.BusinessAccessLayer
{
    public class PuntuacionesBusiness
    {
        public List<Puntuacion> Get(int Id)
        {
            List<Puntuacion> puntuaciones = new List<Puntuacion>();

            using (DiscosDAL context = new DiscosDAL())
            {
                puntuaciones = context.Puntuaciones
                                        .Include("Disco")
                                        .Where(p => p.IdCliente == Id).ToList();
            }

            return puntuaciones;
        }
    }
}