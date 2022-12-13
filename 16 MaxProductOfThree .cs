using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        int max=A[A.Length-1];
        if(max<=0)
            return A[A.Length-1]*A[A.Length-2]*A[A.Length-3];
        max*=A[A.Length-2];
        if(max<=0)
                return A[A.Length-1]*A[0]*A[1];
        max*=A[A.Length-3];
        if(max<=0)
            return A[A.Length-1]*A[0]*A[1];
        return max>A[A.Length-1]*A[0]*A[1]
        ?max:A[A.Length-1]*A[0]*A[1];
    }
    /*
    int find_next(int[] A,int start)
    {
        for(int i=start+1;i<A.Length;i++)
            if(A[i]!=A[i-1])
                return i;
        return start;
    }*/
}