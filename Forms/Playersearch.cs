using System;
using System.Windows.Forms;
using osu_profiles.EditGui;

namespace osu_profiles
{
    public partial class Playersearch : Form
    {
        
        private Playersearch playersearch; // Referenz zur MainGUI-Instanz

        public Playersearch(Playersearch playersearch)
        {
            this.playersearch = playersearch;
        }
        public Playersearch()
        {
            InitializeComponent();
        }

        private void name_Click(object sender, EventArgs e)
        {
                                                     
        }

        private void label1_Click(object sender, EventArgs e)
        {
                       
        }

        private void Playersearch_Load(object sender, EventArgs e)
        {
            EditPlayersearch search = new EditPlayersearch(new Playersearch());
            search.editSearch();
        }
    }
}

