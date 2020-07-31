using System;
using System.Collections.Generic;

namespace PizzaStore.Storing
{
    public partial class Orders
    {
        public Orders()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public int PizzaId { get; set; }
        public bool? Active { get; set; }

        public virtual Stores Store { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
