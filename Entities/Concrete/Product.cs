using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product: IEntity
    {
        //public -> Bu class'a diğer katmanların ulaşmasına izin verir.
        //Bu class 3 katmanda kullanabiliyor olmalı bu yüzden public oldu.
        //Bir class'ın default'u internel'dır. Internal sadece Entities erişebilir demek olur.
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
