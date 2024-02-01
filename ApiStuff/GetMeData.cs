using System;
using System.IO;
using System.Net.Http;

namespace osu_profiles.ApiStuff
{
    
    public class GetMeData
    {
        private string MeString;
        public async void getMe()
        {
            var finishedToken = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(File.ReadAllText("C:/osu!profiles/auth.txt"));
            string access_token = finishedToken.access_token;
            
            string apiEndpointMe = "https://osu.ppy.sh/api/v2/me";

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
                    }
                

                
            }
        }

        public string GetMeDataString()
        {
            return MeString;
        }
        
        
    }
}