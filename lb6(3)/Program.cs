using System;

namespace ReverseDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Зчитуємо десяткове число з клавіатури
            Console.Write("Введіть десяткове число: ");
            double number = double.Parse(Console.ReadLine());

            // Розбиваємо число на цілу частину і дробову
            int integer = (int)number;
            double fraction = number - integer;

            // Виводимо цілу частину у зворотному порядку
            Console.Write("Число у зворотному порядку: ");
            while (integer > 0)
            {
                Console.Write(integer % 10);
                integer /= 10;
            }

            // Виводимо дробову частину
            Console.Write(".");
            string fractionString = fraction.ToString().TrimStart('0').TrimStart('.');
            for (int i = fractionString.Length - 1; i >= 0; i--)
            {
                Console.Write(fractionString[i]);
            }

            Console.WriteLine();
        }
    }
}
