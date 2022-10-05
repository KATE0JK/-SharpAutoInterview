using System.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;

namespace InterviewTasks;

public class StartWebDriver
{
    public WebDriver StartWebDr(int numberOfTries)
    {
        for (int i = 0; i < numberOfTries; i++)
        {
            try
            {
                WebDriver driver = new ChromeDriver();
                return driver;
            }
            catch (Exception e)
            {
                Thread.Sleep(100);
                Log.Warning($"Unable to run web driver. Due to error {e.Message}");
            }
        }

        throw new Exception($"Unable to run web driver in {numberOfTries} attempts");
    }
    
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

        throw new FileNotFoundException($"File is not found in {timeoutSeconds} sec by path {path}.");
    }
}