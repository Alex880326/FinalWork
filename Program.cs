using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделяя их запятой:");
        string input = Console.ReadLine();

        string[] array = input.Split(',');
        string[] newArray = new string[array.Length];

        int j = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[j] = array[i];
                j++;
            }
        }
    }
}