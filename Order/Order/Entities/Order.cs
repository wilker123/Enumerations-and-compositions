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
        public DateTime Moment { get; set; }
        public OrderStatus status { get; set; }
        public List<Client> client = new List<Client>();
        public List<OrderItem> items = new List<OrderItem>();

    }
}
