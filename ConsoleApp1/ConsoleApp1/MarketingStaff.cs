using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    class MarketingStaff
    {

        public List<Product> products = new List<Product>()
        {
            { new Product(12,"Mi",100)},
        { new Product(34,"Samsung",1000) }
        };


        //public void DisplayProducts()
        //{
        //    Console.WriteLine("The Products are");
        //    foreach (KeyValuePair<int, Product> item in products)
        //    {
        //        Console.WriteLine(item.ToString());
        //    }

        //}
        public int GetProductID(int id)
        {
            foreach (Product c in products)
            {
                if ((id == c.GetId()))
                {
                    return id;
                }
            }
            return 0;
        }
        public string GetName(int id)
        {
            foreach (Product c in products)
            {
                if ((id == c.GetId()))
                {
                 
                    return c.GetName();
                }
            }
            return "";
        }
        public int GetProductCost(int id)
        {
            foreach (Product c in products)
            {
                if ((id == c.GetId()))
                {
                    return c.GetCost();
                }
            }
            return 0;
        }
        public void UpdateProduct(int key, Product p)
        {
            //if (products.ContainsKey(key))
            //{
            //    products[key] = p;
            //    Console.WriteLine("Updated item successfully");
            //}
            //else
            //{
            //    products.Add(key, p);
            //}
            products[key] = p;
            Console.WriteLine("Updated item successfully");
        }
        //public void DeleteProduct(int key)
        //{
        //    products.Remove(key);
        //    Console.WriteLine("Item deleted successfully");
        //}
        public void SendMail()
        {
            Console.WriteLine("Sent mail successfully");
        }
    }
}
