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

            double total = subtotal + CalculateTax(0.08, subtotal);

            Console.WriteLine($"Total: {total}");
        }

        public static double CalculateTax(double taxRate, double amountToTax)
        {
            double tax = amountToTax * taxRate;
            Console.WriteLine($"Tax: {tax}");

            return tax;
        }
    }
}
