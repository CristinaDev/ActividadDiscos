using ActividadDiscos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActividadDiscos.ViewModels
{
    public class DiscosViewModel
    {
        public int IdDisco { get; set; }
        public String Titulo { get; set; }
        public Nullable<double> Agno { get; set; }
        public String Interprete { get; set; }
        public Nullable<int> PuntuacionMax { get; set; }
    }
}