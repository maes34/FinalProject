using Businnes.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var x in productManager.GetAll())
            {
                Console.WriteLine("Ürün Adı : " + x.ProductName);
                Console.WriteLine("Ürün Fiyatı : " + x.UnitPrice);
                Console.WriteLine("Stok : " + x.UnitsInStock);
                Console.WriteLine("---------------------------");
            }

        }
    }
}
