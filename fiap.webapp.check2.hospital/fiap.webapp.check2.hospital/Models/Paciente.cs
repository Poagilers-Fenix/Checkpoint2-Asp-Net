using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }

        [MinLength(2, ErrorMessage = "O nome do paciente deve ter 2 caracteres ou mais.")]
        [MaxLength(40, ErrorMessage = "O nome do paciente deve ter 40 caracteres ou menos.")]
        [Display(Name = "Qual o nome do paciente?"), Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Nome { get; set; }

        [MinLength(14, ErrorMessage = "O cpf deve ter 11 caracteres.")]
        [MaxLength(14, ErrorMessage = "O cpf deve ter 11 caracteres.")]
        [Display(Name = "Qual o cpf do paciente?"), Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Cpf { get; set; }

        [Display(Name = "Qual o endereço do paciente?"), Required(ErrorMessage = "Esse campo é obrigatório")]
        public Endereco Endereco { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Qual a data de nascimento do paciente?"), Required(ErrorMessage = "Esse campo é obrigatório")]
        public DateTime? DataNascimento { get; set; }
        public int HospitalId { get; set; }
        public IList<PacienteDoenca> PacientesDoencas { get; set; }
    }
}
