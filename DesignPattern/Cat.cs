using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Cat
    {
        private string name = string.Empty;
        public Cat(string name)
        {
            this.name = name;
        }

        public Cat()
        {
            this.name = "无名";
        }

        private int shoutNum = 3;

        public int ShoutNum
        {
            get => shoutNum;
            set => shoutNum = value > 10 ? 10 : value;
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
