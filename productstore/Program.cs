using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productstore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<product> products = new List<product>();
            product_controller controller = new product_controller();
            Console.WriteLine("******PRODUCT STORE*******\n");
            bool showmenu = true;
            Console.WriteLine("---console app---\n");
            while (showmenu)
            {

                Console.WriteLine("----select a option---\n");
                Console.WriteLine("---1.Add product\n");
                Console.WriteLine("---2.Display all products---\n");
                Console.WriteLine("---3.Delete a product---\n");
                Console.WriteLine("---4.Exit---\n");
                Console.WriteLine("---Enter a option---\n");
                int key = Int32.Parse(Console.ReadLine());
                if (key == 1)
                {
                    Console.WriteLine("Enter product id:");
                    int id = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Enter product name:");
                    string name = (Console.ReadLine());

                    Console.WriteLine("Enter product price:");
                    int price = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Enter product color:");
                    string color = (Console.ReadLine());

                    Console.WriteLine("Enter product model:");
                    int model = Int32.Parse(Console.ReadLine());

                    product product = new product();
                    product.id = id;
                    product.name = name;
                    product.price = price;
                    product.color = color;
                    product.model = model;

                    controller.addItem(new product() { id = id, name = name, price = price, color = color, model = model });
                    Console.WriteLine("product added successfully");
                    Console.ReadLine();



                }
                else if (key == 2)
                {
                    controller.display();
                    Console.ReadLine();

                }
                else if (key == 3)
                {
                    Console.WriteLine("enter a product id:");
                    int position = Int16.Parse(Console.ReadLine());
                    products.RemoveAt(position);
                    Console.WriteLine("product deleted successfully");
                    Console.ReadLine();

                }
                else if(key == 4)
                {
                    Environment.Exit(0);

                }

                
            }


        }
    }
}
