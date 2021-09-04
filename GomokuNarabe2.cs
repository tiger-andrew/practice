using System;

class Program
{
    static void Main()
    {
        
        
        var res = 'D';
        
        for(int i=0; i<5; i++)
        {
            var line = Console.ReadLine();
            
            if(line == "OOOOO")
            {
                res = 'O';
                break;
            }
            else if(line == "XXXXX")
            {
                res = 'X';
                break;
            }
        }

        
        Console.WriteLine(res);
    }
}
