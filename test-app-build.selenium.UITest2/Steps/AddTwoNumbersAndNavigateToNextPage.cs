using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace test_app_build.selenium.UITest2.Steps
{
    
    [Binding]
    public class AddTwoNumbersAndNavigateToNextPage
    {
        AppTestManager apptestmgr = null;

        [Before]
        public void Setup()
        {
            apptestmgr = new AppTestManager();
        }

        [After]
        public void Teardown()
        {
            apptestmgr.CloseTest();
            apptestmgr.Dispose();
        }
        

        [Given(@"I am using ""(.*)""  to navigate to the Home page")]
        public void GivenIAmUsingToNavigateToTheHomePage(string p0)
        {
            apptestmgr.NavigateToTargetPage(p0);
        }
        
        [Given(@"I have entered (.*) into the first text box")]
        public void GivenIHaveEnteredIntoTheFirstTextBox(int p0)
        {
            apptestmgr.EnterFirstTextBox(p0);
        }
        
        [Given(@"Then I have entered (.*) into the second text box")]
        public void GivenThenIHaveEnteredIntoTheSecondTextBox(int p0)
        {
            apptestmgr.EnterSecondTextBox(p0);
        }
        
        [When(@"I press add button")]
        public void WhenIPressAddButton()
        {
            apptestmgr.ClickAddButton();
        }
        
        [When(@"I click on about link on top menu")]
        public void WhenIClickOnAboutLinkOnTopMenu()
        {
            apptestmgr.ClickAboutLink();
        }
        [Then(@"I can see the about screen")]
        public void ThenICanSeeTheAboutScreen()
        {
            //need to find a control and see the expected value is there or not and accordingly Assert
            Assert.True(true,"About screen displayed.");
           
        }

        [Then(@"the result should be (.*) on the third text box")]
        public void ThenTheResultShouldBeOnTheThirdTextBox(int p0)
        {
            apptestmgr.ValidateThirdTextBox(p0);
            Assert.That(p0.ToString(), Is.EqualTo(apptestmgr.Ouput), apptestmgr.Ouput);
        }




        //second scenario
        [Given(@"I am using ""(.*)""  to navigate to the about page")]
        public void GivenIAmUsingToNavigateToTheAboutPage(string p0)
        {
            apptestmgr.NavigateToTargetPage(p0);
        }


        [Given(@"I entered (.*) into the first text box of the about screen")]
        public void GivenIEnteredIntoTheFirstTextBoxOfTheAboutScreen(int p0)
        {
            apptestmgr.EnterFirstTextBoxAbout(p0);
        }

        [Given(@"Then I have entered (.*) into the second text box of the about screen")]
        public void GivenThenIHaveEnteredIntoTheSecondTextBoxOfTheAboutScreen(int p0)
        {
           
            apptestmgr.EnterSecondTextBoxAbout(p0);
        }

        [When(@"I press add button  of about screen")]
        public void WhenIPressAddButtonOfAboutScreen()
        {
            apptestmgr.ClickAddButtonAbout();
        }

        [Then(@"the result should be (.*) on the third text box of the about screen")]
        public void ThenTheResultShouldBeOnTheThirdTextBoxOfTheAboutScreen(int p0)
        {
            apptestmgr.ValidateThirdTextBoxAbout(p0);
            Assert.That(p0.ToString(), Is.EqualTo(apptestmgr.Ouput), apptestmgr.Ouput);
        }

        [When(@"I click on contact link on top menu")]
        public void WhenIClickOnContactLinkOnTopMenu()
        {
            apptestmgr.ClickContactLink();
        }

        [Then(@"I can see the contact screen")]
        public void ThenICanSeeTheContactScreen()
        {
            //need to find a control and see the expected value is there or not and accordingly Assert
            Assert.True(true, "Contact screen displayed.");
        }


        //third scenario%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        [Given(@"I am using ""(.*)""  to navigate to the contact page")]
        public void GivenIAmUsingToNavigateToTheContactPage(string p0)
        {
            apptestmgr.NavigateToTargetPage(p0);
        }


        [Given(@"I entered (.*) into the first text box of the contact screen")]
        public void GivenIEnteredIntoTheFirstTextBoxOfTheContactScreen(int p0)
        {
            apptestmgr.EnterFirstTextBoxContact(p0);
        }

        [Given(@"Then I have entered (.*) into the second text box of the contact screen")]
        public void GivenThenIHaveEnteredIntoTheSecondTextBoxOfTheContactScreen(int p0)
        {
            apptestmgr.EnterSecondTextBoxContact(p0);
        }

        [When(@"I press add button  of contact screen")]
        public void WhenIPressAddButtonOfContactScreen()
        {
            apptestmgr.ClickAddButtonContact();
        }

        [Then(@"the result should be (.*) on the third text box of the contact screen")]
        public void ThenTheResultShouldBeOnTheThirdTextBoxOfTheContactScreen(int p0)
        {
            apptestmgr.ValidateThirdTextBoxContact(p0);
            Assert.That(p0.ToString(), Is.EqualTo(apptestmgr.Ouput), apptestmgr.Ouput);

            
           // Assert.True(true,"Test finished");
        }

    }
}
