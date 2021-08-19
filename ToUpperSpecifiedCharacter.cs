using System;

class Program
{
    static void Main()
    {
        string[] line = Console.ReadLine().Split(' ');
        int n1 = int.Parse(line[0]);
        int n2 = int.Parse(line[1]);
        var answer = "";
        
        
        string words = Console.ReadLine();
        
        string[] wordsList;
        
        
        for(int i=0; i < words.Length; i++)
        {
            if(i+1 >= n1 && i <= n2-1 )
            {
                answer += Char.ToUpper(words[i]);
            }
            else
            {
                answer += words[i];
            }
            
        }
        
        Console.WriteLine(answer);
    }
}
