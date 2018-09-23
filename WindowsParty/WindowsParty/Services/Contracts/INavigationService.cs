using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WindowsParty.Services.Contracts
{
    public interface INavigationService
    {
        void SetMainFrame(Frame frame);
        void Navigate(object page);
    }
}
