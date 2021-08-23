using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string[] airPortList = {"HND", "NRT", "KIX", "NGO", "NGO", "NGO", "NGO", "NGO"};
        bool duplicate = false;
        int cnt = 0;
        string duplicateWord = "";
        
        for(int n=0; n<airPortList.Length; n++)
        {
            for(int i=0; i<airPortList.Length; i++)
            {
                if(airPortList[n] == airPortList[i])
                {
                    duplicateWord = airPortList[n];
                    break;
                }
            }
        }
        
        for(int i=0; i<airPortList.Length; i++)
        {
            if(airPortList[i] == duplicateWord)
            {
                cnt++;
            }
        }
        
        Console.WriteLine(cnt);
    }
}
