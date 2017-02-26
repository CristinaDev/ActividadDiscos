using ActividadDiscos.Validations.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ActividadDiscos.Models
{
    public class Cliente
    {
        public Cliente()
        {
            this.Puntuaciones = new HashSet<Puntuacion>();
        }

        [Key]
        public int Id { get; set; }

        [NombreValidation]
        public String Nombre { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "El Email no es válido")]
        public String Email { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Fecha de nacimiento incorrecta")]
        public Nullable<System.DateTime> FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Fecha de registro requerida")]
        [DataType(DataType.Date, ErrorMessage = "Fecha de registro incorrecta")]
        public Nullable<System.DateTime> FechaRegistro { get; set; }

        public virtual ICollection<Puntuacion> Puntuaciones { get; set; }
    }
}