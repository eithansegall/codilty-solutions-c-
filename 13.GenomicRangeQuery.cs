using System;
class Solution {
    public int[] solution(string S, int[] P, int[] Q) {
        int[] minimal_impact_factor= new int[P.Length];
        int [] impact_factors=convert(S);    
        int[][] prefix_factors=prefix_factor(impact_factors);     
        for(int i=0;i<P.Length;i++)
        {
            if(Q[i]==P[i])
                minimal_impact_factor[i]=impact_factors[Q[i]];
            else if(Q[i]==P[i]+1)
                minimal_impact_factor[i]=
                impact_factors[Q[i]]<impact_factors[P[i]]
                ?impact_factors[Q[i]]:impact_factors[P[i]];
            else if(P[i]==0)
                minimal_impact_factor[i]=find_min_facotr
			(prefix_factors[Q[i]],prefix_factors[P[i]]); 
            else
                minimal_impact_factor[i]=find_min_facotr
			(prefix_factors[Q[i]],prefix_factors[P[i]-1]); 
        }
        return minimal_impact_factor;
    }
    public int find_min_facotr(int[] second,int[] first)
    {
       /* for(int i=0;i<4;i++)
            Console.Write(second[i]+",");
        Console.Write(" - ");
        for(int i=0;i<4;i++)
            Console.Write(first[i]+",");
        Console.WriteLine();*/
        for(int i=0;i<3;i++)
        {
            if(second[i]-first[i]!=0)
            {
                //Console.Write(i+1);
                return i+1;
            }
        }
        return 4;
    }
    public int[][] prefix_factor(int[] factors)
    {
        int[][] prefix_factors=new int[factors.Length][];
        int[] factor_counter=new int[4];
        for(int i=0;i<factors.Length;i++)
        {
            factor_counter[factors[i]-1]++;
            prefix_factors[i]=(int[])factor_counter.Clone();
        }
        /*for(int i=0;i<4;i++)
            Console.Write(factor_counter[i]+",");*/
         //Console.WriteLine();
        return prefix_factors;
    }
    public int[] convert(string S)
    {
        int[] numbers= new int[S.Length];
        for(int i=0;i<S.Length;i++)
        {
            switch(S[i])
            {
                case 'A':          
                    numbers[i]=1;
                    break;
                case 'C':          
                    numbers[i]=2;
                    break;
                case 'G':          
                    numbers[i]=3;
                    break;
                case 'T':          
                    numbers[i]=4;
                    break;
                default:
                    numbers[i]=-1;
                    break;
            }
        }
        return numbers;
    }
}
////
using System;
class Solution {
    public int[] solution(string S, int[] P, int[] Q) {
        int[] minimal_impact_factor= new int[P.Length];
      //  int [] impact_factors=convert(S);
        for(int i=0;i<P.Length;i++)
        {
            if( P[i]==Q[i])
                minimal_impact_factor[i]=minimal_factor(
                    S[P[i]].ToString());
            else
            minimal_impact_factor[i]=minimal_factor(
                S.Substring(P[i],Q[i]-P[i]+1));
        }
        return minimal_impact_factor;
    }

    public int minimal_factor(string nuc)
    {    
        Console.WriteLine(nuc);
        if(nuc.Contains("A"))
                return 1;
        if(nuc.Contains("C"))
                return 2;
        if(nuc.Contains("G"))
                return 3;     
        return 4;
    }
}

////

using System;
class Solution {
    public int[] solution(string S, int[] P, int[] Q) {
        int[] minimal_impact_factor= new int[P.Length];
        int [] impact_factors=prefix_factor(S);
       // for(int i=0;i<S.Length+1;i++)
         //   Console.Write(impact_factors[i]+",");
        for(int i=0;i<P.Length;i++)
        {
            if(Q[i]==P[i])
                minimal_impact_factor[i]=let_to_num(S[Q[i]]);
            else
                minimal_impact_factor[i]=minimal_factor
                        (impact_factors[Q[i]+1]/
                        impact_factors[P[i]]);
        }
        return minimal_impact_factor;
    }
public int let_to_num(char nuc)
    {    
        //Console.WriteLine(nuc);
        if(nuc=='A')
                return 1;
        if(nuc=='C')
                return 2;
        if(nuc=='G')
                return 3;     
        return 4;
    }
    public int minimal_factor(int div)
    {
        if(div%2==0)
            return 1;
         if(div%3==0)
            return 2;
        if(div%5==0)
            return 3;
         else
            return 4; 
    }
    public int[] prefix_factor(string S)
    {
        int[] numbers= new int[S.Length+1];
        numbers[0]=1;
        for(int i=0;i<S.Length;i++)
        {
            switch(S[i])
            {
                case 'A':          
                    numbers[i+1]=numbers[i]*2;
                //    Console.Write(1);
                    break;
                case 'C':       
                    numbers[i+1]=numbers[i]*3;
                   // Console.Write(2);
                    break;
                case 'G':          
                    numbers[i+1]=numbers[i]*5;
                //    Console.Write(3);
                    break;
                case 'T':          
                    numbers[i+1]=numbers[i];
                   // Console.Write(4);
                    break;
                default:
                    numbers[i+1]=-1;
                    break;
            }
            
        }
        //Console.WriteLine();
        return numbers;
    }
}
////
('TC', [0, 0, 1], [0, 1, 1])
('AC', [0, 0, 1], [0, 1, 1])
('CAGCCTA', [ 0], [ 5])
