using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var ele = Console.ReadLine();
        char[] alpha = {
            'A', 'B', 'C', 'D', 'E',
            'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'O',
            'P', 'Q', 'R', 'S', 'T',
            'U', 'V', 'W', 'X', 'Y',
            'Z'
        };
        
        char first = ele[0];
        char last = ele[ele.Length-1];
        
        
        int i=0;
        
        int n_first=0;
        int n_last=0;
        
        foreach(char c in alpha)
        {
            if(c.ToString() == first.ToString())
            {
                n_first = i;
            }
            
            if(c.ToString() == last.ToString())
            {
                n_last = i;
            }
            i++;
        }
        
        for(int j=0; j<26; j++)
        {
            if(j > n_first-1 && j < n_last+1)
            {
                Console.WriteLine(alpha[j]);
            }
        }
    }
}
