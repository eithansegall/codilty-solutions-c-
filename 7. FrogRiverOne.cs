using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        bool[] flags= new bool[X];
        for(int i=0;i<A.Length;i++)
        {
            if(!flags[A[i]-1])
            {
                flags[A[i]-1]=true;
                X--;
            }
            if(X==0)
                return i;
        }   
        return -1;
    }
}
