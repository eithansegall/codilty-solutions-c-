using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        int count =0;
        int cur=0;
        for(int i=1;i<A.Length;i++)
        {
            //Console.WriteLine(A[i]+","+B[i]);
            if(B[i]==1)
                cur=i;
            else if(B[cur]==1)
                {
                    if(A[i]>A[cur])
                        cur=i;
                    count++;   
                }
        }
        return A.Length-count;
    }
}

/////


using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        int count =A.Length;
        //int cur=0;
        //Stack<int> upStack = new Stack<int>();
        Stack<int> downStack = new Stack<int>();
        if(B[0]==1)
            downStack.Push(A[0]);
        for(int i=1;i<A.Length;i++)
        {
            //Console.WriteLine(A[i]+","+B[i]);
            if(B[i]==0)
            {
                if(downStack.Count!=0)
                        while(downStack.Count!=0)
                            {
                                count--;
                                int size=downStack.Pop();
                                if(A[i]<size)
                                {
                                    downStack.Push(size);
                                    break;
                                }    
                            }
            }
            else
                    downStack.Push(A[i]);
        }
        return count;
    }
}