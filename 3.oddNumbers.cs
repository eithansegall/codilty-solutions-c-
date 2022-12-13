using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int[] indexes= new int[1000000];
        for(int i=0; i<1000000;i++)
        {
            indexes[i]= 0;
        }
        for(int i=0; i<A.Length;i++)
        {
            int temp = indexes[A[i]-1];
            if(temp==0)
                indexes[A[i]-1]=1;
            else
                indexes[A[i]-1]=0;
        }
          for(int i=0; i<1000000;i++)
        {
            if(indexes[i]!=0)
                return i+1; 
        }     
        return -1;
    }
}
