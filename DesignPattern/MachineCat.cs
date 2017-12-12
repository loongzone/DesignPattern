using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class MachineCat : Cat, IChange
    {
        public MachineCat() : base() { }
        public MachineCat(string name) : base(name) { }
        public string ChangeThing(string thing)
        {
            return base.Shout() + "我有万能口袋，我可变出：" + thing;
        }
    }
}
