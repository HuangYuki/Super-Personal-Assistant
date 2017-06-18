using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Class
{
    class ChatLib
    {
        public class ChatSetting
        {
            public static String serverIp = "127.0.0.1";
            public static int port = 3766;
        }

        public delegate String StrHandler(String str, int clientNumber);

        public class ChatSocket
        {
            public Socket socket;
            public NetworkStream stream;
            public StreamReader reader;
            public StreamWriter writer;
            public StrHandler inHandler;
            public EndPoint remoteEndPoint;
            public bool isDead = false;
            public ClientAccount account; //使用者帳戶
            public List<ClientAccount> clientFreindAccount= new List<ClientAccount>();
            public int number = -1;

            public ChatSocket(Socket s)
            {
                socket = s;
                stream = new NetworkStream(s);
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
                remoteEndPoint = socket.RemoteEndPoint;
            }

            public String receive()
            {
                return reader.ReadLine();
            }

            public ChatSocket send(String line)
            {
                writer.WriteLine(line);
                writer.Flush();
                return this;
            }

            public static ChatSocket connect(String ip)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), ChatSetting.port);

                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipep);
                return new ChatSocket(socket);
            }

            public Thread newListener(StrHandler pHandler)
            {
                inHandler = pHandler;

                Thread listenThread = new Thread(new ThreadStart(listen));
                listenThread.Start();
                return listenThread;
            }

            public void listen()
            {
                try
                {
                    while (true)
                    {
                        String line = receive();
                        inHandler(line, number);
                    }
                }
                catch (Exception ex)
                {
                    isDead = true;
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
