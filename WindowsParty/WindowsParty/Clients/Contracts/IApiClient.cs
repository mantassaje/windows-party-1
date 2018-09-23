using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsParty.Models;

namespace WindowsParty.Clients.Contracts
{
    public interface IApiClient
    {
        //http://playground.tesonet.lt/v1/tokens
        Task<AuthToken> PostTokenAsync(string username, string password);
        Task<List<Server>> GetServersAsync();
        IRestResponse<AuthToken> PostToken(string username, string password);
        IRestResponse<List<Server>> GetServers(string token);
    }
}
