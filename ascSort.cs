using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        var input = Console.ReadLine().Split(' ');
        
        //配列の回数分回す
        for (int i = 0; i < input.Length; i++)
        {
            //配列の回数分回す
            for (int j = i; j < input.Length; j++)
            {
                //比較元より大きければ入れ替え
                if (int.Parse(input[i]) > int.Parse(input[j]))
                {
                    int x = int.Parse(input[j]);
                    input[j] = input[i];
                    input[i] = x.ToString();
                }
            }
        }
        
        foreach(string ele in input)
        {
            Console.WriteLine(ele);
        }
    }
}
