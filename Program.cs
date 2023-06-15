using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть опцію:");
        Console.WriteLine("1. Конвертувати з Фаренгейта в Цельсій");
        Console.WriteLine("2. Конвертувати з Цельсія в Фаренгейт");

        int option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Console.WriteLine("Введіть температуру в Фаренгейтах:");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Температура в Цельсіях: " + celsius);
        }
        else if (option == 2)
        {
            Console.WriteLine("Введіть температуру в Цельсіях:");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Температура в Фаренгейтах: " + fahrenheit);
        }
        else
        {
            Console.WriteLine("Неправильний вибір опції.");
        }
    }
}
