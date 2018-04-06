using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
//using Panviva.SPUI.Selenium.Project.Facade;
using TechTalk.SpecFlow;
using System.Threading;
using Tests.Selenium.PageModels;
using OpenQA.Selenium.Interactions;
using Tests.Selenium.ToscaObstacleTests.Commons;
namespace Tests.Selenium.PageModels
{
    public class ObstaclePage
    {
        //Get time to wait from app config
        System.Configuration.Configuration config =
        ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None) as Configuration;
        public static int waitsec = Int32.Parse(ConfigurationManager.AppSettings.Get("WaitSec"));


        static protected IWebDriver d;
        public IWebDriver WebDriver
        {
            get
            {
                return d;
            }
        }

        //IWebDriver d;
        public ObstaclePage(IWebDriver driver)
            {
            d = driver;
            //Wait for title to be displayed 
            System.Diagnostics.Debug.WriteLine("wait4title");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitsec));
            wait.Until((D) =>
            {
                System.Diagnostics.Debug.WriteLine("testTitle:" + d.Title);
                return d.Title.Contains("Tricentis Obstacle");
            });
            System.Diagnostics.Debug.WriteLine("done");
        }

        //Elements on 81121
        By ClickMeButton = By.XPath("//a[@id='button'][text()='Click Me']");
        By EnoughButton = By.XPath("//a[@id='button'][text()='Enough']");
        By Success = By.XPath("//div[@class='sweet-alert showSweetAlert visible']/h2");
        
        //Demo that you don't need to define it here and can directly get element and press
        //By ThenClickMe = By.XPath("//a[@id='myLink_new']")
        //By ClickMeFirst = By.XPath("//button[@id='changeIdButton']");
        public void NavigateToURL(string Obstacle)
        {

            d.Navigate().GoToUrl(d.Url + Obstacle);

        }


        public void ClickMe()
        {
            var clickme = Utils.GetElement(ClickMeButton,d);

            do
            {
                clickme.Click();
            } while (clickme.Text == "CLICK ME") ;


        }

        public void ClickEnough()
        {
            var enough = Utils.GetElement(EnoughButton,d);

            do
            {
                Actions action = new Actions(d);
                action.MoveToElement(enough).Click().Perform();
            } while (Utils.GetElement(Success,d).Displayed == false);



        }


        public void ConfirmSuccess()
        {
            var clickme = Utils.GetElement(Success,d);

            
            Assert.IsTrue(clickme.Displayed);

        }



        public void ClickMeFirst()
        {
            var enough = Utils.GetElement(By.XPath("//button[@id='changeIdButton']"), d);

           
                Actions action = new Actions(d);
                action.MoveToElement(enough).Click().Perform();
         



        }


        public void ThenClickMe()
        {
            var enough = Utils.GetElement(By.XPath("//a[@id='myLink_new']"), d);


            Actions action = new Actions(d);
            action.MoveToElement(enough).Click().Perform();




        }



        public void GetValueFromLastRowTable()
        {
            GenericTable table = null;
            table = GenericTable.BuildTable(Utils.GetElement((By.Id("orderTable")),d),
            new string[] { "Type", "Value" });





        }

    }



}





