public class Solution
{
    public int[] solution(long n) 
    {
        int set = (int)(n.ToString().Length);
        int[] answer = new int[set];
        for (int i = 0; i < set; i++) 
        {
            answer[i] = (int)(n % 10);
            n /= 10;
        }
        return answer;
    }
}