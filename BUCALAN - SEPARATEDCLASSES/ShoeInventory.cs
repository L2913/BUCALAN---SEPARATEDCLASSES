using System.Collections.Generic;

class ShoeInventory
{
    private List<NikeShoe> shoes;

    public ShoeInventory()
    {
        shoes = new List<NikeShoe>()
        {
            new NikeShoe("Air Force 1", "Classic low-top design", 5499.99m, 10),
            new NikeShoe("Air Max 90", "Iconic sneaker with visible air unit", 6499.99m, 5),
            new NikeShoe("Jordan 1", "High-top basketball shoe", 7299.99m, 3)
        };
    }

    public List<NikeShoe> GetAvailableShoes()
    {
        return shoes;
    }

    public void UpdateShoeQuantity(NikeShoe shoe, int quantity)
    {
        shoe.Quantity -= quantity;
    }
}
