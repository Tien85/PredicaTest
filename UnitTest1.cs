using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using Nunit.Framework;
using TechTalk.SpecRun;



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
            driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div/div[1]/div/div[1]/input")).SendKeys("Spec Flow");
        }

        [When(@"I press search button")]
        public void WhenIPressSearchButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div/div[3]/center/input[1]")).Click();
        }

        [Then(@"the result should be a new pages with results for spec flow")]
        public void ThenTheResultShouldBeANewPagesWithResultsForSpecFlow()
        {
            //  Assert.AreEqual("Google", driver.Title);
        }
    }
}