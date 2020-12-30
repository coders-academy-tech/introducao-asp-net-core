using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarGallery.Models
{
    public class Contact
    {

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email não está em um formato correto")]
        public string Email { get; set; }

        [Display(Name = "Mensagem")]
        [Required(ErrorMessage = "Mensagem é obrigatório")]
        [StringLength(500, ErrorMessage = "Máximo permitido são 500 caracteres")]
        public string Message { get; set; }

    }
}
