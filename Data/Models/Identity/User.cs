﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace сoursework.Data.Models.Identity
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
