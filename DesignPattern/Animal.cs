using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Animal
    {
        protected string name = string.Empty;
        public Animal(string name)
        {
            this.name = name;
        }

        public Animal()
        {
            this.name = "无名";
        }

        protected int shoutNum = 3;

        public int ShoutNum
        {
            get => shoutNum;
            set => shoutNum = value > 10 ? 10 : value;
        }

        public virtual string Shout()
        {
            return string.Empty;
        }
    }
}
