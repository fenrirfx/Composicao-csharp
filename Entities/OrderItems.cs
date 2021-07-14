using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao.Entities
{
    class OrderItems
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; } = new Product();

        public OrderItems()
        {

        }
        public OrderItems(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name + ", " + Product.Price + ", Quantity: " + Quantity + ", SubTotal: " + SubTotal());
            return sb.ToString();
        }
    }
}
