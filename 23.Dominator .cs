using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        if(A.Length==0)
            return -1;
        if(A.Length==1||A.Length==2)
            return 0;
        int[] B=(int[])A.Clone();
        Array.Sort(B);
        int count=1;
        int val=-1;
        for(int i=1;i<B.Length;i++)
        {
            if(B[i]==B[i-1])
            {
                count++;
                if(count>B.Length/2)
                    val=B[i];
            }
            else
                count=1;
        }
        if(val==-1)
            return val;
        for(int i=0;i<A.Length;i++)
            if(A[i]==val)
                return i;
        return -1;
    }
}
/////

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        if(A.Length==0)
            return -1;
        if(A.Length==1||A.Length==2)
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
        int candi=-1;
        if(size>0)
            candi=val;
        int leader=-1;
        int count =0;
        for(int i=0;i<A.Length;i++)
            if(A[i]==candi)
            {
                count++;
                leader=i;
            }
        if(count<=A.Length/2)
             leader=-1;
        return leader;
    }
}
