using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var ab = Console.ReadLine().Split(' ');
        
        int a = int.Parse(ab[0]);
        int b = int.Parse(ab[1]);
        
        var tmpNum1 = 1;
        var tmpNum2 = 1;
        var cnt = 0;
        
        while(tmpNum2 <= n)
        {
            tmpNum2 += tmpNum1 * a;
            cnt++;
            tmpNum1 += tmpNum2 % b;
        }
        
        Console.WriteLine(cnt);
    }
}
