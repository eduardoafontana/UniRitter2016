using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExzPedidos
{
    public enum OrderStatus
    {
        New,
        Processed,
        InX,
        Delivered,
        Canceled
    }

    public class Orders
    {
        public Guid Id { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }


        private List<Item> items;
        public List<Item> Items
        {
            get
            {
                return items ?? new List<Item>();
            }

            set
            {
                items = value;
            }
        }

    }
}