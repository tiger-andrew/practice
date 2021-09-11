using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var name = Console.ReadLine();
        int m = int.Parse(Console.ReadLine());
        var dicPeople = new Dictionary<string, string>();
        
        for(int i=0; i<m; i++)
        {
            string[] tmp = Console.ReadLine().Split(' ');
            dicPeople.Add(tmp[0], tmp[1]);
        }
        
        int n = int.Parse(Console.ReadLine());
        var dicResult = new Dictionary<string, string>();
        
        for(int i=0; i<n; i++)
        {
            string[] tmp = Console.ReadLine().Split(' ');
            dicResult.Add(tmp[0], tmp[1]);
        }
        
        var target = "";
        
        foreach(var ele in dicPeople)
        {
            if(ele.Key == name)
            {
                target = ele.Value;
            }
        }
        
        foreach(var ele in dicResult)
        {
            if(ele.Key == target)
            {
                Console.WriteLine(ele.Value);
            }
        }
    }
}
