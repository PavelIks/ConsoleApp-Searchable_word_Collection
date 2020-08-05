using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> fruits = new Dictionary<string, string>();
            fruits.Add("Apricot", "A woody garden plant of the almond family that produces fruit.");
            fruits.Add("Banana", "A tall tropical plant with large leaves, as well as its elongated and slightly curved sweet mealy fruit growing in coplodium.");
            fruits.Add("Apple", "The most common fruits in Russia, apples are rich in vitamins and are stored for a long time, which makes them indispensable in the long Russian winter.");
            fruits.Add("Pear", "Fruit tree of the Rosaceae family with rounded elongated and expanding downwards fruits, as well as the fruit of this tree.");
            fruits.Add("Peach", "Southern fruit tree of the Rosaceae family, giving juicy fleshy fruits with a fluffy skin and a large stone, as well as its.");
            fruits.Add("Watermelon", "Melon plant of the pumpkin family with large spherical sweet fruits, as well as its fruit.");

            string userInput = "";

            while (true)
            {
                Console.Write("Введите название фрукта: ");
                userInput = Console.ReadLine();

                if (fruits.ContainsKey(userInput))
                {
                    Console.WriteLine(fruits[userInput]);
                }
                else
                {
                    Console.WriteLine("Фрукт не найден!");
                }
            }
        }
    }
}