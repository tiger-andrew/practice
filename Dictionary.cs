using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var dic = new Dictionary<string, string>();
        
        dic.Add("Kyoko", "B");
        dic.Add("Rio", "O");
        dic.Add("Tsubame", "AB");
        dic.Add("KurodaSensei", "A");
        dic.Add("NekoSensei", "A");
        
        foreach(var ele in dic)
        {
            Console.WriteLine(ele.Key + " " + ele.Value);
        }
    }
}
