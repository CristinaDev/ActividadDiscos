using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ActividadDiscos.Models
{
    public class Usuario
    {
        public Usuario()
        {
            this.UsuariosGrupos = new HashSet<UsuarioGrupo>();
        }

        [Key]
        public int IdUsuario { get; set; }
        
        [Required(ErrorMessage = "Login requerido")]
        public String Login { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        public virtual ICollection<UsuarioGrupo> UsuariosGrupos { get; set; }
    }
}