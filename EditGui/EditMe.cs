

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using osu_profiles.ApiStuff;

namespace osu_profiles.EditGui
{
    public class EditMe
    {
        private Main mainGUI;
        
        public EditMe(Main mainGUI)
        {
            this.mainGUI = mainGUI;
        }
        public async void Edit()
        {
            Main gui = new Main();
            GetMeData data = new GetMeData();
            Task.Run(() => data.getMe()).Wait();
            
            Thread.Sleep(2000); // temporärer fix, kommt weg wenn das mit dem Wait() funktioniert

            if (!(data.GetMeDataString() == null))
            {
                var finishedToken = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data.GetMeDataString());
            
                mainGUI.authorized.Text = finishedToken.username;
                mainGUI.rank.Text = "#" + finishedToken.rank_history.data[89];
            }
            else
            {
                mainGUI.authorized.Text = "fehler";
            }
        }
    }
}