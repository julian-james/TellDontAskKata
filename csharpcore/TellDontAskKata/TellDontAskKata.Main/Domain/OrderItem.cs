using TellDontAskKata.Main.UseCase;

namespace TellDontAskKata.Main.Domain
{
    public class OrderItem
    {
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            TaxedAmount = TaxRounding.Round(product.UnitaryTaxedAmount() * quantity);
            Tax = TaxRounding.Round(product.UnitaryTax() * quantity);
        }
        
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TaxedAmount { get; private set; }
        public decimal Tax { get; private set; }
    }
}
