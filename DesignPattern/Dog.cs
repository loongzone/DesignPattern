﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Dog : Animal
    {
        public Dog() : base()
        {
        }
        public Dog(string name) : base(name) { }


        public override string getShoutSound()
        {
            return "汪";
        }
    }
}
