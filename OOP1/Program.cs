using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Bilgisayar";
            product1.UnitPrice = 2500;
            product1.UnitInStock = 15;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "Masa",
                UnitPrice = 500,
                UnitInStock = 10
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
