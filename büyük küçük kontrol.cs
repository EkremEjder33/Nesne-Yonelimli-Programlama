using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bir sayı giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine());

        while (sayi <= 10)
        {
            Console.WriteLine("Girdiğiniz sayı 10'dan küçük veya eşit. Lütfen tekrar deneyin:");
            sayi = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Tebrikler! Girdiğiniz sayı 10'dan büyük.");
        Console.ReadLine();
    }
}