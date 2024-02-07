using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using osu_profiles.EditGui;

namespace osu_profiles.ApiStuff
{
    
    public class GetMeData
    {
        private string MeString;
        public async Task getMe()
        {
            var finishedToken = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(File.ReadAllText("C:/osu!profiles/auth.txt"));
            string access_token = finishedToken.access_token;
            string apiEndpointMe = "https://osu.ppy.sh/api/v2/me/osu";
            Thread.Sleep(1500);
            using (HttpClient httpClient = new HttpClient())
            {
                
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + access_token);
                
                    HttpResponseMessage response = await httpClient.GetAsync(apiEndpointMe);
                    
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        MeString = responseBody;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        if (response.StatusCode == HttpStatusCode.Forbidden)
                        {
                            RegisterAuth auth = new RegisterAuth();
                            auth.Register();
                        }
                        else
                        {
                            GetRefreshToken token = new GetRefreshToken();
                            token.RefreshToken(); 
                        }
                    }
            }
        }

        public string GetMeDataString()
        {
            Console.WriteLine(MeString);
            return MeString;
        }
        
        
    }
}