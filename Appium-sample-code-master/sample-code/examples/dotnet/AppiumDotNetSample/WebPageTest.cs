using NUnit.Framework;
using System;
using Appium.Samples.Helpers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Threading;
using System.Drawing;
using System.Collections;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium.Interfaces;

namespace Appium.Samples
{
    [TestFixture()]
    public class WebPageTest
    {
        private AppiumDriver driver;
        private bool allPassed = true;

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability("platformName", "Android");
            desiredCapabilities.SetCapability("deviceName", "onePlus");
            desiredCapabilities.SetCapability("browserName", "chrome");
            Uri serverUri = AppiumServers.localURI;
            driver = new AppiumDriver(serverUri, desiredCapabilities);
        }

        [TestFixtureTearDown]
        public void AfterAll()
        {
            try
            {
                if (Env.isSauce())
                    ((IJavaScriptExecutor)driver).ExecuteScript("sauce:job-result=" + (allPassed ? "passed" : "failed"));
            }
            finally
            {
                driver.Quit();
            }
        }

        [TearDown]
        public void AfterEach()
        {
            allPassed = allPassed && (TestContext.CurrentContext.Result.State == TestState.Success);
        }

        [Test()]
        public void FindElementTestCase()
        {

            // Navigate to the page and interact with the elements on the guinea-pig page using id.
            driver.Navigate().GoToUrl("http://saucelabs.com/test/guinea-pig");
            IWebElement div = driver.FindElement(By.Id("i_am_an_id"));
            Assert.AreEqual("I am a div", div.Text); //check the text retrieved matches expected value
            driver.FindElement(By.Id("comments")).SendKeys("My comment"); //populate the comments field by id.

            //close the app.
            driver.Quit();
        }


    }
}

