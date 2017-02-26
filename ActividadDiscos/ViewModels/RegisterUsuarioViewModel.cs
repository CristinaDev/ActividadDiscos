using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ActividadDiscos.ViewModels
{
    public class RegisterUsuarioViewModel
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Login requerido")]
        public String Login { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        public String ConfirmPassword { get; set; }
    }
}