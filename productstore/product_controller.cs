using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productstore
{
    class product_controller
    {
        private List<product> products;
        public product_controller()
        {
            products = new List<product>();

        }
        public void addItem(product product)
        {
            products.Add(product);

        }
        public void display()
        {
            foreach (product p in products)
            {
                Console.WriteLine("----------");

                Console.WriteLine("id :" + p.id);
                Console.WriteLine("name :" + p.name);
                Console.WriteLine("price :" + p.price);
                Console.WriteLine("color :" + p.color);
                Console.WriteLine("model :" + p.model);

                Console.WriteLine("-----------");
            }
        }
    }
}
            
