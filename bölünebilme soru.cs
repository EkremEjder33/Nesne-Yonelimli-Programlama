using System;
class Program
{
    static void Main()
    {
        Console.Write("a sayısını giriniz: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b sayısını giriniz: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (b != 0)
        {
            if (a % b == 0)
            {
                Console.WriteLine($"{a} sayısı {b} sayısına tam bölünür.");
            }
            else
            {
                Console.WriteLine($"{a} sayısı {b} sayısına tam bölünmez.");
            }
        }
        else
        {
            Console.WriteLine("b sayısı sıfır olamaz.");
        }
    }
}