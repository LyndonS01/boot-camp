﻿using System;
using System.Collections.Generic;

namespace PizzaStore.Storing
{
    public partial class Size
    {
        public Size()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
