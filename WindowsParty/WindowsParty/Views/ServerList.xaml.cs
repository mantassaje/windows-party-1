using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowsParty.Models;

namespace WindowsParty.Views
{
    /// <summary>
    /// Interaction logic for ServerList.xaml
    /// </summary>
    public partial class ServerList : Page
    {
        public ServerList()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
            this.ServerListDataGrid.AutoGeneratingColumn += OnAutoGeneratingColumn;
            this.ServerListDataGrid.ItemsSource = GetServers();
        }

        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = e.Column.Header.ToString().ToUpper();
        }

        public List<Server> GetServers()
        {
            return new List<Server>()
            {
                new Server()
                {
                    Distance = 123,
                    Name = "Poland",
                },
                new Server()
                {
                    Distance = 4651,
                    Name = "Vilnius",
                },
                new Server()
                {
                    Distance = 952,
                    Name = "Scotland",
                },
            };
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            var nextPage = new Login();
            navService.Navigate(nextPage);
        }
    }
}
