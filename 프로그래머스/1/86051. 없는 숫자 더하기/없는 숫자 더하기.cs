using System;
using System.Linq;

public class Solution
{
    public int solution(int[] numbers)
    {
        int answer = 0;
        for (int i = 0; i < 10; i++) 
        {
            answer += Array.Find(numbers, x => x == i);
        }
        answer = 45 - answer;
        return answer;
    }
}