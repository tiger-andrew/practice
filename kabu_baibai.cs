using System;

class Program
{
    static void Main()
    {
        var line1 = Console.ReadLine().Split(' ');
        int n = int.Parse(line1[0]);
        int c_1 = int.Parse(line1[1]);
        int c_2 = int.Parse(line1[2]);
        int sontoku = 0;
        int mochikabu = 0;
        
        for(int i=0; i<n; i++)
        {
            int tmpKabuka = int.Parse(Console.ReadLine());
            if(tmpKabuka <= c_1)
            {
                sontoku -= tmpKabuka;
                mochikabu++;
            }else if(tmpKabuka >= c_2)
            {
                sontoku += mochikabu * tmpKabuka;
                mochikabu = 0;
            }
            
            if(i == n-1)
            {
                sontoku += mochikabu * tmpKabuka;
                mochikabu = 0;
            }
        }
        
        Console.WriteLine(sontoku);
    }
}
