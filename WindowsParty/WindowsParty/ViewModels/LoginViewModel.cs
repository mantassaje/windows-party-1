using System;
using WindowsParty.Views;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WindowsParty.HelpersAndExtensions;
using WindowsParty.Services.Contracts;
using System.ComponentModel;
using System.Windows.Controls;
using log4net;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace WindowsParty.ViewModels
{
    public class LoginViewModel : Screen
    {
        private ISessionService sessionService { get; set; }
        private IEventAggregator eventAggregator { get; set; }
        private log4net.ILog log { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        private string errorMessage;
        public string ErrorMessage
        {
            get => errorMessage;
            set => Set(ref errorMessage, value);
        }

        public LoginViewModel(ISessionService sessionService, IEventAggregator eventAggregator)
        {
            this.sessionService = sessionService;
            this.eventAggregator = eventAggregator;
            this.log = log4net.LogManager.GetLogger(typeof(LoginViewModel));
        }

        public async Task Login()
        {
            var success = await sessionService.Login(Username, Password);
            if (success)
            {
                log.Info("Loggin succeeded");
                Cleanup();
                eventAggregator.ChangeScreen<ServerListViewModel>();
            }
            else
            {
                log.Info("Loggin failed");
                ErrorMessage = "Incorrect username or password";
            }
        }

        private void Cleanup()
        {
            Username = null;
            Password = null;
            ErrorMessage = null;
        }
    }
}
