//https://www.youtube.com/watch?v=G0sOB_-WkyI&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=4 49.50 de kaldım
//bu kısımdan önce siz yazmayın demişti. yazın diyene kadar bekle

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //CRUD operasyonları bu class da yapılır.
    //Create (yaratmak), read (okumak), update (güncellemek), delete (silmek)
    class ProductManager
    {
        //encapsolution(kapsülleme)
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }

    }
}
