using System;
using System.IO;
using System.Threading.Tasks;
using osu_profiles.ApiStuff;
using osu_profiles.EditGui;

namespace osu_profiles
{
    public class CheckAuth
    {
        
        private Main mainGUI; // Referenz zur MainGUI-Instanz

        public CheckAuth(Main mainGUI)
        {
            this.mainGUI = mainGUI;
        }
        
        public async void CheckAuthFiles() // Check if user is authenticated
        {
            int check = 0;
            
            
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

           if (new FileInfo( "C:/osu!profiles/requesttime.txt" ).Length == 0)
           {
               RegisterAuth reg = new RegisterAuth();
               reg.Register();
               
               Console.WriteLine("Check failed at requesttime.txt");
               
           }
           else
           {
               Console.WriteLine("Check successful at requesttime.txt");
               check++;
           }
           
           if (new FileInfo( "C:/osu!profiles/auth.txt" ).Length == 0)
           {
               RegisterAuth reg = new RegisterAuth();
               reg.Register();
              
               Console.WriteLine("check failed at auth.txt");
           }
           else
           {
               Console.WriteLine("check successful at auth.txt");
               check++;
           }

           if (check == 2)
           {
               Console.WriteLine("check successful");
               //GetMeData me = new GetMeData();
               //await Task.Run(() => me.getMe());

               int reg = 0;

               if (reg == 1)
               {
                   RegisterAuth auth = new RegisterAuth();
                   auth.Register();
               }
               
               
               
               EditMe edit = new EditMe(mainGUI);
               edit.Edit();


           }
        }
    }
}