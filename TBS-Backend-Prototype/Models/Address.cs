﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TBS_Backend_Prototype.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

    }
}