using System;

namespace ReverseArray
{
    class Program
    {
        // Метод для реверсу масиву
        static int[] ReverseArray(int[] array)
        {
            int[] reverse = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reverse[i] = array[array.Length - i - 1];
            }
            return reverse;
        }

        static void Main(string[] args)
        {
            // Створюємо тестовий масив
            int[] array = { 1, 2, 3, 4, 5 };

            // Виводимо масив у зворотному порядку
            Console.WriteLine("Масив у зворотному порядку: " + string.Join(", ", ReverseArray(array)));
        }
    }
}
