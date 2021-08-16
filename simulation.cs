using System;

class Program
{
    
    static void Main()
    {
        int HP = int.Parse(Console.ReadLine());
        
        int[] a = {0,1,1};
        int[] b = {0,1,1};
        
        int dmg = 2;
        //HP -= 2;
        int cnt = 2;
        
        
        while(HP > dmg)
        {
            a[0] = a[1];
            a[1] = a[2];
            
            b[0] = b[1];
            b[1] = b[2];
            
            a[2] = b[1] + b[0];
            b[2] = a[1]*2 + a[0];
            
            dmg += b[2];
            cnt++;
        }
        
        Console.WriteLine(cnt);
    }
}
