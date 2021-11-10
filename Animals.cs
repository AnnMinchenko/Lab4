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
    }

    public enum ParrotColors { black, green, blue, white, red, yellow };

    public class Parrot : Animal
    {
        public ParrotColors color = ParrotColors.black;
        public int wordsCount = 0;
    }


    public enum DogBreeds { husky, mops, taksa, corgi, pudel, ovcharka };

    public class Dog : Animal
    {
        public DogBreeds breed = DogBreeds.husky;
        public int maxCommandDistance = 0;
        public int tailLength = 0; 
    }

    
    public class Cat : Animal
    {
        public bool hasWool = false;
        public int micePerDay = 0; 
    }
}