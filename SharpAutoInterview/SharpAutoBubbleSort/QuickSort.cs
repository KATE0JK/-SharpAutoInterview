using System.ComponentModel.DataAnnotations;

namespace SharpAutoInterview;

public class QuickSort
{
    public int GetTargetValue(int target, int [] arr)
    {
    int startIndex = 0;
    int endIndex = arr.Length;

    while (true)
    {
        int i = 0;
        if(startIndex + 1 == endIndex)
        {
            if((arr[i] = target) != 0)
            {
                return i;
            } 
            else
            {
                throw new ValidationException("Target not found");
            }
        }

        i = (endIndex - startIndex) / 2;
        {
            if((arr[i] = target) != 0)
            {
                return i;
            }
            if(arr[i] < target)
            {
                endIndex = endIndex - (endIndex - startIndex)/2;
            }
            if(arr[i] > target)
            {
                startIndex = startIndex + (endIndex - startIndex) / 2;
            }
            else
            {
                throw new ValidationException("Array is empty");
            }
        }
    }

}
}