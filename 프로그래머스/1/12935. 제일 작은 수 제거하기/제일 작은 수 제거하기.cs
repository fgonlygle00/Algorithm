using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] arr) 
    {
        int[] answer = new int[] {};
        if (arr.Length > 1) 
        {
            int min = arr.Min();
            answer = arr.Where(x => x != min).ToArray();
        }
        else
        {
            answer = new int[] {-1};
        }
        return answer;
    }
}