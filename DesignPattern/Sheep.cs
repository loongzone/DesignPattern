using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Sheep : Animal
    {
        public Sheep() : base()
        {
        }

        public Sheep(string name) : base(name)
        {

        }

        public override string getShoutSound()
        {
            return "咩";
        }
    }
}
