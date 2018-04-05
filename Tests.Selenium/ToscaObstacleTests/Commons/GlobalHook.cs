using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Tests.Selenium.Facade;

namespace Tests.Selenium.ToscaObstacleTests.Commons
{
    [Binding]
    class GlobalHook : Steps
    {


        [BeforeScenario]
        public void BeforeScenarioHook()
        {

            //DONT COMMENT ANY OF THIS OUT. EVER!


            GivenToscaObstacleSiteIsOpened();

        }


        [AfterScenario]
        public void AfterScenarioHook()
        {

            TestCleanup();
        }


        [Given(@"Tosca Obstacle is opened")]
        [When(@"Tosca Obstacle is opened")]
        [Then(@"Tosca Obstacle is opened")]
        public void GivenToscaObstacleSiteIsOpened()
        {

            ToscaObstacle toscaObstacles = new ToscaObstacle();
            toscaObstacles.OpenNewSession();



        }


        [Given(@"I Close Tosca Obstacle")]
        [When(@"I Close Tosca Obstacle")]
        [Then(@"I Close Tosca Obstacle")]
        public void TestCleanup()
        {

            ToscaObstacle.CloseSession();


        }

    }
}



