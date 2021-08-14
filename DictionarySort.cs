using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

class Program
{
    static void Main()
    {
        int cntNames = int.Parse(Console.ReadLine());
        
        // 名前とダメージが対応する辞書を作成
        // 辞書では値の更新ができないため、連想配列を作成
        // ハッシュテーブルのValueはobject型のため、加算ができない。
        // やっぱ辞書型でないといけない。
        var nameAndDmg = new Dictionary<string, int>();
        
        // 辞書に入力値を追加していく（ダメージは初期値0）
        for(int i=0; i<cntNames; i++)
        {
            nameAndDmg.Add(Console.ReadLine(), 0);
        }
        
        
        int cntDmgs = int.Parse(Console.ReadLine());
        
        for(int i=0; i<cntDmgs; i++)
        {
            string[] tmpList = Console.ReadLine().Split(' ');
            nameAndDmg[tmpList[0]] += int.Parse(tmpList[1]);
        }
        
        // string answerName = Console.ReadLine();
        
        // FirstOrDefault を使用することで値からキーを取得できます
        //var pair = nameAndDmg.FirstOrDefault();
        
        //nameAndDmg.
        
        foreach(var pair in nameAndDmg.OrderBy(c => c.Key))
        {
            Console.WriteLine( pair.Value );
        }
    }
}