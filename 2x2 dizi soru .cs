using System;
using System.Data.Common;

class Program
{
    static void Main()
    {
        int[,] dizi=new int[2,2];
        int toplam=0;
        for (int i=0; i<2;i++)
        {
            for (int j=0;j<2;j++)
            {
                Console.WriteLine("Bir sayı giriniz:");
                dizi[i,j]=Convert.ToInt32(Console.ReadLine());
                toplam+=dizi[i,j];
            }
        }
        Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);
        Console.ReadLine();
    }
}