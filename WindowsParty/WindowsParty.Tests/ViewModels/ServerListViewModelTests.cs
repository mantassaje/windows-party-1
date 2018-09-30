using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsParty.ViewModels;
using Moq;
using WindowsParty.Services.Contracts;
using log4net;
using WindowsParty.Clients.Contracts;

namespace WindowsParty.Tests.ViewModels
{
    [TestClass]
    public class ServerListViewModelTests
    {
        [TestMethod]
        public void LogoutButton_Click()
        {
            //Setup
            /*var sessionMock = new Mock<ISessionService>();
            var navigationMock = new Mock<INavigationService>();
            var clientMock = new Mock<IApiClient>();
            var model = new ServerListViewModel(sessionMock.Object, navigationMock.Object, clientMock.Object);

            //Act
            model.LogoutButton_Click(null);

            //Assert
            sessionMock.Verify(m => m.Logout(), Times.Once);
            navigationMock.Verify(m => m.Navigate(It.IsAny<object>()), Times.Once);*/
        }
    }
}
