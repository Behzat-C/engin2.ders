using OOP1;
using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitPrice=25,
                ProductName="Tahta",UnitsInStock=76, };

            //product 1 gibi product 2 gibi süslü parantez içinde yazabiliriz
            //case sensitive ** büyük küçük harf duyarlılığı
            //PascalCase   //camelCase ** değişkenlerde kullanılır
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            /*
            productManager.Topla2(3, 6);

            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonucu*2); */



            //int, double, bool... değer tip
            //diziler, class, abstract class, interface... referans tip
        }
    }
}