class Solution {
    public int solution(int[] A) {
        double[] prefix= new double[A.Length];
        int sum=0;
        for(int i=0;i<A.Length;i++)
        {
            sum+=A[i];
            prefix[i]=(double)sum/(i+1); 
            Console.Write(prefix[i]+" ");           
        }
        return 0;
    }
}

////

class Solution {
    // the minimum avrage will come only from pair or trio.
    public int solution(int[] A) {
        //double[] prefix= new double[A.Length];
        //int sum=0;
        int pair_sum=0;
        pair_sum=A[0]+A[1];
        double min_avg=(double)pair_sum/2;
        int min_start_index=0;
        for(int i=2;i<A.Length;i++)
        {
            double trio_avg= (double)(pair_sum+A[i])/3;
            if(trio_avg < min_avg)
            {
                 min_avg=trio_avg;
                 min_start_index=i-2;
            }
            pair_sum=pair_sum+A[i]-A[i-2];
            double pair_avg= (double)(pair_sum)/2;
            if(pair_avg < min_avg) 
            {     
                 min_avg=pair_avg;
                 min_start_index=i-1;
            }
            //System.Console.WriteLine(min_avg);
        }
        
        return min_start_index;
    }
}
///

[-3, -5, -8, -4, -10]