using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiap.webapp.check2.hospital.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }



        [MinLength(5, ErrorMessage = "O nome da rua deve ter 5 caracteres ou mais.")]
        [MaxLength(40, ErrorMessage = "O nome da rua deve ter 40 caracteres ou menos.")]
        [Display(Name = "Qual o nome da rua?"), Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Rua { get; set; }



        [MinLength(5, ErrorMessage = "O nome do bairro deve ter 5 caracteres ou mais.")]
        [MaxLength(30, ErrorMessage = "O nome do bairro deve ter 40 caracteres ou menos.")]
        [Display(Name = "Qual o nome do bairro?"), Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Bairro { get; set; }



        [MinLength(9, ErrorMessage = "O cep deve ter 8 caracteres.")]
        [MaxLength(9, ErrorMessage = "O cep deve ter 8 caracteres.")]
        [Display(Name = "Qual o cep do endereço?"), Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Cep { get; set; }
    }
}
