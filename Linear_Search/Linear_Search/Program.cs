using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    internal class Program
    {
        public static int Linear_Search(int[] arr, int num)
        {
            for(int i = 0; i < arr.Length; i++) 
            {
                    if (num == arr[i])
                    {
                        return i;
                    }
                    else
                    {
                        continue;
                    }

                    
              
            }
                return -1;
            }






        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 7, 2, 3, 9, 56, 83, 91, 20, 38, 49 };
            Console.WriteLine("Enter a number to be searched for : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();

            int idx = Program.Linear_Search(arr, num);
            if (idx != -1)
            {
                Console.WriteLine("Number " + num + " is present at an index of : " + idx);
            }
            else
            {
                Console.WriteLine("Number is not found...");
            }
            Console.ReadLine();
        }



    }
}

