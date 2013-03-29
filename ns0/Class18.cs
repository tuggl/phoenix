using System;
using System.Text;
namespace ns0
{
	internal sealed class Class18
	{
		private uint uint_0;
		private byte[] byte_0;
		private int int_0;
		public uint UInt32_0
		{
			get
			{
				return this.uint_0;
			}
		}
		public int Int32_0
		{
			get
			{
				return this.byte_0.Length;
			}
		}
		public int Int32_1
		{
			get
			{
				return this.byte_0.Length - this.int_0;
			}
		}
		public string String_0
		{
			get
			{
				return Encoding.Default.GetString(GClass6.smethod_1(this.uint_0, 2));
			}
		}
		public Class18(uint uint_1, byte[] byte_1)
		{
			if (byte_1 == null)
			{
				byte_1 = new byte[0];
			}
			this.uint_0 = uint_1;
			this.byte_0 = byte_1;
			this.int_0 = 0;
		}
		public override string ToString()
		{
			return this.String_0 + Phoenix.smethod_13().GetString(this.byte_0);
		}
		public void method_0()
		{
			this.int_0 = 0;
		}
		public void method_1(int int_1)
		{
			this.int_0 += int_1;
		}
		public string method_2()
		{
			return Encoding.Default.GetString(this.byte_0);
		}
		public byte[] method_3(int int_1)
		{
			if (int_1 > this.Int32_1)
			{
				int_1 = this.Int32_1;
			}
			byte[] array = new byte[int_1];
			for (int i = 0; i < int_1; i++)
			{
				array[i] = this.byte_0[this.int_0++];
			}
			return array;
		}
		public byte[] method_4(int int_1)
		{
			if (int_1 > this.Int32_1)
			{
				int_1 = this.Int32_1;
			}
			byte[] array = new byte[int_1];
			int i = 0;
			int num = this.int_0;
			while (i < int_1)
			{
				array[i] = this.byte_0[num];
				i++;
				num++;
			}
			return array;
		}
		public byte[] method_5()
		{
			int int_ = GClass6.smethod_2(this.method_3(2));
			return this.method_3(int_);
		}
		public bool method_6()
		{
			return this.Int32_1 > 0 && this.byte_0[this.int_0++] == 65;
		}
		public int method_7()
		{
			return GClass6.smethod_2(this.method_3(2));
		}
		public uint method_8()
		{
			return (uint)this.method_7();
		}
		public string method_9()
		{
			return this.method_10(Phoenix.smethod_13());
		}
		public string method_10(Encoding encoding_0)
		{
			return encoding_0.GetString(this.method_5()).Replace(Convert.ToChar(1), ' ');
		}
		public int method_11()
		{
			int result = 0;
			string s = this.method_10(Encoding.ASCII);
			int.TryParse(s, out result);
			return result;
		}
		public uint method_12()
		{
			return (uint)this.method_11();
		}
		public bool method_13()
		{
			return this.Int32_1 > 0 && this.byte_0[this.int_0++] == 73;
		}
		public int method_14()
		{
			int result;
			if (this.Int32_1 < 1)
			{
				result = 0;
			}
			else
			{
				byte[] byte_ = this.method_4(6);
				int num = 0;
				int num2 = GClass7.smethod_1(byte_, out num);
				this.int_0 += num;
				result = num2;
			}
			return result;
		}
		public uint method_15()
		{
			return (uint)this.method_14();
		}
	}
}
