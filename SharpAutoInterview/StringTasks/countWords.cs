namespace StringTasks;

public class countWords
{
    public int GetCountWords(string text)
    {
        var words = text.Split(' ');

        var i = words.Length;

        return i;
    }
    
    public int GetCountWordsWithoutSplit(string text)
    {
        int countOfSpace = 0;
        
        if (text[0] != ' ')
        {
            countOfSpace++;
        }
        
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ' && i+1 < text.Length && text[i+1] != ' ')
            {
                countOfSpace++;
            }
        }
}