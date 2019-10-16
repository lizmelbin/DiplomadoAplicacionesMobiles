﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDiplomado.Models
{
    class CustomerModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string AddressReference { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
