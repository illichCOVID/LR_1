using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Зчитуємо число з клавіатури
            Console.Write("Введіть число: ");
            int number = int.Parse(Console.ReadLine());

            // Виводимо число у зворотному порядку
            Console.Write("Число у зворотному порядку: ");
            while (number > 0)
            {
                Console.Write(number % 10);
                number /= 10;
            }

            Console.WriteLine();
        }
    }
}
