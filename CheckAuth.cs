using System.IO;

namespace osu_profiles
{
    public class CheckAuth
    {
        public void CheckAuthentication() // Check if user is authenticated
        {
           if (!Directory.Exists("C:\\osu!profiles")) // Check if directory of osu!profiles exists
           {
               Directory.CreateDirectory("C:\\osu!profiles");
           }

         
               
            
            
           
        }
    }
}