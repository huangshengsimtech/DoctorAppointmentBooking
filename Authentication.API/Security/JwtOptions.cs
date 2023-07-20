﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.API.Security
{
    public record JwtOptions
    {
        public static string SectionName = "Jwt";
        public string Issuer { get; set; } = String.Empty;
        public string Secret { get; set; } = String.Empty;
    }
}
