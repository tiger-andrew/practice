using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var tmp = Console.ReadLine().Split(' ');
        int h = int.Parse(tmp[0]);
        int w = int.Parse(tmp[1]);
        var tmpLine = new List<string>();
        for(int i=0; i<h; i++)
        {
            tmpLine.Add(Console.ReadLine());
            for(int j=0; j<w; j++)
            {
                if(tmpLine[i][j] == '#')
                {
                    Console.WriteLine(i + " " + j);
                    break;
                }
            }
        }
    }
}
