using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Animal[] arrayAnimal;

        private void button1_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("咪咪");
            MessageBox.Show(cat.Shout());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog()
            {
                ShoutNum = 5
            };

            MessageBox.Show(dog.Shout());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arrayAnimal = new Animal[5];
            arrayAnimal[0] = new Cat("小花");
            arrayAnimal[1] = new Dog("小汪");
            arrayAnimal[2] = new Cat("小黑");
            arrayAnimal[3] = new Dog("汪汪");
            arrayAnimal[4] = new Cat("咪咪");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Animal item in arrayAnimal)
            {
                MessageBox.Show(item.Shout());
            }
        }
    }
}
