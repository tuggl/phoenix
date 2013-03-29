using System;
namespace ns0
{
	internal sealed class Class52
	{
		private string string_0;
		private int int_0;
		private int int_1;
		public string String_0
		{
			get
			{
				return this.string_0;
			}
		}
		public int Int32_0
		{
			get
			{
				return this.int_1;
			}
		}
		public Class52(string string_1, int int_2, int int_3)
		{
			this.string_0 = string_1;
			this.int_0 = int_2;
			this.int_1 = int_3;
		}
		public bool method_0()
		{
			return (double)this.int_1 > Phoenix.smethod_6();
		}
		public void method_1(int int_2)
		{
			if (this.int_1 + int_2 < 2147483647)
			{
				this.int_1 += int_2;
			}
		}
	}
}
