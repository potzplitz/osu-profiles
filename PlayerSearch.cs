﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_profiles
{
    class PlayerSearch
    {
        public void startButtonSearch(string playername)
        {
            Console.WriteLine("Spielersuche nach " + playername + " gestartet.");
            Callback callback = new Callback();
            callback.StartCallbackServer();

            oauth2 auth = new oauth2();
            auth.StartAuthentication();
        }

    }
}
