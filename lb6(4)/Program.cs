using System;

namespace ReverseStringWithDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Зчитуємо строку з клавіатури
            Console.Write("Введіть строку: ");
            string input = Console.ReadLine();

            // Знаходимо перший вхідження "магічного знаку" у строку
            int delimiterIndex = input.IndexOf(',');

            // Виводимо частину строки перед "магічним знаком" у зворотному порядку
            Console.Write("Строка у зворотному порядку: ");
            for (int i = delimiterIndex - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }

            // Виводимо "магічний знак"
            Console.Write(",");

            // Виводимо частину строки після "магічного знаку" у зворотному порядку
            for (int i = input.Length - 1; i > delimiterIndex; i--)
            {
                Console.Write(input[i]);
            }

            Console.WriteLine();
        }
    }
}
