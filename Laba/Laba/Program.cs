using System;

namespace Laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = ReadInt("Введите первое целое число: ");
            int b = ReadInt("Введите второе целое число: ");
        }

        static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    return number;
                }

                Console.WriteLine("Ошибка! Введите целое число.");
            }
        }
    }
}