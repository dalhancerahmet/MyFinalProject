using Business.Concrete;
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
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine("Kategori adı: {0}", item.CategoryName);
            }
        }
        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetailsDto();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine("Ürün adı: " + product.ProductName + " " + "Kategorisi:" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}