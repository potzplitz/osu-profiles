using System;
using System.Threading;
using System.Windows.Forms;
using osu_profiles.ApiStuff;

namespace osu_profiles.EditGui
{
    public class EditPlayersearch
    {

        private Playersearch mainGUI;

        public EditPlayersearch(Playersearch playersearch)
        {
            this.mainGUI = mainGUI;
        }

        public async void editSearch()
        {

            GetMeData data = new GetMeData();
            Console.WriteLine("waiting");
            data.getMe().Wait();
            
            
            
            string apiresponse = data.GetMeDataString();
            
            if (apiresponse != null)
            {
                var finishedToken = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(data.GetMeDataString());
                    
                    Console.WriteLine("test");

                mainGUI.meName.Text = finishedToken.username;
                mainGUI.meRank.Text = "#" + finishedToken.rank_history.data[89];
            }
            else
            {
            }
        }
    }
}