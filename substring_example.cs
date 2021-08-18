using System;

class Program
{
    static void Main()
    {
        string[] list = Console.ReadLine().Split(' ');
        int n1 = int.Parse(list[0]);
        int n2 = int.Parse(list[1]);
        
        string word = Console.ReadLine();
        
        string answer = word.Substring(n1-1, n2-n1+1);
        
        Console.WriteLine(answer);
    }
}
