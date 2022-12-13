using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        if(A.Length<=1)
            return 0;
        int size=0;
        int val=0;
        for(int i=0;i<A.Length;i++)
        {
            if(size==0)
            {
                size++;
                val=A[i];
            }
            else
                if(A[i]!=val)
                    size--;
                else
                    size++;
        }
        int candi=-1; //the leader value
        if(size>0)
            candi=val;
        int count =0; // the count of times the leader accrues
        for(int i=0;i<A.Length;i++)
            if(A[i]==candi)
                count++;
        if(count<=A.Length/2)
             return 0;;
        /////
        //Console.WriteLine("leader: "+candi+", count: "+count);
        int equi_count=0;
        int temp_count=0;

        for(int i=0;i<A.Length-1;i++)
        {
            if(A[i]==candi)
                temp_count++;
            if(temp_count>((i+1)/2)&&
            (count-temp_count)>((A.Length-i-1)/2))
                equi_count++;
        }
        return equi_count;
    }
}
