using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        int max= 0;
        bool maxChange=false;
       int[] counters= new int[N];
        for(int i=0;i<N;i++)
            counters[i]=0;
        for(int k=0;k<A.Length;k++)
        {
            if(1<=A[k]&&A[k]<=N)
            {
                counters[A[k]-1]++;
                if(counters[A[k]-1]>max)
                {
                    max=counters[A[k]-1];
                    maxChange=true;
                }
            }
            if(A[k]==N+1&&maxChange)
			{
                for(int i=0;i<N;i++)
                   if(counters[i]<max)
                        counters[i]=max;
				maxChange=false;
			}				
        }    
        return counters;
    }
}


/**/

using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        int max= 0;
        bool maxChange=false;
       int[] counters= new int[N];
        List<int> notToMaxList= new List<int>();
        int notToMaxLength=0;
        /*for(int i=0;i<N;i++)
            counters[i]=0;*/
        for(int k=0;k<A.Length;k++)
        {
            if(1<=A[k]&&A[k]<=N)
            {
                counters[A[k]-1]++;
                if(counters[A[k]-1]>max)
                {
                    max=counters[A[k]-1];
                    notToMaxList.Clear();
                    notToMaxList.Add(A[k]-1);
                    notToMaxLength=1;
                    maxChange=true;
                }
                else if(counters[A[k]-1]==max)
                {
                    notToMaxList.Add(A[k]-1);
                    notToMaxLength++;
                }
            }
            if(A[k]==N+1&&maxChange)
			{
                Console.WriteLine(notToMaxList[0]);
                for(int i=0,j=0;i<N-notToMaxLength;i++,j++)
                {
                   if(!notToMaxList.Remove(i))
                        counters[j]=max;
                    else
                        i--;              
                }
                notToMaxLength=0;
				maxChange=false;
			}				
        }    
        return counters;
    }
}
/////

using System;

class Solution {
    public int[] solution(int N, int[] A) {
        int max= 0;
        int nextMax=0;
       int[] counters= new int[N];
        for(int k=0;k<A.Length;k++)
        {
            if(1<=A[k]&&A[k]<=N)
            {
                counters[A[k]-1]++;
                if(counters[A[k]-1]<=max)
                    counters[A[k]-1]=max+1;
                if(counters[A[k]-1]>nextMax)
                    nextMax=counters[A[k]-1];          			
            }
            if(A[k]==N+1)
			    max= nextMax;				
        }
        if(max==0)
            return counters;
        for(int i=0;i<N;i++)
                   if(counters[i]<max)
                        counters[i]=max;    
        return counters;
    }
}