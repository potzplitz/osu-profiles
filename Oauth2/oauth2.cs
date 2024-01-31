using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace osu_profiles
{
    class oauth2
    {
        private bool authenticationStarted = false; // Variable zur Verfolgung, ob die Authentifizierung bereits gestartet wurde
        private static int alreadexecuted = 0;

        public async Task StartAuthentication()
        {
            if (authenticationStarted)
            {
                Console.WriteLine("Authentifizierung wurde bereits gestartet.");
                return;
            }

            authenticationStarted = true; // Markiere, dass die Authentifizierung gestartet wurde
            
            Callback callback = new Callback();
            string authcode = callback.getAuthCode();
            
            string tokenUrl = "https://osu.ppy.sh/oauth/token";
            string clientId = "29963";
            string clientSecret = "12XPn5Gk6cknB82Tghavzk2IF7oCwpAvYcV1Nc8V";
            string redirectUri = "http://127.0.0.1:7727"; // Passe die Redirect-URI entsprechend an
            string authorizationCode = callback.getAuthCode(); // Der erhaltene Authorization-Code

            using (HttpClient client = new HttpClient())
            {
                var tokenRequest = new Dictionary<string, string>
                {
                    { "client_id", clientId },
                    { "client_secret", clientSecret },
                    { "code", authorizationCode },
                    { "grant_type", "authorization_code" },
                    { "redirect_uri", redirectUri }
                };

                var content = new FormUrlEncodedContent(tokenRequest);

                var response = await client.PostAsync(tokenUrl, content);

                
                Console.WriteLine(alreadexecuted);
                
                if (alreadexecuted == 0)
                {
                    
                   

                if (response.IsSuccessStatusCode)
                {
                    alreadexecuted = 1;
                    var tokenResponse = await response.Content.ReadAsStringAsync();
                    DateTimeOffset currentTime = DateTimeOffset.UtcNow;
                    long unixTimestamp = currentTime.ToUnixTimeSeconds();
                    File.WriteAllText("C:\\osu!profiles\\auth.txt", tokenResponse);
                    File.WriteAllText("C:\\osu!profiles\\requesttime.txt", unixTimestamp + "");
                    
                    Console.WriteLine(tokenResponse);

                    
                }
                else
                {
                    Console.WriteLine("Fehler beim Anfordern des Zugriffstokens.");
                    Console.WriteLine(response.ToString());
                }
            }
        }
        }
    }
}
