using OrderProject.Entities;
using OrderProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string nameClient = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(nameClient, email, birthDate); 

            Console.WriteLine("-----------------------");

            Console.WriteLine("Enter order data: ");

            DateTime moment =  DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Order order = new Order(moment, status, client); 

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
          
            for(int i = 1; i <= n; i++){
                Console.WriteLine("Enter #" +i+" item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, priceProduct);
                OrderItem item = new OrderItem(quantity, priceProduct,product);
                order.AddItem(item);
            }
        }
    }
}
