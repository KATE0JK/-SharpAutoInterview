namespace StringTasks;

public static class UpperCaseString
{
    //private string srt = "asF1dA";

    public static void ToUpperCase(ref string str)
    {
        if (!string.IsNullOrEmpty(str))
        {
            str = str.ToUpper();
        }
        else
        {
            Console.WriteLine("the string is null");
        }
    }
}