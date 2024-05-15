using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279757.Models
{
    public class Item:BaseEntity
    {
        public Item() { }
        public Item(string name, decimal price, int stock, int customerId)
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.CustomerId = customerId;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CustomerId { get; set; }
    }
}
