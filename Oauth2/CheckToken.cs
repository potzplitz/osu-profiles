using System;
using System.IO;

namespace osu_profiles
{
    public class CheckToken
    {
        public void RefreshChecker()
        {
            DateTimeOffset currentTime = DateTimeOffset.UtcNow;
            long unixTimestamp = currentTime.ToUnixTimeSeconds();
            
            if (unixTimestamp - int.Parse(File.ReadAllText("C:\\osu!profiles\\requesttime.txt")) >= 86400)
            {
                GetRefreshToken refresh = new GetRefreshToken();
                refresh.RefreshToken();
           }
            else
            {
                Playersearch search = new Playersearch();
                search.InitializeComponent();
            }
        }
    }
}