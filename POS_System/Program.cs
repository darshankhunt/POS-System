using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string Uname = Console.ReadLine();
            Console.WriteLine("Welcome " + Uname);

            Console.WriteLine("Enter Total Item");
            int totalIteam = Convert.ToInt32(Console.ReadLine());
            

            Hashtable item_and_price = new Hashtable();
            //int price;
            int amt = 0;
            for (int i = 1; i <= totalIteam; i++)
            {
                
                Console.Write("Enter Product Name: ");
                string product = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Product Price: ");
                int Price = Convert.ToInt32(Console.ReadLine());
                
                item_and_price.Add(product, Price);
                
                amt = Price + amt;
                //Console.WriteLine("Your total Amount : " + totalamt);
            }
            Console.WriteLine("Your total Amount : " + amt);
            Console.Write("Enter discount you want : ");
            int discount = Convert.ToInt32(Console.ReadLine());
            int dis = amt * discount / 100;
            Console.WriteLine("Your Discount Amount is : " + dis);

            int finalamt = amt - dis;
            Console.WriteLine("Your Paid Amount is : " + finalamt);
            

            //Console.Write("Do you want discount?: (Y/N)");
            //string dis Console.ReadLine()

            
            //Console.

            //foreach (var obj1 in item_and_price)
            //{
            //    Console.WriteLine("{0} : {1}", obj1, item_and_price[obj1]);
            //}
            Console.ReadLine();
        }
    }
}
