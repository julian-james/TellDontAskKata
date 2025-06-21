using System.Collections.Generic;
using System.Net.Sockets;
using TellDontAskKata.Main.Repository;
using TellDontAskKata.Main.UseCase;

namespace TellDontAskKata.Main.Domain
{
    public class Order
    {
        private readonly IProductCatalog _productCatalog;
        public Order(OrderStatus status, TaxOrderItems items, string currency, decimal total, decimal tax, SellItemsRequest request)
        {
            foreach(var itemRequest in request.Requests){
                var product = _productCatalog.GetByName(itemRequest.ProductName);

                if (product == null)
                {
                    throw new UnknownProductException();
                }
                else
                {
                    var orderItem = new OrderItem(product, itemRequest.Quantity);
                    this.Items.Add(orderItem);
                }
            }
            
            Status = status;
            Items = items;
            Currency = currency;
            Total = this.Items.GetTotal;
            Tax = this.Items.GetTax;
        }
        
        public decimal Total { get; set; }
        public string Currency { get; set; }
        public TaxOrderItems Items { get; set; }
        public decimal Tax { get; set; }
        public OrderStatus Status { get; set; }
        public int Id { get; set; }
    }
}
