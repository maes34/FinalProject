using Businnes.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var x in productManager.GetByUnitPrice(20,50))
            {
                Console.WriteLine("Ürün Adı : " + x.ProductName);
                Console.WriteLine("Fiyat : " + x.UnitPrice);
                Console.WriteLine("---------------------------");
            }

        }
    }
}
