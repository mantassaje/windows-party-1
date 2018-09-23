using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsParty.Services.Contracts
{
    public interface ISessionService
    {
        bool Login(string username, string password);
        string GetToken();
        void Logout();
    }
}
