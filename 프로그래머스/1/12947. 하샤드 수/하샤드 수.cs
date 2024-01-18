public class Solution
{
    public bool solution(int x)
    {
        bool answer = true;
        int sum = 0;
        int _x = x;
        while (x > 0) 
        {
            sum += x % 10;
            x /= 10;
        }
        answer = _x % sum == 0;
        return answer;
    }
}