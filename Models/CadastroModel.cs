using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace TCC_Final.Models
{
    public class CadastroModel
    {
        public string User {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public string RPassword {get; set;}
    }
    
}