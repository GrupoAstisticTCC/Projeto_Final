using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace TCC_Final.Models
{
    public class CadastroModel
    {
        public required string User {get; set;}
        public required string Email {get; set;}
        public required string Password {get; set;}
        public required string RPassword {get; set;}
    }
    
}