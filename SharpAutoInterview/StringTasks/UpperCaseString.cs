namespace StringTasks;

public static class UpperCaseString
{
    //private string srt = "asF1dA";

    private static readonly string lowerCaseLatter = "abcd...z";
    private static readonly string upperCaseLatter = "ABCD...Z";

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

    public static string ToCustomUpperCase(string sourceString)
    {
        string targetString = "";

        if (!string.IsNullOrEmpty(sourceString))
        {
            foreach (var letter in sourceString)
            {
                var charIndex = lowerCaseLatter.IndexOf(letter);
                if (charIndex != -1)
                {
                    targetString += upperCaseLatter[charIndex];
                }
                else
                {
                    targetString += letter;
                }
            }
        }
        else
        {
            Console.WriteLine("the string is null");
        }

        return targetString;
    }
}

