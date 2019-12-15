using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkenInLearningApp
{
    class Program
    {
        public static int myScore = 1000;

        static void Main(string[] args)
        { 
            
 
        }

        public static void ChangeScore(int myScore)
        {
            myScore = myScore + 100;
            Console.WriteLine($"Player score : { myScore }");
        }
    }
}
