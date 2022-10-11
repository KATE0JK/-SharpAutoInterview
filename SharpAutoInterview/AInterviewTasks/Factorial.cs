namespace InterviewTasks;

public class Factorial
{
    public int GetFactorial(int value)
    {
        var factorial = 1;

        if (value == 0)
        {
            return factorial;
        }
        
        for (int i = 1; i >= value; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}