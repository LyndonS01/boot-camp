﻿using System;
using System.Collections.Generic;

namespace PizzaStore.Storing
{
    public partial class Users
    {
        public Users()
        {
            Orders = new HashSet<Orders>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime LastOrderDate { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
