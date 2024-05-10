using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagar1_Assignment
{
    public abstract class AbstractclassQ6
    {
        public void add(int num1, int num2)
        {
            System.Console.WriteLine("the adition of {0} and {1} is {2}", num1, num2, (num1 + num2));
        }
        abstract public    void multi(int num1, int num2);
     abstract   public void divide(int num1, int num2);

    }
   
    public class Excel1 : AbstractclassQ6
    {
        public void add(int num1, int num2)
        {
            System.Console.WriteLine("the adition of {0} and {1} is {2}", num1, num2, (num1 + num2));

        }

        public override void multi(int num1, int num2)
        {
            Console.WriteLine("the multiply of {0} and {1} is {2}", (num1 * num2), num1, num2);
        }
        public override void divide(int num1, int num2)
        {
            Console.WriteLine("the divide of {0} and {1} is {2}", (num1 / num2), num1, num2);
        }
    }
    internal class Sagar_Ass6
    {
        public static void Main(string[] args)
        {
            Excel1 excel1 = new Excel1();
            int num1 = 30;
            int num2 = 10;

            excel1.add(num1, num2);
            excel1.multi(num1, num2);
            excel1.divide(num1, num2);
        }

    }
}
