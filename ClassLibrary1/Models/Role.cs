﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        virtual public List<RoleItem> RoleItems { get; set; }

    }
}
