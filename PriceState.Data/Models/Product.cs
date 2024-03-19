namespace PriceState.Data.Models;

public class Product
{
    public long Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public Unit Unit { get; set; }

    public int UnitId { get; set; }
}