using TellDontAskKata.Main.UseCase;

namespace TellDontAskKata.Main.Domain
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public decimal UnitaryTax()
            => TaxRounding.Round((this.Price / 100m) * this.Category.TaxPercentage);
        
        public decimal UnitaryTaxedAmount()
            => TaxRounding.Round(this.Price + this.UnitaryTax());
    }
}