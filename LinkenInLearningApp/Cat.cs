using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkenInLearningApp
{
    class Cat
    {
        public string petName;
        private int age; 

        public Cat()
        {
            Console.WriteLine("A new instance of cat created ");

        }
        public void Speak()
        {
            Console.WriteLine($"{petName} says, \"Meow\"");
        }

        public int GetAge()
        {
            return age;
        }
    }
}
