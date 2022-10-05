namespace InterviewTasks;

public static class Palindrom
{
    public static bool IsPalinrdom(int number)
    {
        string s = number.ToString();

        for (int i = 0; i < (s.Length)/2; i++)
        {
            if (s[i] != s[s.Length-1-i])
            {
                return false;
            }
        }

        return true;
    }
}