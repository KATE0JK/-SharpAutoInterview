using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LoginPage;


public class LoginPage
{
    private IWebDriver _driver;

    private const By usernameInputByCSS = By.CssSelector(".name");
    private const By passwordInputByCSS = By.CssSelector(".password");
    private const By submitButtonByCSS = By.XPath(".login");

    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void Login(string login, string password)
    {
        _driver.FindElement(usernameInputByCSS).SendKeys(login);
        _driver.FindElement(passwordInputByCSS).SendKeys(password);
        _driver.FindElement(submitButtonByCSS).Click();
    }
}