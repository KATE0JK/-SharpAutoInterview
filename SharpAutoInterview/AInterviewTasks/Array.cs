namespace InterviewTasks;

public static class ArrayHelper
{
    public static int GetSecondMax(int[] array)
    {
        int maxNumber = int.MinValue;
        int secondMaxNumber = maxNumber;

        foreach (var i in array)
        {
            if (i > maxNumber)
            {
                secondMaxNumber = maxNumber;
                maxNumber = i;
            }
        }

        return secondMaxNumber;
    }
}