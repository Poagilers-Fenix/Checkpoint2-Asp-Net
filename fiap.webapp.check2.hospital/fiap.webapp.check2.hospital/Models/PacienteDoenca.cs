using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Models
{
    
    public class PacienteDoenca
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int DoencaId { get; set; }
        public Doenca Doenca { get; set; }
        
    }
}
