using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Veritabanında Product ile ilgili yapacağım işlerin interface'i
    //interface'in kendisi değil ama operasyonları public
    public interface IProductDal:IEntityRepository<Product>
    {
        //içindekiler default public'tir.
        


    }
}
