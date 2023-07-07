using System;

class NikeShoe
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public NikeShoe(string name, string description, decimal price, int quantity)
    {
        Name = name;
        Description = description;
        Price = price;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"{Name} - {Description} ({Quantity} quantity) - php{Price}(each)";
    }
}
