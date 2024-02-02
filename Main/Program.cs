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

            Main mainGUI = new Main();
    
            CheckAuth authChecker = new CheckAuth(mainGUI);
            authChecker.CheckAuthFiles();

            CheckToken token = new CheckToken();
            token.RefreshChecker();

            Application.Run(mainGUI); // Verwenden Sie die bereits erstellte Instanz von MainGUI
        }
    }
}
