﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Char Address { get; set; }
        public int Phonenumber { get; set; }
    }
}
