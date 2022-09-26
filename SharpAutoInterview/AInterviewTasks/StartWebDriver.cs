using System.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace InterviewTasks;

public class StartWebDriver
{
    public void StartWebDr(int numberOfTries)
    {
        for (int i = 0; i < numberOfTries; i++)
        {
            try
            {
                WebDriver driver = new ChromeDriver();
            }
            catch
            {
                Thread.Sleep(100);
            }
        }

        throw new Exception("Unable to run web driver.");
    }
}