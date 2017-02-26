using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Web;

namespace ActividadDiscos.Validations.Cliente
{
    public class EmailValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string message = "Email requerido";
            //Regex expression = new Regex("^[a-zA-Z]+[@]{1}[a-zA-Z]+[.]{1}[a-zA-Z]+");

            if(value == null)
            {
                return new ValidationResult(message);
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(value.ToString());

                    return ValidationResult.Success;
                }
                catch(FormatException)
                {
                    return new ValidationResult(message);
                }
            }
        }
    }
}