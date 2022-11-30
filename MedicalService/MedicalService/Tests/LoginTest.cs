using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalService.Driver;
using MedicalService.Page;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace MedicalService.Tests
{
    public class LoginTest
    {
        LoginPage loginPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            
        }

        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void TC01_EnterInvalideUserName()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("Katarina", "ThisIsNotAPassword");

            Assert.That("Login failed! Please ensure the username and password are valid.", Is.EqualTo(loginPage.UserNotLogin.Text));

        }
        //[Test]
        //public void TC02_EnterInvalidPassword_SholudNotBeLogOnPage()
        //{

        //    loginPage.AppMedic.Click();
        //    loginPage.Login("John Doe", "Katarinaaa");

        //    Assert.That(Massege, Is.EqualTo(loginPage.UserNotLogin.Text));


            [Test]
            public void TC03_EnterInvalidPassword_SholudNotBeLogOnPage()
            {
                loginPage.AppMedic.Click();
                loginPage.Login("", "");

                Assert.That("Login failed! Please ensure the username and password are valid.", Is.EqualTo(loginPage.UserNotLogin.Text));
            }



    }

}

