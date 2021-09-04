using System;

class Program
{
    static void Main()
    {
        string[] arr = {"","","","","",""};
        for(int i=0; i<5; i++)
        {
            arr[i] = Console.ReadLine();
        }
        
        var res = 'D';
        
        for(int i=0; i<5; i++)
        {
            for(int j=0; j<5; j++)
            {
                 if(arr[0][i] == 'O' && arr[1][i] == 'O' && arr[2][i] == 'O' && arr[3][i] == 'O' && arr[4][i] == 'O')
                {
                    res = 'O';
                }
            
                if(arr[0][i] == 'X' && arr[1][i] == 'X' && arr[2][i] == 'X' && arr[3][i] == 'X' && arr[4][i] == 'X')
                {
                    res = 'X';
                }
            }

        }
        
        Console.WriteLine(res);
    }
}
