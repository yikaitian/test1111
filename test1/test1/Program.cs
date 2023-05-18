using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open the broswer 
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// lanuch the warehouse website
driver.Navigate().GoToUrl("http://desktop.gradspace.monster/");

// identify the username textbox and enter valid username 
IWebElement usernameTextbox = driver.FindElement(By.Id("normal_login_username"));

usernameTextbox.SendKeys("superadmin");

// identify the password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("normal_login_password"));
passwordTextbox.SendKeys("string2");

// identify the login button and click on it 
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"normal_login\"]/div[3]/div/div/div/div/button/span"));
loginButton.Click();

Thread.Sleep(4000);

// check if user login sucessfully  
IWebElement saleButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[1]/div/div/div[2]/ul/li[1]/div/span[2]"));
if (saleButton.Text == "Sales")
{
    Console.WriteLine("Successfully! yeah");
}
else
{
    Console.WriteLine("No successfully");
}