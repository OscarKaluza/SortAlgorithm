using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class Order
    {
        public double GiveMaximumPrice(List<Product> products)
        {
            double maximumPrice = 0;

            foreach (Product p in products)
            {
                if (p.Price > maximumPrice)
                {
                    maximumPrice = p.Price;
                }
            }

            return maximumPrice;
        }

        public double GiveAveragePrice(List<Product> products)
        {
            double totalPrice = 0;
            double numberOfItems = 0;

            foreach (Product p in products)
            {
                totalPrice += p.Price;
            }

            foreach (Product p in products)
            {
                numberOfItems++;
            }

            double averagePrice = totalPrice / numberOfItems;
            return averagePrice;
        }

        public List<Product> SortProductsByPrice(List<Product> products)
        {
            List<Product> sortedList = new List<Product>(products);

            for (int i = 0; i < products.Count; i++)
            {
                for (int j = 0; j < products.Count - 1; j++)
                {
                    if (sortedList[j].Price > sortedList[j + 1].Price)
                    {
                        Product temp = sortedList[j];
                        sortedList[j] = sortedList[j + 1];
                        sortedList[j + 1] = temp;
                    }
                }
            }

            return sortedList;
        }

    }
}
