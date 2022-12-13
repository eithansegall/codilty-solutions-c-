using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        int maxBinaryGap=0;
        int binaryGap=0;
        bool flag_1=false;
        while(N!=0)
        {
            //Console.Write(N%2);
            if(N%2==1)
            {
                if(flag_1)
                {
                //update: use special func
                    if(maxBinaryGap<binaryGap)
                        maxBinaryGap=binaryGap;
                    binaryGap=0;
                }
                else
                    flag_1=true;
            }
            else
            {
                if(flag_1)
                  binaryGap++; 
            }
            N=N/2;
        }
        return maxBinaryGap;
    }
}
 