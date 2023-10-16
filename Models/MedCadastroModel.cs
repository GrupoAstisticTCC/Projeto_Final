using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCC_Final.Models
{
    public class MedCadastroModel
    {
        public required string Formacao {get; set;}
        public required string Usuario {get; set;}
        public required string Email {get; set;}
        public required string Password {get; set;}
        public required string Tel {get; set;}
        public required string cep {get; set;}
    }
}