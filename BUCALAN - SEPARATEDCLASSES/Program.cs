class Program
{
    static void Main(string[] args)
    {
        NikeShop nikeShop = new NikeShop();
        Console.WriteLine("Welcome to the Nike shop!");
        Console.WriteLine();

        while (true)
        {
            nikeShop.DisplayShoes();

            Console.WriteLine();
            Console.Write("Enter the number of the shoe you want to buy (or '0' to checkout): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 0)
            {
                nikeShop.Checkout();
                break;
            }
            else
            {
                Console.Write("Enter the quantity you want to buy: ");
                int quantity = int.Parse(Console.ReadLine());

                nikeShop.AddToCart(choice, quantity);
            }
        }
    }
}
