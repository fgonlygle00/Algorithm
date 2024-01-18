using System;

public class Solution 
{
    public long solution(long n) 
    {
        long answer = 0;
        char[] str = n.ToString().ToCharArray();
        Array.Sort(str);
        Array.Reverse(str);
        answer = long.Parse(str);
        return answer;
    }
}