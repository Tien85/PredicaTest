using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using Nunit.Framework;
using TechTalk.SpecRun;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace GoogleSearch.GoogleSearch
{
    [Binding]
    public class GoogleKeyWordSearchSteps


    {
        IWebDriver driver = new FirefoxDriver();


        [Given(@"I have entered the Google Home page")]
        public void GivenIHaveEnteredTheGoogleHomePage()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        [Given(@"I have entered spec flow into google search bar")]
        public void GivenIHaveEnteredSpecFlowIntoGoogleSearchBar()
        {
            driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div/div[1]/div/div[1]/input")).SendKeys("Predica");
        }

        [When(@"I press search button")]
        public void WhenIPressSearchButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div/div[3]/center/input[1]")).Click();
        }

        [Then(@"the result should be a new pages with results for predica")]
        public void ThenTheResultShouldBeANewPagesWithResultsForPredica()
        {
         
            IWebElement searchField = driver.FindElement(By.CssSelector("span.LrzXr"));

            driver.FindElement(By.XPath("/html/body/div[6]/div[3]/div[10]/div[1]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/div/div[3]/div/div/div[1]/a/h3"));

            driver.FindElement(By.XPath("/html/body/div[6]/div[3]/div[10]/div[1]/div[2]/div/div[2]/div[2]/div/div/div/div[1]/div/div/div/div/div[1]/a[1]/div/cite")).Click();


            driver.Close();

        }
    }
}