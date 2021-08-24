using System;

class Program
{
    
    
    static void Main()
    {
        int[] numArr = {1, 3, 5, 6, 3, 2, 5, 23, 2};
       
        
        //配列の回数分回す
        for (int i = 0; i < numArr.Length; i++)
        {
            //配列の回数分回す
            for (int j = i; j < numArr.Length; j++)
            {
                //比較元より大きければ入れ替え
                if (numArr[i] > numArr[j])
                {
                    int x = numArr[j];
                    numArr[j] = numArr[i];
                    numArr[i] = x;
                }
            }
        }
        
        
        foreach(int num in numArr)
        {
            Console.WriteLine(num);
        }
    }
    
    
}
