using System;
using System.Collections.Generic;
using System.Net.Http;
using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using osu_profiles.ApiStuff;

namespace osu_profiles
{
  public class GetRefreshToken
    {
        public async void RefreshToken()
        {
            
            var finishedToken = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(File.ReadAllText("C:/osu!profiles/auth.txt"));

            string refresh_token = finishedToken.refresh_token;

            string tokenUrl = "https://osu.ppy.sh/oauth/token";
            string clientId = "29963";
            string clientSecret = "12XPn5Gk6cknB82Tghavzk2IF7oCwpAvYcV1Nc8V";
            string redirectUri = "http://127.0.0.1:7727";
            string refreshCode = refresh_token;

            using (HttpClient client = new HttpClient())
            {
                var tokenRequest = new Dictionary<string, string>
                {
                    { "client_id", clientId },
                    { "client_secret", clientSecret },
                    { "grant_type", "refresh_token" },
                    { "refresh_token", refreshCode },
                    { "scope", "public" } // Anpassen je nach benötigtem Scope
                };

                var content = new FormUrlEncodedContent(tokenRequest);

                try
                {
                    var response = await client.PostAsync(tokenUrl, content);
                    var tokenResponse = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        File.WriteAllText("C:/osu!profiles/auth.txt", tokenResponse);
                        GetMeData data = new GetMeData();
                      //  data.getMe();

                    }
                    else
                    {
                        Console.WriteLine("Fehler beim Anfordern des Zugriffstokens.");
                       Console.WriteLine(response.ToString());
                       
                       RegisterAuth auth = new RegisterAuth();
                       auth.Register();
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine("Fehler bei der HTTP-Anfrage: " + ex.Message);
                }
            }
        }
    }
}