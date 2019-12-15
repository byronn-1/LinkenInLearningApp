using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkenInLearningApp
{
    class Program
    {
        public static double subtotal;

        static void Main(string[] args)
        {
            subtotal = 15.00;

            Console.WriteLine($"Subtotal: {subtotal}");

            CalculateTax(0.8);
        }

        public static double CalculateTax(double taxRate)
        {
            double tax = subtotal* taxRate;
            Console.WriteLine($"Tax: {tax}");

            return tax;
        }
    }
}
