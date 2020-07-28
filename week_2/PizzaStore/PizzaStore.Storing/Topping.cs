﻿using System;
using System.Collections.Generic;

namespace PizzaStore.Storing
{
    public partial class Topping
    {
        public int ToppingId { get; set; }
        public string ToppingName { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
    }
}
