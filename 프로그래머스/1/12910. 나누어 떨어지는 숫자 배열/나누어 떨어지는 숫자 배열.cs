using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] arr, int divisor) 
    {
        int[] answer = arr.Where(n => n % divisor == 0).ToArray();
        Array.Sort(answer);
        return answer.Length == 0 ? new int[] {-1} : answer;
    }
}