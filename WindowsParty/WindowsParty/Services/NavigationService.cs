using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WindowsParty.Services.Contracts;

namespace WindowsParty.Services
{
    public class NavigationService : INavigationService
    {
        private Frame frame { get; set; }
        public void SetMainFrame(Frame frame)
        {
            this.frame = frame;
        }
        public void Navigate(object page)
        {
            frame.Navigate(page);
        }
    }
}
