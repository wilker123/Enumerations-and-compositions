using Order.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Entities
{
    class Order
    {
        OrderItem item;
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<Client> Client = new List<Client>();
        public List<OrderItem> Items = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = Status;
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
                total += i.Price;
            }
            return total;
        }

    }
}
