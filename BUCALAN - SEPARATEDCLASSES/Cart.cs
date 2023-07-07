using System.Collections.Generic;

class Cart
{
    private List<NikeShoe> cartItems;

    public Cart()
    {
        cartItems = new List<NikeShoe>();
    }

    public void AddToCart(NikeShoe shoe)
    {
        cartItems.Add(shoe);
    }

    public List<NikeShoe> GetCartItems()
    {
        return cartItems;
    }

    public void ClearCart()
    {
        cartItems.Clear();
    }
}
    