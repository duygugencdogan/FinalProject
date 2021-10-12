using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //EF -> Microsoft ürünü, ORM dediğimiz (Object Relational Mapping)
    //ORM -> Veritabanını bir class mış gibi ilişkilendirip LINQ ile işlem yaptığımız bir ortam
    //Veritabanı nesneleri ile kodlar arasında bir ilişki bir bağ kurup veritabanı işlerini yapma süreci
    //Yazılımda ilerledikçe başkalarının yazdığı kodları(paketleri) kullanacağız.
    //Bu kodların ortak olarak koyulduğu ve yönetildiği bir ortam var ve bu ortamın adı NuGet
    //NuGet ->.NetCore içerisinde default olarak EntityFramework bir paketle geliyor.

    public class EfProductDal : IProductDal
    {
        //Yazdığımız kodu daha sonra refactor de edeceğiz
        //Refactor
        public void Add(Product entity)
        {
            //C#'a özel güzel bir yapı
            //Garbage Collector
            //Using içerisindeki nesneler işi bittikten sonra Garbage Collectora bunları at der.
            //Çünkü Context nesnesi biraz pahalı
            //Using -> IDisposable pattern implementation pf c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //Ternary operator                          //Listeye çevir
                return filter == null
                    ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList();

            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
