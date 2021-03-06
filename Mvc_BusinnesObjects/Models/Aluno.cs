using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mvc_BusinnesObjects.Models
{
    public class Aluno
    {
        // Validações com DataAnnotations
        public int AlunoId { get; set; }        

        [Required(ErrorMessage = "O Nome deve ser informado!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O Nome deve ter no mínimo 5 caracteres!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Sexo deve ser informado!")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O Email deve ser informado!")]
        [EmailAddress(ErrorMessage = "Email inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Data de Nascimento deve ser informada!")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Nascimento { get; set; }

        public string Foto { get; set; }
        public string Texto { get; set; }

    }
}
