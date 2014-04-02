using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zips = new int[] { 10617, 12345, 43235, 10845, 13443, 12365, 64432, 12346, 12356, 76423 };
            double[] charges = new double[] { 2.00, 2.50, 3.00, 4.00, 1.23, 1.45, 1.65, 2.56, 3.20, 100.00 };
            Console.Write("Enter your Zipcode: ");
            String input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            int index = -1;
            //bool isValiditem = false;

            for (int i = 0; i < zips.Length; i++)
            {

                if (n == zips[i])
                {
                    index = i;
                    Console.WriteLine("Yes we deliver to your Zip Code. Your Charges will be {0}", charges[i].ToString("C"));
                }

            }


            if (index == -1)
            {
                Console.WriteLine("We do not deliver to your Zip Code. Sorry.");
            }
        }
    }
}