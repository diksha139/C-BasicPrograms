using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Square
{
    internal class Program
    {
        public bool is_perfect_square(int num)
        {
            double x = Math.Sqrt(num);

            if(x*x == num)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if its perfect square or not");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            bool result = obj.is_perfect_square(number1);
            if (result)
            {
                Console.WriteLine(number1+" is a perfect square");
            }
            else
            {
                Console.WriteLine("ops!! "+number1 + " is not a perfect square");

            }
            Console.ReadLine();
        }
    }
}
