namespace InterviewTasks;

public static class Fibonacci
{
    public static uint GetFibonacciByNumber(uint n)
    {
        uint fibonacciFirstNumber = 0;
        uint fibonacciSecondNumber = 1;
        uint result = 0;

        if (n == 1 || n == 2)
        {
            result = 1;
        }
        
        if (n > 2)
        {
            for (int i = 1; i < n; i++)
            {
                result = fibonacciFirstNumber + fibonacciSecondNumber;
                fibonacciFirstNumber = fibonacciSecondNumber;
                fibonacciSecondNumber = result;
            }
        }
        
        return result;
    }
}