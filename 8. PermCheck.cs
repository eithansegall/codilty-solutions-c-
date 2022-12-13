using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int X= A.Length;
       bool[] flags= new bool[X];
        for(int i=0;i<A.Length;i++)
        {
            if(A[i]>A.Length)
                return 0;
            if(!flags[A[i]-1])
            {
                flags[A[i]-1]=true;
                X--;
            }
            else
                return 0;
            if(X==0)
                return 1;
        }   
        return 0;
    }
}
