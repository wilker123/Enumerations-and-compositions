using OrderProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem i in Items)
            {
                total += i.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (" + Client.BirthDate.ToString("dd/MM/yyyy") + ")");
            sb.AppendLine(" - " + Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem i in Items)
            {
                sb.Append(i.Product.Name + ", $");
                sb.Append(i.Price + ", Quantity: ");
                sb.Append(i.Quantity + ", SubTotal: ");
                sb.AppendLine(i.SubTotal().ToString());
            }
            sb.AppendLine(Total().ToString());
            return sb.ToString();
        }

    }
}
