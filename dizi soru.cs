using System;

class Program
{
    static void Main()
    {
        int[] sayilar = new int[5];
        int toplam = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Bir sayı giriniz:");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
            toplam += sayilar[i];
        }

        Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);
        Console.ReadLine();
    }
}