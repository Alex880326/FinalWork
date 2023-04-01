using System;

namespace ArraysExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива через запятую:");
            string input = Console.ReadLine();
            string[] array = input.Split(',');

            string[] shortStrings = new string[array.Length];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    shortStrings[index] = array[i];
                    index++;
                }
            }

            Console.Write("[");
            for (int i = 0; i < index; i++)
            {
                Console.Write(shortStrings[i]);
                if (i != index - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }
} 