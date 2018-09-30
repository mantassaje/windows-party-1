using Caliburn.Micro;
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
    public class ServerListViewModel : Caliburn.Micro.Screen
    {
        private ISessionService sessionService { get; set; }
        private IEventAggregator eventAggregator { get; set; }
        private IApiClient apiClient { get; set; }

        public BindableCollection<Server> Servers { get; } = new BindableCollection<Server>();

        public ServerListViewModel(ISessionService sessionService, IEventAggregator eventAggregator, IApiClient apiClient)
        {
            this.sessionService = sessionService;
            this.eventAggregator = eventAggregator;
            this.apiClient = apiClient;
        }

        protected override async void OnActivate()
        {
            base.OnActivate();
            var token = await sessionService.GetToken();
            var serversResult = await apiClient.GetServers(token);
            //Servers = );
        }

        public void LogoutButton_Click(object sender)
        {
            sessionService.Logout();
            eventAggregator.ChangeScreen<LoginViewModel>();
        }
    }
}
