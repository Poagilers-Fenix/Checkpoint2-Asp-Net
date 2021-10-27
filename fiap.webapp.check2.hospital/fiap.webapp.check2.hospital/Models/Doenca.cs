using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Models
{
    public class Doenca
    {
        public int DoencaId { get; set; }
        public string Nome { get; set; }
        public string Sintomas { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }
    }
}
