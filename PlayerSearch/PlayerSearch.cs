using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_profiles
{
    class PlayerSearch
    {
        
        private Main mainGUI; // Referenz zur MainGUI-Instanz

        public PlayerSearch(Main mainGUI)
        {
            this.mainGUI = mainGUI;
        }
        public void startButtonSearch(string playername)
        {
            if (playername.Length <= 16)
            {
                
            }
            
            Console.WriteLine("Spielersuche nach " + playername + " gestartet.");
            
            
            
        }

    }
}
