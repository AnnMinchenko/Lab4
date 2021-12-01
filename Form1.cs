using System;
using System.Collections.Generic;
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
                        this.animalsList.Add(Parrot.Generate());
                        break;
                    case 1: 
                        this.animalsList.Add(Dog.Generate());
                        break;
                    case 2: 
                        this.animalsList.Add(Cat.Generate());
                        break;
                }
            }
            ShowInfo();
            ShowQueue();
        }

        private void ShowQueue()
        {
            foreach (var animal in this.animalsList)
            {
                if (animal is Parrot)
                {
                    txtQueue.Text += "Попугай\n";
                }
                else if (animal is Dog)
                {
                    txtQueue.Text += "Пес\n";
                }
                else if (animal is Cat)
                {
                    txtQueue.Text += "Кот\n";
                }
            }
        }

        private void ShowInfo()
        {
            int parrotCount = 0;
            int dogCount = 0;
            int catCount = 0;

            foreach (var animal in this.animalsList)
            {
                if (animal is Parrot) 
                {
                    parrotCount += 1;
                }
                else if (animal is Dog)
                {
                    dogCount += 1;
                }
                else if (animal is Cat)
                {
                    catCount += 1;
                }
            }

            txtInfo.Text = "Попугаи\t Собаки\t Коты"; 
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("   {0}\t    {1}\t    {2}", parrotCount, dogCount, catCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.animalsList.Count == 0)
            {
                txtOut.Text = "Пусто (ಥ﹏ಥ)";
                return;
            }

            var animal = this.animalsList[0];

            this.animalsList.RemoveAt(0);

            txtOut.Text = animal.GetInfo();

            ShowInfo();
            txtQueue.Text = "";
            ShowQueue();

            
        }

        
    }

    
}
