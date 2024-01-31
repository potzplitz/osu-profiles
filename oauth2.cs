using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_profiles
{
    class oauth2
    {
        public void StartAuthentication()
        {
            Constants constants = new Constants();
            string link = "https://osu.ppy.sh/oauth/authorize?client_id=" + constants.clientID + "&redirect_uri=http://localhost:7727&response_type=code&scope=identify%20public";
        }
    }
}
