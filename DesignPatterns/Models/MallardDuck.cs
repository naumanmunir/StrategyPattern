using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck");
        }
    }
}
