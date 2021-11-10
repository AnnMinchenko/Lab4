/*
 Для раздачи домашних животных (вес)

Попугаи (цвет, количество выученных слов)
Собаки (порода, расстояние начиная с которого начинает игнорировать команды хозяина, длина хвоста)
Кошки (наличие шерсти, улов мышей в день)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    public class Animal
    {
        public int Weight = 0;

        public virtual String GetInfo()
        {
            var str = String.Format("\nВес: {0}", this.Weight);
            return str;
        }
    }

    public enum ParrotColors { black, green, blue, white, red, yellow };

    public class Parrot : Animal
    {
        public ParrotColors color = ParrotColors.black;
        public int wordsCount = 0;

        public override String GetInfo()
        {
            var str = "Я попугай";
            str += base.GetInfo();
            str += String.Format("\nЦвет: {0}", this.color);
            str += String.Format("\nЗнает слов: {0}", this.wordsCount);
            return str;
        }
    }


    public enum DogBreeds { husky, mops, taksa, corgi, pudel, ovcharka };

    public class Dog : Animal
    {
        public DogBreeds breed = DogBreeds.husky;
        public int maxCommandDistance = 0;
        public int tailLength = 0;

        public override String GetInfo()
        {
            var str = "Я пес";
            str += base.GetInfo();
            str += String.Format("\nПорода: {0}", this.breed);
            str += String.Format("\nМакс. расстояние команд: {0}", this.maxCommandDistance);
            str += String.Format("\nДлина хвоста: {0}", this.tailLength);
            return str;
        }
    }

    
    public class Cat : Animal
    {
        public bool hasWool = false;
        public int micePerDay = 0;

        public override String GetInfo()
        {
            var str = "Я кот";
            str += base.GetInfo();
            str += String.Format("\nНаличие шерсти: {0}", this.hasWool);
            str += String.Format("\nМышей в день: {0}", this.micePerDay);
            return str;
        }
    }
}