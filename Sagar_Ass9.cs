using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagar1_Assignment
{
    internal class Sagar_Ass9
    {
        static void Main(string[] args)
        {
            add(12, 45);
            System.Console.WriteLine("*************");
            add(34, 45, 66);
            System.Console.WriteLine("**************");
            priceList("parle", "Hide and sick", "Cream Biscuits", "Glucose");
        }
        static void add(params int[] a)
        {
            foreach (int x in a)
            {
                System.Console.WriteLine(x);
            }
        }
        static void priceList(string companyName, params string[] products)
        {
            System.Console.WriteLine("{0} has the following producs ", companyName);
            for (int i = 0; i < products.Length; i++)
            {
                System.Console.WriteLine(products[i]);
            }
        }
    }
}
