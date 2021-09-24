using System;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ');
        int y = int.Parse(nums[0]);
        int x = int.Parse(nums[1]);
        string direction = nums[2];
        string side = Console.ReadLine();
        
        switch(direction)
        {
            case "N":
                if(side == "R")
                {
                    x++;
                }
                else
                {
                    x--;
                }
                break;
            case "E":
                if(side == "R")
                {
                    y++;
                }
                else
                {
                    y--;
                }
                break;
            case "W":
                if(side == "R")
                {
                    y--;
                }
                else
                {
                    y++;
                }
                break;
            case "S":
                if(side == "R")
                {
                    x--;
                }
                else
                {
                    x++;
                }
                break;
        }
        Console.WriteLine(y + " " + x);
    }
}
