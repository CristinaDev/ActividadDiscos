using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ActividadDiscos.Models
{
    public class Interprete
    {
        public Interprete()
        {
            this.Discos = new HashSet<Disco>();
        }

        [Key]
        public int IdInterprete { get; set; }

        [Column("Interprete")]
        public String Interprete1 { get; set; }

        public virtual ICollection<Disco> Discos { get; set; }
    }
}