using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var tmp = Console.ReadLine().Split(' ');
        int H = int.Parse(tmp[0]);
        int W = int.Parse(tmp[1]);
        int sy = int.Parse(tmp[2]);
        int sx = int.Parse(tmp[3]);
        string dir = tmp[4];
        var map = new List<string>();
        
        for(int i=0; i<H; i++)
        {
            map.Add(Console.ReadLine());
        }
        
        if(dir=="N"){sy--;}
        if(dir=="E"){sx++;}
        if(dir=="W"){sx--;}
        if(dir=="S"){sy++;}
        
        for(int i=0; i<H; i++)
        {
            if(i==sy)
            {
                string targetLine = map[i].ToString();
                if(targetLine[sx].ToString()=="#")
                {
                    Console.WriteLine("No");
                }else
                {
                    Console.WriteLine("Yes");
                }
            }
        }
        
    }
}
