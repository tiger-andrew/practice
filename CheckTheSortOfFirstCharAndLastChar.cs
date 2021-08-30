using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        string first = line[0].ToString();
        string last = line[line.Length-1].ToString();
        
        char[] alpha = {
            'A', 'B', 'C', 'D', 'E',
            'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'O',
            'P', 'Q', 'R', 'S', 'T',
            'U', 'V', 'W', 'X', 'Y',
            'Z'
        };
        
        int firstNum = 0;
        int lastNum = 0;
        
        for(int i=0; i<26; i++)
        {
            if(first == alpha[i].ToString())
            {
                firstNum = i;
            }
            
            if(last == alpha[i].ToString())
            {
                lastNum = i;
            }
        }
        
        
        bool flg = false;
        
        if(firstNum < lastNum)
        {
            flg = true;
        }
        Console.WriteLine(flg.ToString().ToLower());
    }
}
