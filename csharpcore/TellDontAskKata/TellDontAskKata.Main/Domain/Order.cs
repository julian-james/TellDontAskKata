using System.Collections.Generic;
using System.Net.Sockets;

namespace TellDontAskKata.Main.Domain
{
    public class Order
    {
        public decimal Total { get; set; }
        public string Currency { get; set; }
        public TaxOrderItems Items { get; set; }
        public decimal Tax { get; set; }
        public OrderStatus Status { get; set; }
        public int Id { get; set; }
    }
}
