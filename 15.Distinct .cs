using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        if(A.Length==0)
            return 0;
        int count=1;
        for(int i=1;i<A.Length;i++)
            if(A[i]!=A[i-1])
                count++;
        return count;
    }
}