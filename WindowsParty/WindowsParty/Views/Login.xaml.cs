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
using WindowsParty.Clients.Contracts;
using WindowsParty.ViewModels;

namespace WindowsParty.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
            this.ShowsNavigationUI = false;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            //var rez = new NotifyTaskCompletion<int>(((LoginViewModel)DataContext).Test());
            var test = ((LoginViewModel)DataContext).Test().Result;
            NavigationService navService = NavigationService.GetNavigationService(this);
            var nextPage = new ServerList();
            navService.Navigate(nextPage);
        }
    }
}
