using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Github_Demo
{
    abstract class About
    {
        abstract void Speak();
    }
    class Cat : About
    {
        public override void Speak() 
        {
            Console.WriteLine("Meo meo...");
        }
}
