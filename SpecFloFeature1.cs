using System;
using TechTalk.SpecFlow;

namespace Prüfung
{
    [Binding]
    public class TrigonometricFunctionsSteps
    {
        private int val;
        private int method;

        [Given(@"I enter (.*)")]
        public void GivenIEnter(int p0)
        {
            val = p0;
        }

        [When(@"I enter sinus(.*)")]
        public void WhenIEnter(string p0)
        {
            if (p0 == "sinus")
            {
                method = 0;
            }else if (p0 == "cosinus")
            {
                method = 1;
            }else if (p0 == "tangens")
            {
                method = 2;
            }
            else
            {
                return;
            }
        }
        
        [Then(@"(.*)")]
        public void Then(int p0)
        {
            
        }
    }
}
