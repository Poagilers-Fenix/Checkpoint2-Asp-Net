using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Models
{
    public class Hospital
    {
        public int HospitalId { get; set; }



        [MinLength(5, ErrorMessage = "O nome deve ter 5 caracteres ou mais.")]
        [MaxLength(40, ErrorMessage = "O nome do hospital deve ter 40 caracteres ou menos.")]
        [Display(Name = "Qual o nome do hospital?"), Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Nome { get; set; }



        public Endereco Endereco { get; set; }



        [Display(Name = "Qual a capacidade de pacientes?"), Required(ErrorMessage = "Esse campo é obrigatório")]
        [RegularExpression(@"(^[0-9]{0,6})", ErrorMessage = "A capacidade do hospital deve ser somente números, no formato: 1009.")]
        public decimal? Capacidade { get; set; }



        public ICollection<Paciente> Pacientes { get; set; }
    }
}
