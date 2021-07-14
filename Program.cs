using System;
using Composicao.Entities.Enums;
using Composicao.Entities;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Client data: ");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Date of Birth (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(nome, email, date);
            Console.WriteLine("Order Data " + DateTime.Now);
            OrderStatus os = Enum.Parse<OrderStatus>("Processing");
            Console.WriteLine("Status:" + os);
            Console.Write("Enter the number of items to purchase: ");
            int num = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, os, client);
            Product prod = new Product();
            OrderItems request = new OrderItems();

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                string ProdName = Console.ReadLine();
                Console.Write("Product Price: ");
                double ProdPrice = double.Parse(Console.ReadLine());
                Console.Write("Enter Quantity: ");
                int ProdQty = int.Parse(Console.ReadLine());
                prod = new Product(ProdName, ProdPrice);
                request = new OrderItems(ProdQty, ProdPrice, prod);
                order.AddItem(request);
            }
           
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
