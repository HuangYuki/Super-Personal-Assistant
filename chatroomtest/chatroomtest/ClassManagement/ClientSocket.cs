using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;

namespace chatroomtest.ClassManagement
{
	public delegate String StrHandler(String str);

	class ClientSocket
	{
		public Socket socket;
		public NetworkStream stream;
		public StreamReader reader;
		public StreamWriter writer;
		public StrHandler inHandler;
		public EndPoint remoteEndPoint;
		public bool isDead = false;

		public ClientSocket(Socket s)
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

		public ClientSocket send(String line)
		{
			writer.WriteLine(line);
			writer.Flush();
			return this;
		}

		public static ClientSocket connect(String ip)
		{
			IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), ConectionSetting.port);  //目的位址及埠號

			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket.Connect(ipep);
			return new ClientSocket(socket);
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
					inHandler(line);
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
