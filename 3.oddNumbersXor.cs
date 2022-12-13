using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        //Console.WriteLine(1|0);
        int temp = A[0];
        
        for(int i=1; i<A.Length;i++)
        {
            //Console.WriteLine(Convert.ToString(temp, 2));
            //Console.WriteLine(Convert.ToString(A[i], 2));
            temp= temp^A[i];
        }
        Console.WriteLine(temp);
        return temp;
    }
}
