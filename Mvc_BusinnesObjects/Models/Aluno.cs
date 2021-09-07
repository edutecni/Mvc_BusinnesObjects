using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mvc_BusinnesObjects.Models
{
    public class Aluno
    {
        // Validações com DataAnotations
        public int AlunoId { get; set; }        

        [Required(ErrorMessage = "O Nome deve ser informado!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O Nome deve ter no mínimo 5 caracteres!")]
        [Display(Name = "Informe o nome do cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Sexo deve ser informado!")]
        [Display(Name = "Informe o Sexo do cliente")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O Email deve ser informado!")]
        [EmailAddress(ErrorMessage = "Email inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Data de Nascimento deve ser informada!")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }

    }
}
