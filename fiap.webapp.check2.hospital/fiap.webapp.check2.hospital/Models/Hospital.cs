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
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }

        [Display(Name = "Qual a capacidade de pacientes?")]
        public int Capacidade { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }
    }
}
