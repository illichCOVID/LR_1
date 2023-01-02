using System;

namespace SortArray
{
    class Program
    {
        // Метод для сортування масиву по зростанню
        static int[] SortAscending(int[] array)
        {
            // Сортуємо масив за допомогою методу Array.Sort()
            Array.Sort(array);
            return array;
        }

        // Метод для сортування масиву по спаданню
        static int[] SortDescending(int[] array)
        {
            // Сортуємо масив за допомогою методу Array.Sort() і замінюємо його на зворотній
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }

        static void Main(string[] args)
        {
            // Створюємо тестовий масив
            int[] array = { 3, 5, 2, 1, 4 };

            // Виводимо масив впорядкований по зростанню
            Console.WriteLine("Масив впорядкований по зростанню: " + string.Join(", ", SortAscending(array)));

            // Виводимо масив впорядкований по спаданню
            Console.WriteLine("Масив впорядкований по спаданню: " + string.Join(", ", SortDescending(array)));
        }
    }
}
