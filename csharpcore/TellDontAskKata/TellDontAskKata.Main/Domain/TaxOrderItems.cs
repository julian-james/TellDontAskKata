using System.Collections.Generic;

namespace TellDontAskKata.Main.Domain;

public class TaxOrderItems
{
    private List<OrderItem> Items { get; set; } = new();
        
    private decimal Tax { get; set; }
        
    private decimal Total { get; set; }

    public void Add(OrderItem orderItem)
    {
        this.Items.Add(orderItem);
        this.Total += orderItem.TaxedAmount;
        this.Tax += orderItem.Tax; 
    }

    public List<OrderItem> GetItems()
        => this.Items;

    public int Count => this.Items.Count;
    
    public decimal GetTotal => this.Total;
    
    public decimal GetTax => this.Tax;
}