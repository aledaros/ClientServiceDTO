﻿using System;

namespace Gruppo3.ClientiDTO.Domain.Commands
{
    public class ClientUpdateOrder
    {
        public Guid Id { get; set; }
        public int IdCliente { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
