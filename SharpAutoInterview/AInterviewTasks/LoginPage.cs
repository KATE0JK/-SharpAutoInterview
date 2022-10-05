using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Assert = NUnit.Framework.Assert;

namespace InterviewTasks;

public class SignInPage {
    
    private WebDriver _driver;
    
    private By usernameInputByCSSSelector = By.CssSelector(".user_name");
    private By passwordInputByCSSSelector  = By.CssSelector(".password");
    private By signinButtonByCSSSelector = By.CssSelector(".sign_in");

    public SignInPage(WebDriver driver){
        _driver = driver;
    }

    public HomePage LoginValidUser(String userName, String password) {
        _driver.FindElement(usernameInputByCSSSelector).SendKeys(userName);
        _driver.FindElement(passwordInputByCSSSelector).SendKeys(password);
        _driver.FindElement(signinButtonByCSSSelector).Click();
        
        return new HomePage(_driver);
    }
    
    public bool UserIsLogedIn()
    {
        return (_driver.FindElement(By.Id(UserIsLogedInIdSelector)) != null);
    }
}

/***
 * Tests login feature
 */
public class TestLogin {

    @Test
    public void testLogin() {
        SignInPage signInPage = new SignInPage(driver);
        HomePage homePage = signInPage.LoginValidUser("userName", "password");
        
        Assert.IsTrue("BrowserStack".Contains("Browserstack"));
    }

}