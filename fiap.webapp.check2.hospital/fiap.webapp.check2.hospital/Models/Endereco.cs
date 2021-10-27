using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
    }
}
