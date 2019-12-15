using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkenInLearningApp;

namespace LinkenInLearningApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Cat pet = new Cat();
            pet.petName = "Rocket";
            pet.Speak();

            Console.WriteLine($"{pet.petName} is {pet.GetAge()} years old.");
        }   
    }
}
