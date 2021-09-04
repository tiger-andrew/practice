using System;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine();
        if(line[0] == 'O' && line[1] == 'O' && line[2] == 'O' && line[3] == 'O' && line[4] == 'O')
        {
            Console.WriteLine('O');
        }
        else if(line[0] == 'X' && line[1] == 'X' && line[2] == 'X' && line[3] == 'X' && line[4] == 'X')
        {
            Console.WriteLine('X');
        }
        else
        {
            Console.WriteLine('D');
        }
    }
}
