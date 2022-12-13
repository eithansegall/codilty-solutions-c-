using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message"); [-10] [-2, 1]

class Solution {
    public int solution(int[] A) {
        int max_ending =0;
        int max_slice = int.MinValue;
        for(int i=0;i<A.Length;i++)
        {
            max_ending = Math.Max(max_ending + A[i], A[i]);
            max_slice = Math.Max(max_slice, max_ending);
        } 
        return max_slice;
    }
}
