using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using osu_profiles.ApiStuff;

namespace osu_profiles
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            CheckAuth auth = new CheckAuth();
            auth.CheckAuthFiles();
            
            CheckToken token = new CheckToken();
            token.RefreshChecker();
            
            Application.Run(new MainGUI());
            
            
        }
    }
}
