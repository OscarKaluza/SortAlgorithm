using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            Data data = new Data(); 

            Console.WriteLine($"Product with highest price: {order.GiveMaximumPrice(data.GetProducts())} ");
            Console.WriteLine($"Average Price: {order.GiveAveragePrice(data.GetProducts())} ");

            Console.WriteLine("Sorted List:");
            for ( int i = 0; i < data.GetProducts().Count; i++ )
            {
                Console.WriteLine(order.SortProductsByPrice(data.GetProducts())[i].Price);
            }
            Console.ReadLine();
        }
    }
}
