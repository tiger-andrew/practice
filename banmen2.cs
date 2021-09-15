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
        
        var zahyouDic = new List<List<int>>();;
        
        for(int i=0; i < n; i++)
        {
            var ab = Console.ReadLine().Split(' ');
            
            zahyouDic.Add(new List<int>());
            
            for(int j=0; j < 2; j++)
            {
                zahyouDic[i].Add(int.Parse(ab[j]));
            }
        }
        
        
        
        
        foreach(var ele in zahyouDic)
        {
            
            
            int y = ele[0];
            int x = ele[1];
            string targetLine = masuList[y];
            
            string convertedTargetLine = "";
            
            for(int i=0; i<targetLine.Length;i++)
            {
                char c = targetLine[i];
                if(i==x)
                {
                    c = '#';
                }
                
                convertedTargetLine += c.ToString();
            }
            
            masuList[y] = convertedTargetLine;
        }
        

        foreach(var ele in masuList)
        {
            Console.WriteLine(ele);
        }
    }
}
