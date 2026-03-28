
using Assignment02_Advanced.ClassProduct;

namespace Assignment02_Advanced
{
    internal class Program
    {
        #region task01 
        //public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        //{
        //    List<Product> result = new List<Product>();

        //    foreach (var product in products)
        //    {
        //        if (filter(product))
        //        {
        //            result.Add(product);
        //        }
        //    }

        //    return result;
        //}

        //public static void PrintProducts(string title, List<Product> products)
        //{
        //    Console.WriteLine("------------------------------------------------------------");

        //    Console.WriteLine($"---{title}---");

        //    Console.WriteLine("------------------------------------------------------------");

        //    foreach (var p in products)
        //    {

        //        Console.WriteLine($" {p.Name}--{p.Price:c} (Stock: {p.Stock})");
        //    }

        //    Console.WriteLine("------------------------------------------------------------");
        //}
        #endregion

        #region task02
        //I used Action delegate because i want to print the report and i dont need to return any value from the method
        public static void PrintReport(List<Product> products, Action<Product> PrintAction)
        {
            foreach (var product in products)
            {
                PrintAction(product);
            }
        }



        #endregion
        static void Main(string[] args)
        {
            List<Product> catalog = new()
                {
                    new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
                    new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
                    new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                    new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                    new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                    new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
                    new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
                    new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
                    new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
                    new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
                };

            #region Task01

            //var Electronics = SearchProducts(catalog, p => p.Category == "Electronics");
            //PrintProducts("ELECTRONICS", Electronics);


            //var CheapProducts = SearchProducts(catalog, p => p.Price < 50);
            //PrintProducts("Under $50", CheapProducts);

            //var AvailableProducts = SearchProducts(catalog, p => p.Stock > 0);
            //PrintProducts("IN STOCK", AvailableProducts);


            //var AffordableClothing = SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);
            //PrintProducts("CLOTHING UNDER $100", AffordableClothing);

            #endregion

            #region Task02

            Console.WriteLine("--- SHORT REPORT ---");

            PrintReport(catalog, p => Console.WriteLine($"{p.Name}- ${p.Price}"));

            Console.WriteLine("--------------------");

            Console.WriteLine("\n--- DETAILED REPORT ---");

            PrintReport(catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}") );

            Console.WriteLine("-----------------------");

            #endregion


        }

    }
}
