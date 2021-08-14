using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var A_cnt = int.Parse(line[0]);
        var B_cnt = int.Parse(line[1]);
        var C_cnt = int.Parse(line[2]);
        
        var A_B_Dictionary = new Dictionary<int, int>();
        var B_C_Dictionary = new Dictionary<int, int>();
        
        for(int i=0; i<A_cnt; i++)
        {
            var tmpPair = Console.ReadLine().Split(' ');
            A_B_Dictionary.Add(int.Parse(tmpPair[0]), int.Parse(tmpPair[1]));
        }
        
        for(int i=0; i<B_cnt; i++)
        {
            var tmpPair = Console.ReadLine().Split(' ');
            B_C_Dictionary.Add(int.Parse(tmpPair[0]), int.Parse(tmpPair[1]));
        }
        
        for(int i=1; i<A_cnt+1; i++)
        {
            int[] tmpA_B = new int[2];
            tmpA_B[0] = i;
            tmpA_B[1] = A_B_Dictionary.FirstOrDefault( c => c.Key == i ).Value;
            
            int[] tmpB_C = new int[2];
            tmpB_C[0] = tmpA_B[1];
            tmpB_C[1] = B_C_Dictionary.FirstOrDefault( c => c.Key == tmpB_C[0] ).Value;
            
            Console.WriteLine(tmpA_B[0] + " " + tmpB_C[1]);
        }
        
        
    }
}