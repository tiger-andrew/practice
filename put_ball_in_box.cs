using System;

class Program
{
    static void Main()
    {
        var line1 = Console.ReadLine().Split(' ');
        int n = int.Parse(line1[0]);
        int r = int.Parse(line1[1]);
        
        for(int i=1; i<=n; i++)
        {
            var tmpLine = Console.ReadLine().Split(' ');
            int h = int.Parse(tmpLine[0]);
            int w = int.Parse(tmpLine[1]);
            int d = int.Parse(tmpLine[2]);
            
            if(r*2 <= h && r*2 <= w && r*2 <= d)
            {
                Console.WriteLine(i);
            }
        }
    }
}
