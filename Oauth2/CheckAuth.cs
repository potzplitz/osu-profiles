using System.IO;

namespace osu_profiles
{
    public class CheckAuth
    {
        public void CheckAuthFiles() // Check if user is authenticated
        {
           if (!Directory.Exists("C:\\osu!profiles")) // Check if directory of osu!profiles exists
           {
               Directory.CreateDirectory("C:\\osu!profiles");
           }

           if (!File.Exists("C:\\osu!profiles\\auth.txt")) // Check if auth file exists
           {
               File.Create("C:\\osu!profiles\\auth.txt");
           }
           
           if (!File.Exists("C:\\osu!profiles\\requesttime.txt")) // Check if auth file exists
           {
               File.Create("C:\\osu!profiles\\requesttime.txt");
           }

           if (File.ReadAllText("C:/osu!profiles/requesttime.txt").Length == 0)
           {
               RegisterAuth reg = new RegisterAuth();
               reg.Register();
           }

        }
    }
}