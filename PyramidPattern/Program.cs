using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                for (int j = i; j <= 20; j++)
                {
                    Console.Write(" ");


                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");

                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
                

            }
            Console.ReadLine();
        }
    }
}
