using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {

        public bool isArmstrong(int num)
        {
            int temp = num;
            double sum = 0;
            int digits = num.ToString().Length;
            int digit = 0;
            while(num > 0)
            {
                digit = num % 10;
                sum += Math.Pow(digit, digits);
                num = num / 10;
            }
            if(sum == temp)
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
            Console.WriteLine("Enter a Number to check Armstrong: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            bool result = obj.isArmstrong(number1);
            if(result == true)
            {
                Console.WriteLine(number1 + " is Armstrong.Hurrayyyyyyyyyyy");
            }
            else
            {
                Console.WriteLine(number1 + " is not Armstrong.SO Sad!!");

            }

            Console.ReadLine();
        }

    }
}
