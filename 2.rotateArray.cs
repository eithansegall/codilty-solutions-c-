using System;

class Solution {
    public int[] solution(int[] A, int K) {
	if(A==null||A.Length==0)
       return A;
    for(int i=0;i<K;i++)
    {
    int last=A[A.Length-1];
    int current,prev=A[0];
    for(int j=1;j<A.Length;j++)
    {
        current=A[j];
        A[j]=prev;
        prev=current;
    }
    A[0]=last;
    } 
    // print func
	// for(int j=1;j<A.Length;j++){}
    return A;
    }
}
