

using System;
using System.Threading;
using System.Threading.Tasks;
using osu_profiles.ApiStuff;

namespace osu_profiles.EditGui
{
    public class EditMe
    {
        public async void Edit()
        {
            MainGUI gui = new MainGUI();
            GetMeData data = new GetMeData();
            Task.Run(() => data.getMe()).Wait();
            
            Thread.Sleep(1000); // temporärer fix, kommt weg wenn das mit dem Wait() funktioniert
            
            Console.WriteLine("der string in editme:           " + data.GetMeDataString());
            
            var finishedToken = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data.GetMeDataString());
            string profileName = finishedToken.username;
            
            

            gui.authorized.Text = profileName;
        }
    }
}