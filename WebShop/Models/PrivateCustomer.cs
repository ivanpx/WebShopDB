﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class PrivateCustomer:Customer
    {
        public string MobileNumber { get; set; }
    }
}