using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsParty.ViewModels;
using Moq;
using WindowsParty.Services.Contracts;
using log4net;

namespace WindowsParty.Tests.ViewModels
{
    [TestClass]
    public class LoginViewModelTests
    {
        [DataRow(true)]
        [DataRow(false)]
        [DataTestMethod]
        public void LoginButton_Click(bool loginResult)
        {
            //Setup
            /*var sessionMock = new Mock<ISessionService>();
            sessionMock.Setup(m => m.Login(It.Is<string>(v => v == "test"), It.Is<string>(v => v == "pass"))).Returns(loginResult);
            var navigationMock = new Mock<INavigationService>();
            var logMock = new Mock<ILog>();
            var model = new LoginViewModel(sessionMock.Object, navigationMock.Object);
            model.Password = "pass";
            model.Username = "test";

            //Act
            model.LoginButton_Click(null);

            //Assert
            sessionMock.Verify(m => m.Login(It.Is<string>(v => v == "test"), It.Is<string>(v => v == "pass")), Times.Once);
            if (loginResult) navigationMock.Verify(m => m.Navigate(It.IsAny<object>()), Times.Once);
            else Assert.IsNotNull(model.ErrorMessage);*/
        }
    }
}
