using System.Threading;

namespace osu_profiles
{
    public class RegisterAuth
    {
        public void Register()
        {
            System.Diagnostics.Process.Start("https://osu.ppy.sh/oauth/authorize?client_id=29963&redirect_uri=http://127.0.0.1:7727&response_type=code&scope=identify%20public");

            Callback cb = new Callback();
            cb.StartCallbackServer();
        }
    }
}