namespace InterviewTasks;

public static class Polindrom
{
    public static bool IsPolinrdom(int number)
    {
        string s = number.ToString();

        for (int i = 0, j = s.Length - 1; i < s.Length; i++,j--)
        {
            if (s[i] != s[j])
            {
                return false;
            }
        }

        return true;
    }
}