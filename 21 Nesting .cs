using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        if(S.Length%2 == 1)
            return 0;
        Stack<char> myStack = new Stack<char>();
        for(int i=0;i<S.Length;i++)
        {
             if(S[i]== '(')      
                myStack.Push(')');
            else if(myStack.Count==0)
                return 0;
            else
            {
                char c=myStack.Pop();
                if(c!=S[i])
                    return 0;
            }
        }
        if(myStack.Count!=0)
            return 0;
        return 1;
    }
}