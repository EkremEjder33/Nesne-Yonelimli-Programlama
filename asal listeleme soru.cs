using System;
using System.Collections.Generic; 

class Program
{
    static void Main()
    {
        
        List<int> asalsayilar = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        Console.WriteLine("Girilen sayılardan oluşan asal sayılar:");

        
        foreach (int asalsayi in asalsayilar)
        {
            
            for (int i = 2; i <= asalsayi; i++)
            {
                if (AsalMi(i))
                {
                    Console.WriteLine(i + " asal sayidir");
                }
            }
        }
        
        Console.ReadLine(); 
    }

    
    static bool AsalMi(int sayi)
    {
        if (sayi < 2) return false;
        
        
        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
                return false;
        }
        return true;
    }
}