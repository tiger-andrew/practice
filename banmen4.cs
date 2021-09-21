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
        
        
        for(int i=0; i<h; i++)
        {
            for(int j=0; j<w; j++)
            {
               if(i==0 || masuList[i-1][j].ToString()=="#")
               {
                   if(i==h-1 || masuList[i+1][j].ToString()=="#")
                   {
                       Console.WriteLine(i +" "+ + j);
                   }
               }
            }
        }
    }
}
