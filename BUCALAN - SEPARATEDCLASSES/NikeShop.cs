using System;

class NikeShop
{
    private ShoeInventory inventory;
    private Cart cart;

    public NikeShop()
    {
        inventory = new ShoeInventory();
        cart = new Cart();
    }

    public void DisplayShoes()
    {
        var shoes = inventory.GetAvailableShoes();
        Console.WriteLine("Available shoes:");
        for (int i = 0; i < shoes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {shoes[i]}");
        }
    }

    public void AddToCart(int choice, int quantity)
    {
        var shoes = inventory.GetAvailableShoes();
        if (choice > 0 && choice <= shoes.Count)
        {
            NikeShoe selectedShoe = shoes[choice - 1];
            if (quantity <= selectedShoe.Quantity)
            {
                NikeShoe cartShoe = new NikeShoe(selectedShoe.Name, selectedShoe.Description, selectedShoe.Price, quantity);
                cart.AddToCart(cartShoe);
                inventory.UpdateShoeQuantity(selectedShoe, quantity);
                Console.WriteLine("Item added to cart.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sorry, we don't have sufficient stock for the selected quantity.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
            Console.WriteLine();
        }
    }

    public void Checkout()
    {
        Console.WriteLine("Checking out...");
        var cartItems = cart.GetCartItems();
        if (cartItems.Count > 0)
        {
            decimal totalAmount = CalculateTotalAmount(cartItems);
            DisplayCart(cartItems);
            Console.WriteLine($"Total amount: php{totalAmount}");
            Console.WriteLine("Thank you for your purchase!");
        }
        else
        {
            Console.WriteLine("Your cart is empty. Thank you for visiting our shop!");
        }
        cart.ClearCart();
    }

    private decimal CalculateTotalAmount(List<NikeShoe> cartItems)
    {
        decimal totalAmount = 0;

        foreach (NikeShoe shoe in cartItems)
        {
            totalAmount += shoe.Price * shoe.Quantity;
        }

        return totalAmount;
    }

    private void DisplayCart(List<NikeShoe> cartItems)
    {
        Console.WriteLine("Your cart:");
        for (int i = 0; i < cartItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {cartItems[i]}");
        }
    }
}
