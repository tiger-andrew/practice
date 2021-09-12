using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] tmpNum = Console.ReadLine().Split(' ');
        int h = int.Parse(tmpNum[0]);
        int w = int.Parse(tmpNum[1]);
        int n = int.Parse(tmpNum[2]);
        
        var masuList = new List<string>();
        
        for(int i=0; i < h; i++)
        {
            masuList.Add(Console.ReadLine());
        }
        
        var zahyouDic = new Dictionary<int,int>();
        
        for(int i=0; i < n; i++)
        {
            var tmp = Console.ReadLine().Split(' ');
            zahyouDic.Add(int.Parse(tmp[0]), int.Parse(tmp[1]));
        }
        
        foreach(var ele in zahyouDic)
        {
            int y = ele.Key;
            int x = ele.Value;
            string targetLine = masuList[y];
            Console.WriteLine(targetLine[x]);
        }
        
    }
}
