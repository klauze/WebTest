using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Tests.Selenium.Facade;

namespace Tests.Selenium.Tosca_Obstacle_Tests
{
    [Binding]
    public sealed class ToscaObstacleTestSteps
    {


        //Note Step Definition includes all GIVEN WHEN THEN phrases. Alternatively you can add 3 lines
        [StepDefinition(@"I navigate to obstacle (.*) on tricentis")]
        public void GivenINavigateToObstacleOnTricentis(string ObstacleNumber)
        {

            ToscaObstacle.ObstaclePage.NavigateToURL(ObstacleNumber);

            //if (!ToscaObstacle.IsToscaObstacleOpen()) ToscaObstacle.OpenNewSession();

        }


        [Given(@"I click on the click me button until it changes to enough")]
        [When(@"I click on the click me button until it changes to enough")]
        [Then(@"I click on the click me button until it changes to enough")]
        public void WhenIClickOnTheClickMeButtonUntilItChangesToEnough()
        {
            ToscaObstacle.ObstaclePage.ClickMe();
        }




        [StepDefinition(@"I click on enough when displayed")]
        public void WhenIClickOnEnoughWhenDisplayed()
        {
            ToscaObstacle.ObstaclePage.ClickEnough();
        }


        [StepDefinition(@"I see the good job success message")]
        public void ThenISeeTheGoodJobSuccessMessage()
        {
            ToscaObstacle.ObstaclePage.ConfirmSuccess();
        }

        [StepDefinition(@"I get the value from last row and enter it into the text box")]
        public void WhenIGetTheValueFromLastRowAndEnterItIntoTheTextBox()
        {
            ToscaObstacle.ObstaclePage.GetValueFromLastRowTable();
        }


        [StepDefinition(@"I click on the click me first button")]
        public void WhenIClickOnTheClickMeFirstButton()
        {
            ToscaObstacle.ObstaclePage.ClickMeFirst();

        }

        [StepDefinition(@"I click on then click me button")]
        public void WhenIClickOnThenClickMeButton()
        {
            ToscaObstacle.ObstaclePage.ThenClickMe();
        }

    }
}
