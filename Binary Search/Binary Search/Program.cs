using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {

      public int binary_search(int[] arr1, int num)
        {
            int len = arr1.Length;
            int lower_index = 0;
            int upper_index = len - 1;
            int mid;
            
            while (lower_index <= upper_index)
            {
                mid = lower_index + ((upper_index - lower_index) / 2);
                int mid1 = (int)mid;
                if (num == arr1[mid1])
                {
                    return mid1;
                }
                else if (num > arr1[mid1])
                {
                    lower_index = mid1 + 1;


                }
                else 
                {
                    upper_index = mid1 - 1;


                }
               

                
            }
                    return -1;



        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 45, 56, 67, 78, 89, 90, 100 };
            Console.WriteLine("Enter a number to be searched.");
            string input1 = Console.ReadLine();
            int num = Convert.ToInt32(input1);
            Program obj = new Program();
            int result = obj.binary_search(array1, num);
            if (result == -1)
            {
                Console.WriteLine("Number is not present in the array");
                for (int i =0;i<array1.Length;i += 1)
                {
                    Console.WriteLine(" "+array1[i]+" ");
                }
                Console.WriteLine("Please check again from the array " );
            }
            else
            {
                Console.WriteLine("Your Array was : " );
                for (int i = 0; i < array1.Length; i += 1)
                {
                    Console.WriteLine(" " + array1[i] + " ");
                }
                Console.WriteLine("Number is present at " + result + " index");

            }
            Console.ReadLine();

        }
    }
}
