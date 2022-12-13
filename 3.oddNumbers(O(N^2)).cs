using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        bool flag=false;
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        for(int i=0; i<A.Length;i++)
        {
            int temp =A[i] ;
            if(temp!=0)
            {
                for(int j=i+1; j<A.Length&&!flag;j++)
                {
                    if(A[j]==temp)
                    {
                        A[j]=0;
                        flag= true;
                        //Console.Write(temp);
                        //Console.Write(" ");
                       // Console.WriteLine(j);

                    }
                }
                if(!flag)
                    return temp;      
            }
            flag=false;
        }        
        return -1;
    }
}
