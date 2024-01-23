using System;

public class Solution 
{
    public string solution(string phone_number) 
    {
        string answer = "";
        string hide_part = new String('*', phone_number.Length - 4);
        string show_part = phone_number.Substring(phone_number.Length - 4, 4);
        return hide_part + show_part;
    }
}