using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace recursion

{
    public class Demo
    {
        public static void Main(string[] args)
        {
            Demo d = new Demo();
            int val = 7;
            int res = d.displayFibonacci(val);
            Console.WriteLine("{0}th number in fibonacci series = {1}", val, res);
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            long fact = GetFactorial(number);
            Console.WriteLine("{0} factorial is {1}", number, fact);
            Console.ReadKey();
        }
        public static long GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }
        public int displayFibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return displayFibonacci(n - 1) + displayFibonacci(n - 2);
            }
        }
    } 
}
