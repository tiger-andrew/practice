using System;

class Program
{
    static void Main()
    {
        char[] alpha = {
            'A', 'B', 'C', 'D', 'E',
            'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'O',
            'P', 'Q', 'R', 'S', 'T',
            'U', 'V', 'W', 'X', 'Y',
            'Z'
        };
        
        var n1 = Console.ReadLine();
        var n2 = Console.ReadLine();
        var n3 = Console.ReadLine();
        
        
        int firstNum = 0;
        int lastNum = 0;
        int targetNum = 0;
        
        for(int i=0; i<26; i++)
        {
            if(n1 == alpha[i].ToString())
            {
                firstNum = i;
            }
            
            if(n2 == alpha[i].ToString())
            {
                lastNum = i;
            }
            
            if(n3 == alpha[i].ToString())
            {
                targetNum = i;
            }
        }
        
        var flg = "false";
        
        if(targetNum >= firstNum && targetNum <= lastNum)
        {
            flg = "true";
        }
        
        Console.WriteLine(flg);
        
    }
}
