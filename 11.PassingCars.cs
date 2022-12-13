using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int count= 0;
        int zeroNumber=0;
        int oneNumber=0;
        if(A[0]==0)
        {
            zeroNumber= 1;
            for(int i=1;i<A.Length;i++)
                {
                    if(A[i]==1)
                        count+=zeroNumber;
                    if(A[i]==0)
                        zeroNumber++;
                    if(count > 1000000000)
                        return -1;
                }
        } 
        else
        {
            oneNumber= 1;
            for(int i=1;i<A.Length;i++)
                {
                    if(A[i]==0)
                        count+=oneNumber;
                    if(A[i]==1)
                        oneNumber++;
                    if(count > 1000000000)
                        return -1;
                }
        } 
        return count;
    }
}

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int count= 0;
        int zeroNumber=0;
        if(A[0]==0)
        {
            zeroNumber= 1;
            for(int i=1;i<A.Length;i++)
                {
                    if(A[i]==1)
                        count+=zeroNumber;
                    if(A[i]==0)
                        zeroNumber++;
                    if(count > 1000000000)
                        return -1;
                }
        }      
        return count;
    }
}

