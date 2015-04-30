﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
