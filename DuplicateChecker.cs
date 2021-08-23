using System;

class Program
{
    static void Main()
    {
        string[] airPortList = {"HND", "NRT", "KIX", "NGO", "NGO"};
        
        bool duplicate = false;
        
        for(int n=0; n<airPortList.Length; n++)
        {
            for(int i=0; i<airPortList.Length; i++)
            {
                if(airPortList[n] == airPortList[i])
                {
                    duplicate = true;
                }
            }
        }
        
        Console.WriteLine(duplicate.ToString().ToLower());
    }
}
