using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace osu_profiles
{
    public class Callback
    {
       private static string authcode;
        
        public void StartCallbackServer()
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 7727; // Ändere den Port nach Bedarf
            
            TcpListener listener = new TcpListener(ipAddress, port);

            try
            {
                listener.Start();
                Console.WriteLine($"Server lauscht auf {"localhost"}:{7727}");
                
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Client verbunden!");
                    
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine($"Empfangener String: {receivedData}");
                    
                    if (receivedData.StartsWith("GET"))
                    {
                        string[] requestParts = receivedData.Split(' ');
                        string url = requestParts[1];
                        
                        Uri uri = new Uri("http://localhost" + url);
                        string query = uri.Query;
                        string[] queryParts = query.Split('=');

                        if (queryParts.Length >= 2 && queryParts[0] == "?code")
                        {
                            authcode = queryParts[1];
                        }
                    }

                    Directory.SetCurrentDirectory(@"C:\Users\Schil_JanR\source\repos\osu!profiles\");
                    string responseString = File.ReadAllText(@"html\authSuccess.html");
                    Console.WriteLine(responseString);
                    byte[] buffer2 = Encoding.UTF8.GetBytes(responseString);

                    string httpResponse = "HTTP/1.1 200 OK\r\n" +
                                          "Content-Length: " + buffer2.Length + "\r\n" +
                                          "Content-Type: text/html; charset=UTF-8\r\n" +
                                          "\r\n";

                    byte[] httpResponseBytes = Encoding.UTF8.GetBytes(httpResponse);
                    
                    stream.Write(httpResponseBytes, 0, httpResponseBytes.Length);
                    stream.Write(buffer2, 0, buffer2.Length);


                    
                    client.Close();

                   
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
            finally
            {
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
