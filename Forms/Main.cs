using System;
using System.Windows.Forms;

namespace osu_profiles
{
    public partial class Main : Form
    {
        
        private Main mainGUI; // Referenz zur MainGUI-Instanz

        public Main(Main mainGUI)
        {
            this.mainGUI = mainGUI;
        }
        public Main()
        {
            InitializeComponent();
            
            
            
        }
        
        

        private void rank_Click(object sender, EventArgs e)
        {
        }

        private void authorized_Click(object sender, EventArgs e)
        {
        }

        private void ButtonAuthorize_Click(object sender, EventArgs e)
        {
            CheckToken token = new CheckToken();
            token.RefreshChecker();
            
            
            
        }
    }
}