using System;
using System.Net.Sockets;
namespace ns0
{
	internal sealed class Class113
	{
		private GClass1[] gclass1_0;
		private Class114 class114_0;
		public int Int32_0
		{
			get
			{
				int num = 0;
				for (int i = 0; i < this.gclass1_0.Length; i++)
				{
					if (this.gclass1_0[i] != null)
					{
						num++;
					}
				}
				return num;
			}
		}
		public Class113(string string_0, int int_0, int int_1)
		{
			this.gclass1_0 = new GClass1[int_1];
			this.class114_0 = new Class114(string_0, int_0, this);
		}
		public void method_0()
		{
			for (int i = 0; i < this.gclass1_0.Length; i++)
			{
				if (this.gclass1_0[i] != null)
				{
					this.gclass1_0[i].Dispose();
				}
			}
			this.gclass1_0 = null;
			this.class114_0 = null;
		}
		public bool method_1(uint uint_0)
		{
			return this.gclass1_0[(int)((UIntPtr)uint_0)] != null;
		}
		public GClass1 method_2(uint uint_0)
		{
			return this.gclass1_0[(int)((UIntPtr)uint_0)];
		}
		public Class114 method_3()
		{
			return this.class114_0;
		}
		internal int method_4()
		{
			return Array.IndexOf<GClass1>(this.gclass1_0, null);
		}
		internal void method_5(SocketInformation socketInformation_0, int int_0)
		{
			GClass1 gClass = new GClass1(Convert.ToUInt32(int_0), socketInformation_0);
			this.gclass1_0[int_0] = gClass;
			Phoenix.smethod_15().method_2().method_8((uint)int_0, ref gClass);
			if (Phoenix.smethod_11().dictionary_0["emu.messages.connections"] == "1")
			{
				GClass4.smethod_1(string.Concat(new object[]
				{
					">> Connection [",
					int_0,
					"] from [",
					gClass.String_0,
					"]"
				}));
			}
		}
		internal void method_6(uint uint_0)
		{
			this.gclass1_0[(int)((UIntPtr)uint_0)] = null;
		}
		internal void method_7()
		{
			this.class114_0.method_5();
			for (int i = 0; i < this.gclass1_0.Length; i++)
			{
				if (this.gclass1_0[i] != null)
				{
					this.gclass1_0[i].Dispose();
				}
			}
		}
	}
}
