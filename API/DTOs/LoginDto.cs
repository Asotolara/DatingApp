using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace API.DTOs
{
    public class LoginDto
    {
        public string Username{get; set;}

        public string Password{get; set;}
    }
}