using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsParty.Clients.Contracts;
using WindowsParty.Models;

namespace WindowsParty.Clients
{
    public class ApiClient : IApiClient
    {
        public List<Server> GetServers()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Server>> GetServersAsync()
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

        public AuthToken PostToken(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<AuthToken> PostTokenAsync(string username, string password)
        {
            return new AuthToken()
            {
                Token = "sd1kyu546w54l5ewub9ku894sdi9gr4434jb923u"
            };
        }
    }
}
