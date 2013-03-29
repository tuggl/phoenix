using System;
using System.Collections.Generic;
using System.Text;
namespace ns0
{
	public sealed class GClass5
	{
		private uint uint_0;
		private List<byte> list_0;
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
				return Phoenix.smethod_13().GetString(GClass6.smethod_1(this.uint_0, 2));
			}
		}
		public int Int32_0
		{
			get
			{
				return this.list_0.Count;
			}
		}
		public GClass5()
		{
		}
		public GClass5(uint uint_1)
		{
			this.method_2(uint_1);
		}
		public override string ToString()
		{
			return this.String_0 + Phoenix.smethod_13().GetString(this.list_0.ToArray());
		}
		public string method_0()
		{
			return Phoenix.smethod_13().GetString(this.list_0.ToArray());
		}
		public void method_1()
		{
			this.list_0.Clear();
		}
		public void method_2(uint uint_1)
		{
			this.uint_0 = uint_1;
			this.list_0 = new List<byte>();
		}
		public void method_3(byte byte_0)
		{
			this.list_0.Add(byte_0);
		}
		public void method_4(byte[] byte_0)
		{
			if (byte_0 != null && byte_0.Length != 0)
			{
				this.list_0.AddRange(byte_0);
			}
		}
		public void method_5(string string_0, Encoding encoding_0)
		{
			if (string_0 != null && string_0.Length != 0)
			{
				this.method_4(encoding_0.GetBytes(string_0));
			}
		}
		public void method_6(string string_0)
		{
			this.method_5(string_0, Phoenix.smethod_13());
		}
		public void method_7(string string_0)
		{
			this.method_8(string_0, 2);
		}
		public void method_8(string string_0, byte byte_0)
		{
			this.method_6(string_0);
			this.method_3(byte_0);
		}
		public void method_9(int int_0)
		{
			this.method_4(GClass7.smethod_0(int_0));
		}
		public void method_10(int int_0)
		{
			this.method_5(int_0.ToString(), Encoding.ASCII);
		}
		public void method_11(uint uint_1)
		{
			this.method_9((int)uint_1);
		}
		public void method_12(uint uint_1)
		{
			this.method_10((int)uint_1);
		}
		public void method_13(bool bool_0)
		{
			if (bool_0)
			{
				this.list_0.Add(73);
			}
			else
			{
				this.list_0.Add(72);
			}
		}
		public byte[] method_14()
		{
			byte[] array = new byte[this.Int32_0 + 3];
			byte[] array2 = GClass6.smethod_1(this.uint_0, 2);
			array[0] = array2[0];
			array[1] = array2[1];
			for (int i = 0; i < this.Int32_0; i++)
			{
				array[i + 2] = this.list_0[i];
			}
			array[array.Length - 1] = 1;
			return array;
		}
	}
}
