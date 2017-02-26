using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ActividadDiscos.Validations.Cliente
{
    public class NombreValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string message = "Nombre requerido";

            if(value == null)
            {
                return new ValidationResult(message);
            }

            return ValidationResult.Success;
        }
    }
}