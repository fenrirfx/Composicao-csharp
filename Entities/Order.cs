using System;
using System.Collections.Generic;
using System.Text;
using Composicao.Entities.Enums;


namespace Composicao.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItems> Items { get; set; } = new List<OrderItems>();
        public Client client { get; set; }

        public Order()
        {
        }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            this.client = client;
        }

        public void AddItem(OrderItems item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItems item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItems item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine("Order Moment: " + DateTime.Now);
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + client.Name + " (" + client.Date.ToString("dd/MM/yyyy") + ") - " + client.Email);
            sb.AppendLine("Order Items: ");
            foreach (OrderItems item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total Price: $"+Total().ToString());

            return sb.ToString();
        }
    }
}
