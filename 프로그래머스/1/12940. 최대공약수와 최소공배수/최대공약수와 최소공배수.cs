public class Solution 
{
    public int[] solution(int n, int m) 
    {
        int[] answer = new int[] {};
        int tempA = n, tempB = m;

        while (tempB != 0)
        {
            int r = tempA % tempB;
            tempA = tempB;
            tempB = r;
        }

        int maxNum = tempA; // 최대공약수
        int minNum = n * m / maxNum; // 최소공배수

        return answer = new int[] {maxNum, minNum};
    }
}