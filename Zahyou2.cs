using System;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ');
        int y = int.Parse(nums[0]);
        int x = int.Parse(nums[1]);
        int n = int.Parse(nums[2]);
        
        for(int i=0; i<n; i++)
        {
            string direction = Console.ReadLine();
            switch(direction)
            {
                case "N":
                    y --;
                    break;
                case "E":
                    x ++;
                    break;
                case "W":
                    x --;
                    break;
                case "S":
                    y ++;
                    break;
            }
            Console.WriteLine(y + " " + x);
            
        }
    }
}
