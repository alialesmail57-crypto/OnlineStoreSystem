using ShopData;
using ShopData.Models;

namespace OnlineStoreSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Data data = new Data();
            var products = data.products();
            bool isrunning = true;
            while (isrunning)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔══════════════════════════════════════════════════╗");
                Console.WriteLine("║            ONLINE STORE MANAGEMENT SYSTEM        ║");
                Console.WriteLine("╚══════════════════════════════════════════════════╝");
                Console.WriteLine(" [1]:  View Available Products");
                Console.WriteLine(" [2]:  Buy Product By ID");
                Console.WriteLine(" [3]:  Restock Product By ID");
                Console.WriteLine(" [4]:  View Product Names Only");
                Console.WriteLine(" [5]:  View Product with Highest Price");
                Console.WriteLine(" [6]:  Exit");
                Console.Write("****Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("────────────────────────────────────────────────────");
                Console.ForegroundColor = ConsoleColor.Cyan;
                switch (choice)
                {
                    case 1:
                        products = data.products().Where(a => a.StockQuantity > 0).OrderBy(a => a.Price).ToList();
                        foreach (var product in products)
                        {
                            Console.WriteLine($"Id: {product.Id}   Name: {product.Name}   Price: {product.Price}$   StockQuantity: {product.StockQuantity}");
                        }
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.WriteLine("***​Please enter the Product ID and the quantity you wish to purchase*** ");
                        Console.Write("Enter Product ID: ");
                        int ID = Convert.ToInt32(Console.ReadLine());
                        products = products.Where(a => a.Id == ID).ToList();
                        foreach (var product in products)
                        {
                            Console.WriteLine($"  {product.Name}, Price: {product.Price}$, Stock Quantity: {product.StockQuantity}");
                        }
                        Console.Write("Enter Quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        var result = products[0].Buy(quantity);
                        if (result == true)
                        {
                            Console.WriteLine("Purchase successful!");
                        }
                        else
                        {
                            Console.WriteLine("Purchase failed. Insufficient stock | Or enter a valid quantity > 0.");
                        }
                        Console.WriteLine(" ");
                        break;
                    case 3:
                        Console.WriteLine("*****​Please enter the Product ID and the quantity you wish to restock***** ");
                        Console.Write("Enter Product ID: ");
                        int restockID = Convert.ToInt32(Console.ReadLine());
                        products = products.Where(a => a.Id == restockID).ToList();
                        Console.Write("Enter Quantity:");
                        int restockQuantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" Quantity before restock: ");
                        foreach (var product in products)
                        {
                            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Stock Quantity: {product.StockQuantity}");
                        }
                        var restockResult = products[0].Restock(restockQuantity);
                        if (restockResult == true)
                        {
                            Console.WriteLine("  Quantity after restock: ");
                            foreach (var product in products)
                            {
                                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Stock Quantity: {product.StockQuantity}");
                            }
                            Console.WriteLine("*****Restock successful*****");
                        }
                        else
                        {
                            Console.WriteLine("*****Restock failed |  enter a valid quantity > 0.*****");
                        }
                        Console.WriteLine(" ");
                        break;


                    case 4:

                        var name = data.products().Select(n => n.Name).ToList();
                        foreach (var product in name)
                            Console.WriteLine($"{product}");

                        break;
                    case 5:
                        var maxProduct = data.products().MaxBy(p => p.Price);

                        Console.WriteLine($" {maxProduct.Name} : {maxProduct.Price}$");
                        break;
                    case 6:
                        isrunning = false;
                        Console.WriteLine("-----Thank you for visiting the Online Store. Goodbye--------");
                        Console.WriteLine(" ");
                        break;

                    default:
                        Console.WriteLine("Please try again and Enter number ( 1 --> 6).");


                        Console.WriteLine(" ");
                        break;
                }
            }
        }
    }
}