namespace Lists;

public class SortList
{
    private List<string> lastNameList = new List<string>();

    public SortList()
    {
        lastNameList.AddRange(new []{"Katya", "Max", "Maksim", "Ekaterina"});
    }

    public void SortByNamesWithLIQU()
    {
        var orderedListNames = lastNameList.OrderBy(name => name).ToList();

        foreach (var name in orderedListNames)
        {
            Console.WriteLine(name);
        }
    }
    
    private static void Swap(ref string e1, ref string e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }
    
    public void SortByNames()
    {
        char min = 'Z';
        char max = 'A';

            for (var i = 0; i <= lastNameList.Count - 1; i++)
            {
                for (var j = 0; j <= lastNameList.Count - 1 - i; j++)
                {
                    if (lastNameList[j][0] > lastNameList[j + 1][0])
                    {
                        var e1 = lastNameList[j];
                        var e2 = lastNameList[j + 1];
                        Swap(ref e1, ref e2);
                    }
                } }

    }
    }

    
}