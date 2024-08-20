using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //Bu tip class larda sadece özellik olur.
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        public double UnitPrice { get; set; }   //ürün fiyatı
        public int UnitsInStock { get; set; }   //ürün stok durumu

        
    }
}
