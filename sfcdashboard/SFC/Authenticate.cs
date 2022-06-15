using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace sfcdashboard.SFC
{
    public class Authenticate
    {
        public const string LoginEndpoint = "https://test.salesforce.com/services/oauth2/token";
        public const string ApiEndpoint = "/services/data/v36.0/";


        private string Username { get; set; }
        private string Password { get; set; }
        private string Token { get; set; }
        private string ClientId { get; set; }
        private string ClientSecret { get; set; }
        private string AuthToken { get; set; }
        private string ServiceUrl { get; set; }

        static readonly HttpClient Client;

        //TODO: Add TLS 1.1/1.2
        static Authenticate()
        {
            Client = new HttpClient();
        }

        void tryConnect()
        {
            HttpContent content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"grant_type",      "password"},
                {"client_id",       ClientId},
                {"client_secret",   ClientSecret},
                {"username",        Username},
                {"password",        Password},
            });

            HttpResponseMessage message = Client.PostAsync(LoginEndpoint, content).Result;
            string response = message.Content.ReadAsStringAsync().Result;
            var obj = JObject.Parse(response);

            AuthToken = (string)obj["access_token"];
            ServiceUrl = (string)obj["instance_url"];

        }
    }
}
