using System;

class Program
{
    static void Main()
    {
        Console.Write("Kaça kadar olan asal sayıları görmek istersiniz? ");

        int limit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"2 ile {limit} arasındaki asal sayılar:");

        for (int i = 2; i <= limit; i++)
        {
            bool asalMi = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    asalMi = false;
                    break;
                }
            }

            if (asalMi)
            {
                Console.WriteLine(i); 
            }
        }
        
        Console.ReadLine(); 
    }
}