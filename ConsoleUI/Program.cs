using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLİD Prensipleri 
    //Open CLosed Principle, yeni bir özellik ekliyorsan mevcuttaki hiçbir koda dokunmazsın.
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))//GetAllByUnitPrice(20,100) : 40£ ile 100£ arasındaki
            {
                Console.WriteLine(product.ProductName);
            }
            
            
        }
    }
}
