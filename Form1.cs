using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        List<Animal> animalsList = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.animalsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) 
                {
                    case 0: 
                        this.animalsList.Add(new Parrot());
                        break;
                    case 1: 
                        this.animalsList.Add(new Dog());
                        break;
                    case 2: 
                        this.animalsList.Add(new Cat());
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int parrotCount = 0;
            int dogCount = 0;
            int catCount = 0;

            foreach (var fruit in this.animalsList)
            {
                if (fruit is Parrot) 
                {
                    parrotCount += 1;
                }
                else if (fruit is Dog)
                {
                    dogCount += 1;
                }
                else if (fruit is Cat)
                {
                    catCount += 1;
                }
            }

            // а ну и вывести все это надо на форму
            txtInfo.Text = "Попуги\tПесы\tКиты"; // буквы экнмлю, чтобы влезло на форму
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", parrotCount, dogCount, catCount);
        }
    }

    
}
