using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Cat:Animal
    {

        public Cat() : base()
        {
        }

        public Cat(string name) : base(name)
        {

        }

        public string Shout()
        {
            string result = string.Empty;
            for (int i = 0; i < shoutNum; i++)
            {
                result += "喵 ";
            }
            return "我的名字叫" + name + " "  + result;
        }
    }
}
