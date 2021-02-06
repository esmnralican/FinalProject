﻿using Business.Concrete;
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
            //DTOs : Data Transformation Object
            ProductTest();
            // IoC
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);

            }

        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())//GetAllByUnitPrice(20,100) : 40£ ile 100£ arasındaki
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
    }
}
