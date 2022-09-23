namespace StringTasks;

public class MaxAndMinWords
{
    private static string text =
        "The return value of this method indicates whether the conversion succeeded. " +
        "The following example validates a date and time string.";

    public static void GetMaxAndMinWords(out string maxWord, out string minWord)
    {
        int maxNumberOfLetters = Int32.MinValue;
        int minNumberOfLetters = Int32.MaxValue;

        maxWord = null;
        minWord = null;

        string[] words = text.Split(new char[] { ' ', '.', '!', '?', ',' });

        foreach (var word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                if (word.Length >= maxNumberOfLetters)
                {
                    maxNumberOfLetters = word.Length;
                    maxWord = word;
                }

                if (word.Length <= minNumberOfLetters)
                {
                    minNumberOfLetters = word.Length;
                    minWord = word;
                }
            }
        }
    }
}