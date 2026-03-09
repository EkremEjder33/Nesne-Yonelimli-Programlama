using System;
class Program
{
    static void Main()
    {
        Console.Write("Haftanın gününü giriniz (1-7): ");
        int gün = Convert.ToInt32(Console.ReadLine());

        switch (gün)
        {
            case 1:
                Console.WriteLine("pazartesi");
                break;
            case 2:
                Console.WriteLine("salı");
                break;
            case 3:
                Console.WriteLine("çarşamba");
                break;
            case 4:
                Console.WriteLine("perşembe");
                break;
            case 5:
                Console.WriteLine("cuma");
                break;
            case 6:
                Console.WriteLine("cumartesi");
                break;
            case 7:
                Console.WriteLine("pazar");
                break;
            default:
                Console.WriteLine("geçersiz giriş. Lütfen 1 ile 7 arasında bir sayı giriniz.");
                break;
        }
    }
}