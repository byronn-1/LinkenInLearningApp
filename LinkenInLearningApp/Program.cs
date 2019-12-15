using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkenInLearningApp
{
    class Program
    {
        public static int myScore;

        static void Main(string[] args)
        {
            myScore = 1000;
            ChangeScore();
        }

        public static void ChangeScore()
        {
            myScore = myScore + 100;
            Console.WriteLine($"Player score : { myScore }");
        }
    }
}
