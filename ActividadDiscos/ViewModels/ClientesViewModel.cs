using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActividadDiscos.ViewModels
{
    public class ClientesViewModel
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Email { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    }
}