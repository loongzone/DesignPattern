using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Cat : Animal
    {

        public Cat() : base()
        {
        }

        public Cat(string name) : base(name)
        {

        }

        public override string getShoutSound()
        {
            return "喵";
        }
    }
}
