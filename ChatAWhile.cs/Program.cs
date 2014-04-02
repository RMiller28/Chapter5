using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chat_A_While
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int[] zips = new int[] { 262, 414, 608, 715, 815, 920 };
            double[] charges = new double[] { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            Console.Write("Enter your Call Area Code: ");
            String input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            Console.Write("Enter your call length in minutes: ");
            input = Console.ReadLine();


            for (int i = 0; i < zips.Length; i++)
            {


                if (n == zips[i])
                {
                    sum = charges[i] * 60;
                    Console.WriteLine("Your call was successful. Your Charges will be {0}", sum.ToString("C")); //charges[i].ToString("C"));


                }
            }
        }
    }
}