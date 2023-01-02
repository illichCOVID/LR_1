using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Зчитуємо строку з клавіатури
            Console.Write("Введіть строку: ");
            string input = Console.ReadLine();

            // Виводимо строку у зворотному порядку
            Console.Write("Строка у зворотному порядку: ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }

            Console.WriteLine();
        }
    }
}
