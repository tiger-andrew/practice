using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
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
        
        //var target = "";
        var targetList = new List<string>();
        
        foreach(var eleP in dicPeople)
        {
            foreach(var eleR in dicResult)
            {
                if(eleP.Value == eleR.Key)
                {
                    Console.WriteLine(eleP.Key + " " + eleR.Value);
                }
            }
        }
    }
}
