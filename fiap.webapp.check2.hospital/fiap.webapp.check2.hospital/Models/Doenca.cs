using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Models
{
    public class Doenca
    {
        public int DoencaId { get; set; }



        [MinLength(4, ErrorMessage = "O nome deve ter 4 caracteres ou mais.")]
        [MaxLength(40, ErrorMessage = "O nome da doença deve ter 40 caracteres ou menos.")]
        [Display(Name = "Qual o nome da doença?"), Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Nome { get; set; }



        [MinLength(4, ErrorMessage = "Os sintomas devem ter 4 caracteres ou mais.")]
        [MaxLength(40, ErrorMessage = "Os sintomas devem ter 40 caracteres ou menos.")]
        [Display(Name = "Qual são os sintomas?"), Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Sintomas { get; set; }
        public IList<PacienteDoenca> PacientesDoencas { get; set; }
    }
}
