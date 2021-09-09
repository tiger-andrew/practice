using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        var dic = new Dictionary<string, string>();
        
        for(int i=0; i<n; i++)
        {
            string[] tmp = Console.ReadLine().Split(' ');
            dic.Add(tmp[0], tmp[1]);
        }
        
        foreach(var ele in dic)
        {
            Console.WriteLine(ele.Key + " " + ele.Value);
        }
    }
}
