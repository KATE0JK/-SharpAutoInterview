namespace DateAndTime;

public class DateTimeHelper
{
    private string srt = "Aug 12, 2022 1:14PM";

    public string GetNewFormat()
    {
        DateTime date = DateTime.Parse(srt);

        return date.ToString("yyyy-MM-dd hh:mm");
    }
    
}