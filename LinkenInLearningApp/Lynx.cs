using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkenInLearningApp
{
    class Lynx : Cat
    {
        public Lynx()
        {
            Console.WriteLine("A new instatnce of Lynx Created!");
        }

        public void Growl()
        {
            Console.WriteLine("Grrrrr!");
        }
    }
}
