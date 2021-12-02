﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppo3.ClientiDTO.Domain.Events
{
    public class CreateClientEvent
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Piva { get; set; }
        public string Businessname { get; set; }
        public string CF { get; set; }
        public string Address { get; set; }
        public int Year { get; set; }
    }
}
