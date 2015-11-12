﻿using Specflow_Selenium_PO_Example2.Pages;
using System;
using TechTalk.SpecFlow;

namespace Specflow_Selenium_PO_Example2.Step_Definitions
{
    [Binding]
    public class ExampleWebFeatureSteps : Base
    {
        LoginPage login;

        [Given(@"I have entered '(.*)' and '(.*)' into the application")]
        public void GivenIHaveEnteredAndIntoTheApplication(string p0, string p1)
        {
            login = new LoginPage();
            login.with(p0, p1);
        }


        [When(@"I login")]
        public void WhenILogin()
        {
            // ScenarioContext.Current.Pending();
            login.submit();            
        }
        
        [Then(@"I should be informed that login was successful")]
        public void ThenIShouldBeInformedThatLoginWasSuccessful()
        {
            login.successMessagePresent();
        }

        [Then(@"I should be informed that login was unsuccessful")]
        public void ThenIShouldBeInformedThatLoginWasUnsuccessful()
        {
            login.failureMessagePresent();
        }

    }
}