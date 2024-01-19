public class Solution
{
    public int solution(long num) 
    {
        int answer = 0;
        do
        {
            if (num == 1) return 0;
            
            if (num % 2 == 0) 
            {
                num /= 2;
            }
            else 
            {
                num = num * 3 + 1;
            }
            answer++;
            
            if (answer >= 500) 
            {
                return -1;
            }
            
        } while (num != 1);
        return answer;
    }
}