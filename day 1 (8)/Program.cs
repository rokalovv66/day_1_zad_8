using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10; // здесь можно задать значение N
        int k = 1;
        int sum = 0;
        while (sum + k <= n)
        {
            sum += k;
            k++;
        }
        k--;

        Console.WriteLine("Наибольшее число K: " + k);
        Console.WriteLine("Сумма чисел от 1 до K: " + sum);

        Console.ReadKey();
    }
}
