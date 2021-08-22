using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int cnt = int.Parse(Console.ReadLine());
        var charAndNum = new Dictionary<string, int>();
        
        for(int i=0; i<cnt; i++)
        {
            var tmpList = Console.ReadLine().Split(' ');
            charAndNum.Add(tmpList[0], int.Parse(tmpList[1]));
        }
        
        for(int i=0; i<cnt; i++)
        {
            var minNum = charAndNum.Values.Min();
            var pair = charAndNum.FirstOrDefault( c => c.Value == minNum );
            Console.WriteLine( pair.Key );
            
            charAndNum.Remove(pair.Key);
        }
    }
}
