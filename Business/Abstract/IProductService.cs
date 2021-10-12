using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        //tümünü getir
        List<Product> GetAll();
        //category id'ye göre getir
        List<Product> GetAllByCategoryId(int id);
        //Bu fiyat aralığındaki ürünler
        List<Product> GetByUnitPrice(decimal min, decimal max);


    }
}
