using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCC_Final.Models
{
    public class UserRedSenhaModel
    {
        public required string Email {get; set;}
        public required string Password {get; set;}
        public required string RPassword {get; set;}
    }
}