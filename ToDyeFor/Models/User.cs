﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDyeFor.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public List<string> Recipes { get; set; }
        
        //public string Picture { get; set; }

        //public string Bio { get; set; }
    }
}
