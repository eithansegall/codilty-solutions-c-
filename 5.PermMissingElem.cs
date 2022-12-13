using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
       //Console.WriteLine(1|0);
        int sum1 = 0;
        int sum2 = 0;
        int i=0;
        for(; i<A.Length;i++)
        {
            sum1+=A[i];
            sum2+=i+1;
        }
        sum2+=i+1;
        return sum2-sum1;
    }
}
