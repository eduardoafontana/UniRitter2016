using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExzPedidos
{
    public class Item
    {
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        public decimal Price { get; set; }
    }
}
