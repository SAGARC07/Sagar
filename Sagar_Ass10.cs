using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagar1_Assignment
{
    internal class Sagar_Ass10
    {
        delegate int mydel();
        delegate int yourdel(int num);
        public static int greet()
        {
           
            return 0;
        }
        public static int merrychristmas()
        {
           
            return 0;
        }
        public static int odd(int num)
        {
            return num;
        }
        public static int even(int num)
        {
            return num;
        }

        static void Main()
        {
            mydel del;
            Console.WriteLine("MerryChristmas or greeting card");
            string choice = Console.ReadLine();
            choice = choice.ToUpper();
            if (choice == "GREET")
            {
                del = new mydel(greet);
                Console.WriteLine("Hello");
            }
            else
            {
                del = new mydel(merrychristmas);
                Console.WriteLine("Happy christmas");
            }
            del();

            yourdel yourDelegate;
            Console.WriteLine("enter a number:");
            int choices = Convert.ToInt32(Console.ReadLine());
            if (choices % 2 == 0)
            {
                yourDelegate = new yourdel(even);
                int ans = yourDelegate(choices);

                Console.WriteLine(ans + "is even number");


            }
            else
            {
                yourDelegate = new yourdel(odd);
                Console.WriteLine("odd");
                int ans = yourDelegate(choices);
                Console.WriteLine(ans + "is odd number");
            }
        }

    }
}
