﻿using Autofac;
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
using WindowsParty.ViewModels;

namespace WindowsParty.Views
{
    public partial class ServerList : Page
    {
        public ServerList()
        {
            InitializeComponent();
            this.DataContext = App.Container?.Resolve<ServerListViewModel>();
        }
    }
}
