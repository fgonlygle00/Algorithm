using System;

public class Solution
{
    public string solution(string[] seoul)
    {
        string answer = "";
        string target = "Kim";
        int index = Array.IndexOf(seoul, target);
        return answer = $"김서방은 {index}에 있다";
    }
}