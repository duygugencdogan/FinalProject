using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //O -> Open Closed Principle
    class Program
    {
        //Abstract -> Soyut Nesneleri yani Interface, BaseClass, Abstract Class
        //Concrete(Somut) yani gerçek işi yapanlar -> Referans Tutucular
        //Biz abstratc lar ile uygulamalar arasındaki bağımlılıkları minimize ediyor olacağız.
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);

            }
        }
    }
}
