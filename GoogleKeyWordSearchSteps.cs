using System;
using TechTalk.SpecFlow;

namespace GoogleSearch1
{
    [Binding]
    public class GoogleKeyWordSearchSteps
    {
        [Then(@"the result should be a new pages with results for Predica")]
        public void ThenTheResultShouldBeANewPagesWithResultsForPredica()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
