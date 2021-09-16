using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var tmp = Console.ReadLine().Split(' ');
        int h = int.Parse(tmp[0]);
        int w = int.Parse(tmp[1]);
        
        var masuList = new List<string>();
        
        for(int i=0; i < h; i++)
        {
            masuList.Add(Console.ReadLine());
        }
        
        int m = 0;
        
        foreach(var ele in masuList)
        {
            for(int i=0; i<w; i++)
            {
                if(i == 0 && ele[1].ToString() == "#")
                {
                    Console.WriteLine(m + " " + i);
                }
                
                if(i == w-1 && ele[w-2].ToString() == "#")
                {
                    Console.WriteLine(m + " " + i);
                }
                
                if(i != 0 && i != w-1)
                {
                    if(ele[i-1].ToString() == "#" && ele[i+1].ToString() == "#")
                    {
                        Console.WriteLine(m + " " + i);
                    }
                }
            }
            m++;
        }
    }
}
