using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ActividadDiscos.Models
{
    public class Puntuacion
    {
        [Key]
        public int Id { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdDisco { get; set; }

        [Column("Puntuacion")]
        public Nullable<int> PuntuacionVal { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("IdDisco")]
        public virtual Disco Disco { get; set; }
    }
}