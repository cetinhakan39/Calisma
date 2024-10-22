using System;
namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hello, World!");

         ProductManager productManager = new ProductManager();
         int sayi1 = 99;
         productManager.BiseyYap(sayi1);
         Console.WriteLine(sayi1);

            Product product1 = new Product { Id = 1, ProductName="Masa", 
                CategoryId = 2, UnitPrice=30, UnitsInStock = 500 };

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


        }
    }
}
