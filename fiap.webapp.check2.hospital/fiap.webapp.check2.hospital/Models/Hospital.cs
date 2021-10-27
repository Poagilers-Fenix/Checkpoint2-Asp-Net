using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Models
{
    public class Hospital
    {
        public int HospitalId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Capacidade { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }
    }
}
