using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsParty.Clients.Contracts;
using WindowsParty.HelpersAndExtensions;
using WindowsParty.Models;
using WindowsParty.Services.Contracts;

namespace WindowsParty.Clients
{
    public class ApiClient : IApiClient
    {
        private readonly string ApiBaseUrl = "http://playground.tesonet.lt/v1";

        public IRestResponse<List<Server>> GetServers(string token)
        {
            var client = new RestClient(ApiBaseUrl);
            var request = new RestRequest("servers");
            request.AddHeader("Authorization", $"Bearer {token}");
            var response = client.Get<List<Server>>(request);
            return response;
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

        public IRestResponse<AuthToken> PostToken(string username, string password)
        {
            var client = new RestClient(ApiBaseUrl);
            var request = new RestRequest("tokens");
            request.AddHeader("Content-Type", "application/json");
            request.AddLowerCamelJsonBody(new AuthTokenRequest()
            {
                Password = password,
                Username = username
            });
            var response = client.Post<AuthToken>(request);
            return response;
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
