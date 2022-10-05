using OpenQA.Selenium.DevTools;

namespace InterviewTasks;

public class timeout
{
    public string GetContent(string path, int timeoutSeconds)
    {
        var startDateTime = DateTime.Now;
        var endDateTime = startDateTime.AddSeconds(timeoutSeconds);

        do
        {
            if (File.Exists(path))
            {
                try
                {
                    string content = File.ReadAllText(path);
                    return content;
                }
                catch (Exception e)
                {
                    Log.Write(e.Message);
                }
            }

            Thread.Sleep(500);
        } while (DateTime.Now < endDateTime);
    
        throw new FileNotFoundException ($"File is not found by path {path} in {timeoutSeconds} sec.")
    }
}