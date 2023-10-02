using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCC_Final.Models
{
    public class LoginModel
    {
        public required string User {get; set;}
        public required string Password {get; set;}
    }
}