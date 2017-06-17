using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace chatroomtest.ManagementClass
{
	public class ConectionSetting
	{
		public static String serverIp = "10.100.3.192";
		public static int port = 3766;
	}

	public delegate String StrHandler(String str);

	public class ClientSocket
	{
		public Socket socket;
		public NetworkStream stream;  //提供網路存取的資料流
		public StreamReader reader;
		public StreamWriter writer;
		public StrHandler inHandler;
		public EndPoint remoteEndPoint;
		public bool isDead = false;

		public ClientSocket(Socket s)
		{
			socket = s;
			stream = new NetworkStream(s);  //建立新執行個體NetworkStream指定的Socket
			reader = new StreamReader(stream); 
			writer = new StreamWriter(stream);
			remoteEndPoint = socket.RemoteEndPoint;  //取得Socket遠端端點
		}

		//public ClientSocket(){
		//	connect(ConectionSetting.serverIp);
		//}


		public String receive()
		{
			return reader.ReadLine();  //自目前資料流讀取一行字元，並將資料以字串傳回
		}

		public ClientSocket send(String line)
		{
			MessageBox.Show(line);
			writer.WriteLine(line);  //將字串寫入資料流
			writer.Flush();  //清除Writer的所有緩衝區
			return this;
		}

		public static ClientSocket connect(String ip)
		{
			IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), ConectionSetting.port);  //目的IP位址及埠號

			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			//初始化的新執行個體 Socket 類別使用指定的通訊協定家族、 通訊端類型和通訊協定。
			socket.Connect(ipep);  //建立與遠端主機的連接。
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
