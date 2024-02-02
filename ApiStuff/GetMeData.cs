using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;

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
                        
                        var username = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(responseBody);
                        string tornusername = username.username;
                        
                       // Console.WriteLine(responseBody);
                       
                    }
                    else
                    {
                        if (response.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            Console.WriteLine("nicht autorisiert");
                            GetRefreshToken refresh = new GetRefreshToken();
                            refresh.RefreshToken();
                            
                            Thread.Sleep(1500);
                        }
                    }
                

                
            }
        }

        public string GetMeDataString()
        {
            return MeString;
        }
        
        
    }
}