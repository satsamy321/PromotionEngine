using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEng
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IProductService prdService = new ProductService();
            List<Product> products = new List<Product>();

            Console.WriteLine("Total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                
                products.Add(prdService.GetPriceByType(type));
            }

            int totalPrice = prdService.GetTotalPrice(products);
            Console.WriteLine("Total Price:" + totalPrice);
            Console.ReadLine();
        }
    }


    
  

   

   

    
}
