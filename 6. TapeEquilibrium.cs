using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int sum = 0;
        for(int i=0; i<A.Length;i++)
            sum += A[i];
        int temp_sum=A[0];
        int opt=0;
        opt=Math.Abs(sum-temp_sum*2);
        for(int i=1; i<A.Length-1;i++)
        {
            temp_sum+=A[i];
            if(Math.Abs(sum-temp_sum*2)<opt)
                opt=Math.Abs(sum-temp_sum*2);
        }
        return opt;
    }
}
