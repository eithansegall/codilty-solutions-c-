// you can also use imports, for example:
// import java.util.*;

// you can write to stdout for debugging purposes, e.g.
// System.out.println("this is a debug message");

class Solution {
    public int solution(int A, int B, int K) {
        int count=0;
       // int limit= B<A*K?B:A*K;
       int limit=B;
        for(int i=A;i<limit+1;i++)
            if(i%K==0)
                count++;
        count+=B-limit;
        return count;
    }
}


// you can also use imports, for example:
// import java.util.*;

// you can write to stdout for debugging purposes, e.g.
// System.out.println("this is a debug message");

class Solution {
    public int solution(int A, int B, int K) {
        int count=0;
        if(B==0)
            return 1;
        if(A==0)
            count=1;
        int temp= A>K?(A%K==0?A/K:A/K+1):1;
        System.Console.WriteLine(temp);
        while(temp*K<=B)
        {
                count++;
                temp++;
        }

        return count;
    }
}

class Solution {
    public int solution(int A, int B, int K) {
        //System.Console.WriteLine(System.Math.Abs((A-1)/K));
        if(A==0)
            return B/K+1;
        return B/K-(A-1)/K;
    }
}

[0, 0, 11]
[0, 14, 2]
[0, 2000000000, 1]