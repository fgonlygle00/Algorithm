using System;

public class Solution 
{
    public long solution(long n) 
    {
        double answer = 0;
        answer = Math.Sqrt(n);
        if (Math.Abs(answer % 1) < double.Epsilon) return (long)Math.Pow(answer + 1, 2);
        else return -1;
    }
}