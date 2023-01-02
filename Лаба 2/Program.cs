using System;
class HelloWorld
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        if (n * n > n * k)
        {
            return;
        }
        double sum1 = 0;
        double sum2 = 0;
        for (int i = n * n; i < n * k; ++i)
        {
            sum1 += (i * i - 3) / (Math.Pow(-1, i) * i * i + 5);
            sum2 += (i * i + Math.Pow(-1, i) * i - 1) / (i * i + 1);
        }
        Console.WriteLine(sum1);
        Console.WriteLine(sum2);
    }
}