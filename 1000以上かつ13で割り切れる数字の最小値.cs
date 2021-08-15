using System;

class Program
{
    static void Main()
    {
        int n = 10000;
        
        while(n % 13 != 0)
        {
            n++;
        }
        
        Console.WriteLine(n);
    }
}