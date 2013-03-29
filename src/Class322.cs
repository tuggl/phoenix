using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
namespace ns0
{
	internal sealed class Class322
	{
		public Socket socket_0;
		public string string_0;
		public int int_0;
		public HashSet<string> hashSet_0;
		public Class322(string string_1, int int_1, string[] string_2, int int_2)
		{
			this.string_0 = "localhost";
			this.int_0 = int_1;
			this.hashSet_0 = new HashSet<string>();
			this.hashSet_0.Add(Phoenix.string_5);
			for (int i = 0; i < string_2.Length; i++)
			{
				string item = string_2[i];
				this.hashSet_0.Add(item);
			}
			try
			{
				this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				this.socket_0.Bind(new IPEndPoint(IPAddress.Parse(Phoenix.smethod_11().dictionary_0["mus.tcp.bindip"]), this.int_0));
				this.socket_0.Listen(int_2);
				this.socket_0.BeginAccept(new AsyncCallback(this.method_0), this.socket_0);
				GClass4.smethod_1("Listening for MUS on port: " + this.int_0);
			}
			catch (Exception ex)
			{
				throw new Exception("Could not set up MUS socket:\n" + ex.ToString());
			}
		}
		public void method_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				Socket socket = ((Socket)iasyncResult_0.AsyncState).EndAccept(iasyncResult_0);
				string item = socket.RemoteEndPoint.ToString().Split(new char[]
				{
					':'
				})[0];
				if (this.hashSet_0.Contains(item))
				{
					new Class323(socket);
				}
				else
				{
					socket.Close();
				}
			}
			catch (Exception)
			{
			}
			this.socket_0.BeginAccept(new AsyncCallback(this.method_0), this.socket_0);
		}
	}
}
