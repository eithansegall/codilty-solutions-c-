using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        if(A.Length<3)
            return 0;
        for(int i=0;i<A.Length-2;i++)
            if(check(A[i],A[i+1],A[i+2]))
                return 1;
        return 0;
    }
    bool check(int P,int Q,int R)
    {
        return (P>0&&P==Q&&Q==R)||(P+Q>R)&&
                    (Q+R>P)&&
                    (R+P>Q);
    }
}
