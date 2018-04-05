﻿//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;
//using System;
//using System.Threading;
//using TechTalk.SpecFlow;

//namespace Tests.Selenium
//{
//    [Binding]
//    public class BasicGoogleSearchSteps
//    {
//        [BeforeScenario]
//        public void BeforeScenario()
//        {
//            IWebDriver driver = new ChromeDriver();
//            ScenarioContext.Current.Set<IWebDriver>(driver, "Driver");
//        }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            IWebDriver driver = ScenarioContext.Current.Get<IWebDriver>("Driver");
//            driver.Quit();
//        }

//        [Given(@"I want to search with Google")]
//        public void GivenIWantToSearchWithGoogle()
//        {
//            IWebDriver driver = ScenarioContext.Current.Get<IWebDriver>("Driver");
//            driver.Navigate().GoToUrl("http://www.google.com");
//            ScenarioContext.Current.Set<string>("q", "queryFieldName");
//        }

//        /// <summary>
//        /// Saves the last search term to be used in "Then" statements
//        /// </summary>
//        /// <param name="p0"></param>
//        [When(@"When I search for ""(.*)""")]
//        public void WhenWhenISearchFor(string p0)
//        {
//            string queryFieldName = ScenarioContext.Current.Get<string>("queryFieldName");
//            ScenarioContext.Current.Set<string>(p0, "lastSearch");
//            IWebDriver driver = ScenarioContext.Current.Get<IWebDriver>("Driver");
//            IWebElement queryField = driver.FindElement(By.Name(queryFieldName));
//            queryField.SendKeys(p0);
//            queryField.Submit();
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//            // wait until the title comes up.  Should look for some field or other later component
//            wait.Until(d => d.Title.Contains(p0));
//        }

//        /// <summary>
//        /// Assumes "That" refers to last search term
//        /// </summary>
//        [Then(@"That should be in the title bar")]
//        public void ThatShouldBeInTheTitleBar()
//        {
//            string lastSearch = ScenarioContext.Current.Get<string>("lastSearch");
//            IWebDriver driver = ScenarioContext.Current.Get<IWebDriver>("Driver");
//            string title = driver.Title;
//            StringAssert.Contains(title, lastSearch);
//        }

//        [Given(@"I want to search with Bing")]
//        public void GivenIWantToSearchWithBing()
//        {
//            IWebDriver driver = ScenarioContext.Current.Get<IWebDriver>("Driver");
//            driver.Navigate().GoToUrl("http://www.bing.com");
//            // google and bing use same search field name - ids are different
//            ScenarioContext.Current.Set<string>("q", "queryFieldName");
//        }


//    }
//}
