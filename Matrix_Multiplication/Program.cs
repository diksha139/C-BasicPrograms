using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m1_r = 3, m1_c = 2, m2_r = 2, m2_c = 3;
            int i, j, k;
            int[,] mx1 = { {1,2}, {4,5 },{ 6,7} };
            int[,] mx2 = { { 7, 8, 9 }, { 10, 11, 12 } };
            int[,] resultant = new int[m1_r, m2_c];

            Console.WriteLine("The 1st Matrix is : ");
            for(i=0; i< m1_r; i++)
            {
                for (j = 0; j < m1_c; j++)
                {
                    Console.Write(mx1[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Your 2nd Matrix is : ");

            for(i = 0;i<m2_r; i++)
            {
                for(j=0;j<m2_c; j++)
                {
                    Console.Write(mx2[i, j] + " ");
                }
                Console.WriteLine();
            }

            if(m1_c == m2_r)
            {
                for (i = 0; i < m1_r; i++)
                {
                    for(j=0;j< m2_c; j++)
                    {
                        resultant[i, j] = 0;

                        for (k = 0; k < m1_c; k++)
                        {
                            resultant[i, j]  += (mx1[i, k] * mx2[k, j]);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Multiplication not possible: ");
            }

            Console.WriteLine("The Output Matrix is : ");
            for (i = 0; i < m1_r; i++)
            {
                for (j = 0; j < m2_c; j++)
                {
                    Console.Write(resultant[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
