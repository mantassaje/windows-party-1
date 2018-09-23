using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsParty.Clients.Contracts;
using Autofac.Extensions;
using Autofac;

namespace WindowsParty.ViewModels
{
    public class LoginViewModel
    {
        public async Task<int> Test()
        {
            var test = App.Container.Resolve<IApiClient>();
            //var fuk = await test.PostToken("", "");
            //await Task.Delay(2000);
            return 5;
        }
    }
}
