using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        if(A.Length==0)
            return 0;
        int max_prof=0;
        int min=A[0];
        for(int i=1;i<A.Length;i++)
        {
            if(A[i]>min)
                max_prof=max_prof >A[i]-min
                ?max_prof:A[i]-min;
            else
                min=A[i];
        }
        return max_prof;
    }
}