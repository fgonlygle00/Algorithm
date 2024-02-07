using System;

public class Solution 
{
    public bool solution(string s) 
    {
        if (4 == s.Length || s.Length == 6)
        {
            bool answer = true;
            char[] c = s.ToCharArray();
            for (int i = 0; i < c.Length; i++) 
            {
                if(!Char.IsDigit(c[i])) return false;
            }
            return answer;
        }
        else return false;
    }
}