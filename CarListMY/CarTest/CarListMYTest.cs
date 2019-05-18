using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CarTest
{
    /// <summary>
    /// Test for https://www.carlist.my to verify if the searched car is priced greater the RM 1,000
    /// </summary>
    class CarListMYTest
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Driver\chromedriver_win32");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.carlist.my/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement usedRadioButton = driver.FindElement(By.XPath("//div[contains(@class,'flexbox--fixed')]//div[contains(@class,'cf')]//div[2]"));
            usedRadioButton.Click();
            
            IWebElement searchButton = driver.FindElement(By.XPath("//div[contains(@class,'one-whole')]//button[contains(@class,'one-whole')][contains(text(),'Search')]"));
            searchButton.Click();

            driver.FindElement(By.XPath("//article[1]//h2[1]//a[1]")).Click();
            string price = driver.FindElement(By.XPath("//div[contains(@class,'push-half--bottom')]//div[contains(@class,'weight--bold')][1]")).Text;
            price = price.Substring(3);
            try
            {
                float carPrice = float.Parse(price);
                if(carPrice > 1000)
                {
                    Console.WriteLine("The car price is RM " + price + ": is greater than RM 1,000.");
                }
                else
                {
                    Console.WriteLine("The car price is less than RM 1,000");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not parse the price. Error : " + e.Message);
            }

            driver.Quit();
        }
    }
}