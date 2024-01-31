using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace osu_profiles
{
    public class Callback
    {
       private static string authcode;
        
        public void StartCallbackServer()
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1"); // Ändere die IP-Adresse nach Bedarf
            int port = 7727; // Ändere den Port nach Bedarf

            // Erstelle eine TCP/IP-Listener-Socket
            TcpListener listener = new TcpListener(ipAddress, port);

            try
            {
                // Starte den Listener
                listener.Start();
                Console.WriteLine($"Server lauscht auf {"localhost"}:{7727}");

                // Warte auf eingehende Verbindungen
           
                    // Akzeptiere eine eingehende Verbindung
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Client verbunden!");

                    // Lese den empfangenen String
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine($"Empfangener String: {receivedData}");
                    
                    if (receivedData.StartsWith("GET"))
                    {
                        // Extrahiere die URL aus der Anforderung
                        string[] requestParts = receivedData.Split(' ');
                        string url = requestParts[1];

                        // Verwende die Uri-Klasse, um den Authorization-Code zu extrahieren
                        Uri uri = new Uri("http://localhost" + url);
                        string query = uri.Query;
                        string[] queryParts = query.Split('=');

                        if (queryParts.Length >= 2 && queryParts[0] == "?code")
                        {
                            authcode = queryParts[1];
                        }
                    }

                    // Schließe die Verbindung
                    client.Close();

                   
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
            finally
            {
                // Beende den Listener
                listener.Stop();
            }

            oauth2 auth = new oauth2();
            auth.StartAuthentication();
        }

        public string getAuthCode()
        {
            return authcode;
        }
        
    }
}
