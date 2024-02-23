public class Solution 
{
    public string solution(string s) 
    {
        string answer = "";
        int index = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == ' ') 
            {
                index = 0;
                answer += " ";
            }
            else 
            {
                answer += index % 2 == 0 ? char.ToUpper(s[i]) : char.ToLower(s[i]);
                index++;
            }
        }
        return answer;
    }
}