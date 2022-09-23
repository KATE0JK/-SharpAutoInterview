namespace MaxAndMin;

public static class ClassMaxMin
{
    private static int _num = 1823897;

    private static string _str = _num.ToString();

    public static void GetMaxAndMinNumbers( out int max, out int min)
    {
        max = Int32.MinValue;
        min = Int32.MaxValue;
        
        foreach (var ch in _str)
        {
            var value = (int)ch;

            if (value <= min)
            {
                min = value;
            }
            if (value >= max)
            {
                max = value;
            }
        }   
    }

}