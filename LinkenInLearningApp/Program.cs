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
            Console.WriteLine($"setting the score to {myScore}");
            DisplayScore();
            ChangeScore(100);
            ChangeScore(50);
            ChangeScore(-250);
            ChangeScore(125);
        }

        public static void ChangeScore(int scoreDelta)
        {
            Console.WriteLine($"changing the score by {scoreDelta}");
            myScore = myScore + scoreDelta;
            DisplayScore();
        }

        public static void DisplayScore()
        {
            Console.WriteLine($"Player score : { myScore }");

        }
    }
}
