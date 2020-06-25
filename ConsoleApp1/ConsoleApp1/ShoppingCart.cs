using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSystem
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {

        }
        public string MailId;
        public int ProductId;
        public string Name;
        public int Cost;
        MarketingStaff ms = new MarketingStaff();
        List<ShoppingCart> cart = new List<ShoppingCart>();
        public ShoppingCart(string mid, int pid,string name,int cost)
        {
            this.MailId = mid;
            this.ProductId = pid;
            this.Name = name;
            this.Cost = cost;
        }

        public string GetMID()
        {
            return MailId;
        }
        public void SetMID(string mid)
        {
            this.MailId = mid;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public int GetCost()
        {
            return Cost;
        }
        public void SetCost(int cost)
        {
            this.Cost = cost;
        }
        public int GetPID()
        {
            return ProductId;
        }
        public void SetPID(int pid)
        {
            this.ProductId = pid;
        }
        public void AddToCart(string mailid)
        {
            string maiid = mailid;
            Console.WriteLine("Enter the item id to add it to cart");
            int item = Convert.ToInt32(Console.ReadLine());
            int id = ms.GetProductID(item);
            string name = ms.GetName(item);
            int cost = ms.GetProductCost(item);
            ShoppingCart cart1 = new ShoppingCart(maiid,id,name,cost);
            cart.Add(cart1);
            Console.WriteLine("Items added to cart successfully");
        }
        public void ViewCart(string mailid)
        {
            
            
                foreach(var item in cart)
                {
                    if (item.GetMID() == mailid)
                    {
                    Console.WriteLine("The cart items are");
                    Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Item ID :" + item.GetPID());
                        Console.WriteLine("Item Name :" + item.GetName());
                        Console.WriteLine("Item Cost :" + item.GetCost());
                    Console.WriteLine("-------------------------------------------");

                }
                }
            if (cart.Count == 0)
            {
                Console.WriteLine("no items in the cart to display");
            }
        }

        //public void DeleteCart()
        //{
        //    Console.WriteLine("Enter the product id to delete from cart");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    int count = 0;
        //    for (int i = 0; i < cart.Count; i++)
        //    {
        //        if (cart[i].GetId() == id)
        //        {
        //            Product p;
        //            p = cart[i];
        //            cart.Remove(p);
        //            count++;
        //            Console.WriteLine("Deleted successfully");
        //        }
        //    }
        //    if (count == 0)
        //    {
        //        Console.WriteLine("Can't delete");
        //    }
        //}
        //public double GetTotalCost()
        //{
        //    double totalcost = 0;
        //    for (int i = 0; i < cart.Count; i++)
        //    {
        //        totalcost += cart[i].GetCost();
        //    }
        //    Console.WriteLine(totalcost);
        //    return totalcost;
        //}
    }
}
