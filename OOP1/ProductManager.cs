using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //string ad ile aynı şey verdiğimiz değer buraya atanacak demek 
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }

        public void update(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

       
      



    }
}
