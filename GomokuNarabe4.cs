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
        
            if(arr[0][0] == 'O' && arr[1][1] == 'O' && arr[2][2] == 'O' && arr[3][3] == 'O' && arr[4][4] == 'O')
            {
                res = 'O';
            }
            
            if(arr[4][0] == 'O' && arr[3][1] == 'O' && arr[2][2] == 'O' && arr[1][3] == 'O' && arr[0][4] == 'O')
            {
                res = 'O';
            }
        
            if(arr[0][0] == 'X' && arr[1][1] == 'X' && arr[2][2] == 'X' && arr[3][3] == 'X' && arr[4][4] == 'X')
            {
                res = 'X';
            }
            
            if(arr[4][0] == 'X' && arr[3][1] == 'X' && arr[2][2] == 'X' && arr[1][3] == 'X' && arr[0][4] == 'X')
            {
                res = 'X';
            }

        
        Console.WriteLine(res);
    }
}
