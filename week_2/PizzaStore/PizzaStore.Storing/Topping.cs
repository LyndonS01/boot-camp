using System;
using System.Collections.Generic;

namespace PizzaStore.Storing
{
    public partial class Topping
    {
        public Topping()
        {
            PizzaTopping = new HashSet<PizzaTopping>();
        }

        public int ToppingId { get; set; }
        public string ToppingName { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<PizzaTopping> PizzaTopping { get; set; }

    public static implicit operator Topping(PizzaTopping v)
    {
      throw new NotImplementedException();
    }
  }
}
