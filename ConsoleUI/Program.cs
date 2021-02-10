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
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var x in categoryManager.GetAll())
            {
                Console.WriteLine(x.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var x in result.Data)
                {
                    Console.WriteLine("Ürün Adı : " + x.ProductName + " / " + "Kategori : " + x.CategoryName);
                    Console.WriteLine("---------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
        }
    }
}
