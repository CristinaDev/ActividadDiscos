using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ActividadDiscos.Models
{
    public class Disco
    {
        public Disco()
        {
            this.Puntuaciones = new HashSet<Puntuacion>();
            //this.DiscoTipos = new HashSet<DiscoTipo>();
        }

        [Key]
        public int IdDisco { get; set; }
        public String Titulo { get; set; }
        public Nullable<double> agno { get; set; }
        public Nullable<int> IdInterprete { get; set; }

        [ForeignKey("IdInterprete")]
        public virtual Interprete Interprete { get; set; }
        public virtual ICollection<Puntuacion> Puntuaciones { get; set; }
    }
}