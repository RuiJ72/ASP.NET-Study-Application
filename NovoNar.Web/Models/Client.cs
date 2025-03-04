using System;
using System.ComponentModel.DataAnnotations;

namespace NovoNar.Web.Models
{
    public class Client
    {
        public string Name { get; set; }
        public string Age { get; set; }
        
        [Required(ErrorMessage = "CPF is required.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Invalid CPF format. Expected format: 123.456.789-09.")]
        public string Cpf { get; set; }  
        
        public string Sex { get; set; }
    }
}
