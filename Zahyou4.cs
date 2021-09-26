using System;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ');
        // int x = int.Parse(nums[0]);
        // int y = int.Parse(nums[1]);
        // int n = int.Parse(nums[2]);
        int x = 38;
        int y = 47;
        int n = 27;
        int i=3;
        int k = 1;
        int d = 1;
        
        while(k==1)
        {
            if((i-2)*(i-2) < n && n < i * i)
            {
                break;
            }
            else
            {
                i += 2;
                d++;
            }
        }
        Console.WriteLine(d);
        
        
        if(n < i * i / 4)
        {
            x+=d;
            y += (n - 1 - i * i / 4);
        }
        else if(i * i / 4 < n && n < i * i * 2 / 4)
        {
            x -= (n - 1 - i * i / 4);
            y+=d;
        }
        else if(i * i * 2 / 4 < n && n < i * i * 3 / 4)
        {
            x-=d;
            y -= (n - 1 - i * i / 4);
        }
        else
        {
            x += (n - 1 - i * i / 4);
            y-=d;
        }
        
        Console.WriteLine(x + " " + y);
        
    }
}
