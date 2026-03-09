using System;
class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü sayıyı giriniz: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        int en_büyük = sayi1;

        if (sayi2 > en_büyük)
        {
            en_büyük = sayi2;
        }

        if (sayi3 > en_büyük)
        {
            en_büyük = sayi3;
        }

        Console.WriteLine($"En büyük sayı: {en_büyük}");
    }
}