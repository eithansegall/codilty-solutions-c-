using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message"); [2, 3, 2, 1], 4

class Solution {
    public int solution(int[] H) {
        int count=1;
        Stack<int> myStack = new Stack<int>();
       // int curH=H[0];
        myStack.Push(H[0]);
        //Console.WriteLine(H[0]+" ["+count+"]");
        for(int i=1;i<H.Length;i++)
        {
            if(H[i]>myStack.Peek())
            {
                count++;
                myStack.Push(H[i]);
            }
            else if(H[i]<myStack.Peek())
            {
                while(myStack.Count!=0)
                    {
                        int size=myStack.Pop();
                        //Console.WriteLine("stack: "+size+" "+H[i]);
                        if(H[i]==size)
                        {
                            myStack.Push(size);
                            break;
                        }
                        else if(H[i]>size)
                        {
                            myStack.Push(size);
                            count++;
                            myStack.Push(H[i]);
                            break;
                        }
                    }
                if(myStack.Count==0)
                {
                    count++;
                    myStack.Push(H[i]);
                }
            }
        //Console.WriteLine(H[i]+" ["+count+"]");
        }
        return count;
    }
}
