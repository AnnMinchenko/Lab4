/*
 Для раздачи домашних животных (вес)

Попугаи (цвет, количество выученных слов)
Собаки (порода, расстояние начиная с которого начинает игнорировать команды хозяина, длина хвоста)
Кошки (наличие шерсти, улов мышей в день)
*/

using System;


namespace Lab4
{
    public class Animal
    {
        public int Weight = 0;

        public static Random rnd = new Random();

        public virtual String GetInfo()
        {
            var str = String.Format("\nВес: {0}", this.Weight);
            return str;
        }
    }

    public enum ParrotColors { серый, зеленый, голубой, белый, красный, желтый };

    public class Parrot : Animal
    {
        public ParrotColors color = ParrotColors.желтый;
        public int wordsCount = 0;

        public override String GetInfo()
        {
            var str = "Я попугай";
            str += base.GetInfo();
            str += String.Format("\nЦвет: {0}", this.color);
            str += String.Format("\nЗнает слов: {0}", this.wordsCount);
            return str;
        }

  

        public static Parrot Generate()
        {
            return new Parrot
            {
                Weight = rnd.Next() % 900,
                wordsCount = rnd.Next() % 150,
                color = (ParrotColors)rnd.Next(6)
            };
        }
    }


    public enum DogBreeds { хаски, мопс, такса, корги, пудель, овчарка };

    public class Dog : Animal
    {
        public DogBreeds breed = DogBreeds.хаски;
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

        public static Dog Generate()
        {
            return new Dog
            {
                Weight = rnd.Next() % 9000, 
                tailLength = 5 + rnd.Next() % 20, 
                maxCommandDistance = rnd.Next() % 30, 
                breed = (DogBreeds)rnd.Next(6) 
            };
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
            str += String.Format("\nНаличие шерсти: {0}", this.hasWool ? "есть": "нет");
            str += String.Format("\nМышей в день: {0}", this.micePerDay);
            return str;
        }

        public static Cat Generate()
        {
            return new Cat
            {
                Weight = rnd.Next() % 7000,
                micePerDay = rnd.Next() % 15,
                hasWool = rnd.Next(2) == 0
            };
        }
    }
}