﻿using System;
using System.Collections.Generic;

namespace PizzaStore.Storing
{
    public partial class Crust
    {
        public Crust()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int CrustId { get; set; }
        public string CrustName { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
