using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int answer = 0;
        
        for(int i=0; i<n; i++)
        {
            string[] tmpList = Console.ReadLine().Split(' ');
            int tmpNum = 0;
            if(int.Parse(tmpList[0]) == int.Parse(tmpList[1]))
            {
                tmpNum = int.Parse(tmpList[0]) * int.Parse(tmpList[1]);
            }
            else
            {
                tmpNum = int.Parse(tmpList[0]) + int.Parse(tmpList[1]);
            }
            
            answer += tmpNum;
        }
        
        Console.WriteLine(answer);
    }
}
