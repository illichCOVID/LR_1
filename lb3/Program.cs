using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four-digit number:");
            int number = int.Parse(Console.ReadLine());

            int firstTwoDigits = number / 100; // отримуємо перші дві цифри числа
            int lastTwoDigits = number % 100; // отримуємо останні дві цифри числа

            int sumOfFirstTwo = firstTwoDigits / 10 + firstTwoDigits % 10; // сума перших двох цифр
            int sumOfLastTwo = lastTwoDigits / 10 + lastTwoDigits % 10; // сума останніх двох цифр

            bool statementIsTrue = sumOfFirstTwo == sumOfLastTwo; // перевіряємо істинність вислову

            Console.WriteLine("Твердження: 'Сума перших двох цифр числа дорівнює сумі двох його останніх цифр.' є " + statementIsTrue);
        }
    }
}
