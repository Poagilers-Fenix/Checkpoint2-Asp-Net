using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public Hospital Hospital { get; set; }
        public ICollection<Doenca> Doencas { get; set; }
    }
}
