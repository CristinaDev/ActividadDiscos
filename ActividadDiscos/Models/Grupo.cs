using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ActividadDiscos.Models
{
    public class Grupo
    {
        public Grupo()
        {
            this.UsuariosGrupos = new HashSet<UsuarioGrupo>();
        }

        [Key]
        public int IdGrupo { get; set; }
        public String Nombre { get; set; }

        public virtual ICollection<UsuarioGrupo> UsuariosGrupos { get; set; }
    }
}