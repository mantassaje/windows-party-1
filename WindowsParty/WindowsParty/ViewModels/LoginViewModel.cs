using System;
using WindowsParty.Views;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WindowsParty.HelpersAndExtensions;
using WindowsParty.Services.Contracts;
using System.ComponentModel;
using System.Windows.Controls;
using log4net;

namespace WindowsParty.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private ISessionService sessionService { get; set; }
        private INavigationService navigationService { get; set; }
        private ILog log { get; set; }

        public ICommand LoginButtonCommand { get; set; }

        public string Username { get; set; } = "tesonet";
        public string Password { get; set; } = "partyanimal";
        private string _errorMessage;
        public string ErrorMessage {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                NotifyPropertyChanged();
            }
        }

        public LoginViewModel(ISessionService sessionService, INavigationService navigationService, ILog log)
        {
            this.sessionService = sessionService;
            this.navigationService = navigationService;
            this.log = log;
            LoginButtonCommand = new RelayCommand(o => LoginButton_Click(o));
        }

        public void LoginButton_Click(object o)
        {
            var success = sessionService.Login(Username, Password);
            if (success)
            {
                log.Info("Loggin succeeded");
                navigationService.Navigate(new ServerList());
            }
            else
            {
                log.Info("Loggin failed");
                ErrorMessage = "Incorrect username or password";
            }
        }
    }
}
