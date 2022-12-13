using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        bool[] flags= new bool[1000001];
        for(int i=0;i<A.Length;i++)
        {
            if(A[i]>0&&A[i]<1000001)
                //if(!flags[A[i]-1])
                    flags[A[i]-1]=true;
        } 
        for(int i=0;i<100000;i++)
        {
            if(!flags[i])
                return i+1;
        } 
        return 100001;
    }
}
