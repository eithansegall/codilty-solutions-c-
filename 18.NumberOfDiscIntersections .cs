using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        if(A.Length==0)
            return 0;
        int count =0;
        for(int i=0;i<A.Length-1;i++)
        {
            if(A[i]>=A.Length)
                {
                    count+=A.Length-i-1;
                    if(count==10000000)
                            return -1;
                }
            else
                for(int j=i+1;j<A.Length;j++)
                {
                    if(A[j]>=A.Length||i+A[i]>=j-A[j])
                    {
                        if(count==10000000)
                            return -1;
                        count++;
                    }
                }
            //Console.WriteLine(i+" count: "+count);
        }
        return count;
    }
}

///

using System;
class Solution {
    public int solution(int[] A) {
        if(A.Length==0)
            return 0;
        int count =0;
        long[] forward= new long[A.Length];
        long[] backward= new long[A.Length];
        for(int i=0;i<A.Length;i++)
        {
            backward[i] = i - (long)A[i];
            forward[i] = i + (long)A[i];
        }
        Array.Sort(forward);
        Array.Sort(backward);
        
        int lower=0;
        for(int i=0;i<A.Length;i++)
            {
                //Console.WriteLine();
                //Console.Write(forward[i]+": ");
                while( lower < A.Length &&
                 forward[i] >= backward[lower]){
                    //Console.Write(backward[lower]+", ");
                    count +=  lower;
                    count -=  i;
                    lower++;
                 }
            }
         if(count>10000000)
                            return -1;
        return count;
    }
}