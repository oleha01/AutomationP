﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Library.Models
{
    public class PointOfSale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EnterpriseId { get; set; }
        virtual public Enterprise Enterprise { get; set; }
    }
}