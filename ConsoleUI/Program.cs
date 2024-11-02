using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
namespace MyFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("-------------------------------------------------");

            foreach (var p in productManager.GetAllByUnitPrice(50,100))
            {
                Console.WriteLine(p.ProductName);
            }
            Console.WriteLine("-------------------------------------------------");

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
           

        }
    }
}

