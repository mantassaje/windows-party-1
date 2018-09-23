using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WindowsParty.Clients.Contracts;
using WindowsParty.HelpersAndExtensions;
using WindowsParty.Models;
using WindowsParty.Services.Contracts;
using WindowsParty.Views;

namespace WindowsParty.ViewModels
{
    public class ServerListViewModel : ViewModelBase
    {
        private ISessionService sessionService { get; set; }
        private INavigationService navigationService { get; set; }
        private IApiClient apiClient { get; set; }

        public ICommand LogoutButtonCommand { get; set; }

        private List<Server> _servers;
        public List<Server> Servers
        {
            get
            {
                return _servers;
            }
            set
            {
                _servers = value;
                NotifyPropertyChanged();
            }
        }

        public ServerListViewModel(ISessionService sessionService, INavigationService navigationService, IApiClient apiClient)
        {
            this.sessionService = sessionService;
            this.navigationService = navigationService;
            this.apiClient = apiClient;
            LogoutButtonCommand = new RelayCommand(o => LogoutButton_Click(o));
            var serversResponse = apiClient.GetServers(sessionService.GetToken());
            Servers = serversResponse?.Data;
        }

        public void LogoutButton_Click(object sender)
        {
            sessionService.Logout();
            navigationService.Navigate(new Login());
        }
    }
}
