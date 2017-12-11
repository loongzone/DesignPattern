using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Cattle : Animal
    {
        public Cattle() : base()
        {
        }

        public Cattle(string name) : base(name)
        {

        }

        public override string getShoutSound()
        {
            return "哞";
        }
    }
}
