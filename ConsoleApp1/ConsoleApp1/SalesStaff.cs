﻿//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ShoppingSystem
//{
//    class SalesStaff
//    {
//        //Customer c = new Customer();
//        CourierCompany cou = new CourierCompany();
//        ShoppingCart sho = new ShoppingCart();
//        public void ProcessOrder()
//        {

//            Console.WriteLine("Enter the card no \n and card holder name");
//            int cardno = Convert.ToInt32(Console.ReadLine());
//            string holdername = Console.ReadLine();
//            CreditCard creditcard = new CreditCard(cardno, holdername);
//            double tot = sho.GetTotalCost();
//            Console.WriteLine("Money debited from cardno-{0} and the amount is-{1}", creditcard.GetCreditCardNum(), tot);

//            Console.WriteLine("What kind of packing..? 1.Gift or 2.Normal");
//            int choice = Convert.ToInt32(Console.ReadLine());
//            if (choice == 1)
//            {
//                cou.Packing("Gift");
//            }
//            else
//            {
//                Console.WriteLine("Normal");
//            }

//            cou.OrderDelivery();

//        }

//        public void Refund()
//        {
//            Console.WriteLine("Refund amount successfully");
//        }

//    }
//}
