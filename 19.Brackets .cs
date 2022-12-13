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
        int i=0;
        int close=0;
        for(;i<S.Length/2;i++)
            myStack.Push(S[i]);
        //i++;
        for(;i<S.Length;i++)
        {
            char c=myStack.Pop();
            //Console.Write(c+","+S[i]+"\n");
            switch(c)
            {
            case '{':
                if(S[i]!= '}')
                    return 0;
                if(close>0)
                    close--;
                break;
            case '}':
                if(S[i]!= '{' )
                    return 0;
                close++;
                break;
            case '[':
                if(S[i] != ']')
                    return 0;
                if(close>0)
                    close--;
                break;
            case ']':
                if(S[i]!='[' )
                    return 0;
                close++;
                break;
            case '(':
                if(S[i]!= ')')
                    return 0;
                if(close>0)
                    close--;
                break;
            case ')':
                if(S[i]!= '(' )
                    return 0;
                close++;
                break;
            default:
                return 0;
            }
        }
        if(close>0)
            return 0;;
        return 1;
    }
}
/////

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        //Console.WriteLine(S);
        if(S.Length%2 == 1)
            return 0;
        if(S.Length==0)
            return 1;
        if(S.Length==2 && System.Reflection.MethodBase. GetCurrentMethod().Name!= "solution" &&
         S[0]!='(' && S[0]!='{' && S[0]!='[')
            return 0;
        return checkOp(S);      
    }
    public int checkOp(string S)
    {
        char c =' '; 
        if(S[0]=='(')
            c=')';
        if(S[0]=='{')
            c='}';
        if(S[0]=='[')
            c=']';
        if(S.Length==2)
        {
            if(S[0]==')')
            c='(';
            if(S[0]=='}')
            c='{';
            if(S[0]==']')
            c='[';
            if(S[1]==c)
                return 1;
            return 0;
        }
        if(S[S.Length-1]==c)
            return solution(S.Substring(1,S.Length-2));
        else
            {
                int end=S.Length-2;
                while(end>0)
                {
                    if(S[end]==c)
                        return solution(S.Substring(1,end-2))==1
                        &&solution(S.Substring(end,S.Length-2))==1?1:0;
                    end--;
                }
                return 0;
            }
        }
    }

////

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
            if(S[i]== '{')      
                myStack.Push('}');
            else if(S[i]== '[')      
                myStack.Push(']');
            else if(S[i]== '(')      
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

/////








