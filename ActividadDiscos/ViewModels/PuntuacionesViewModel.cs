using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActividadDiscos.ViewModels
{
    public class PuntuacionesViewModel
    {
        public int Id { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public String TituloDisco { get; set; }
        public Nullable<int> PuntuacionVal { get; set; }
        public Nullable<DateTime> Fecha { get; set; }
    }
}