using System;
namespace ns0
{
	internal sealed class Class32
	{
		private int int_0;
		public int int_1;
		public string string_0;
		public string string_1;
		public Enum1 enum1_0;
		public uint uint_0;
		public int int_2;
		public bool bool_0;
		public int Int32_0
		{
			get
			{
				return this.int_0;
			}
		}
		public Class27 Class27_0
		{
			get
			{
				Class27 result;
				if (this.uint_0 == 0u)
				{
					result = new Class27();
				}
				else
				{
					result = Phoenix.smethod_15().method_9().method_12(this.uint_0);
				}
				return result;
			}
		}
		public Class32(int int_3, int int_4, string string_2, string string_3, Enum1 enum1_1, uint uint_1, bool bool_1, int int_5)
		{
			this.int_0 = int_3;
			this.int_1 = int_4;
			this.string_0 = string_2;
			this.string_1 = string_3;
			this.enum1_0 = enum1_1;
			this.uint_0 = uint_1;
			this.bool_0 = bool_1;
			this.int_2 = int_5;
		}
		public void method_0(GClass5 gclass5_0)
		{
			if (!this.bool_0)
			{
				gclass5_0.method_9(this.Int32_0);
				gclass5_0.method_7((this.int_1 == 1) ? this.string_0 : this.Class27_0.string_0);
				gclass5_0.method_7(this.Class27_0.string_1);
				gclass5_0.method_9(this.int_1);
				gclass5_0.method_7(this.string_0);
				gclass5_0.method_7((this.enum1_0 == Enum1.const_1) ? this.string_1 : "");
				gclass5_0.method_9(this.int_2);
				gclass5_0.method_9(this.Class27_0.int_2);
				gclass5_0.method_9(3);
				gclass5_0.method_7((this.enum1_0 == Enum1.const_0) ? this.string_1 : "");
				gclass5_0.method_11(1337u);
				gclass5_0.method_13(true);
				gclass5_0.method_7(this.Class27_0.string_6);
				gclass5_0.method_9(this.Class27_0.int_3);
				gclass5_0.method_11(this.uint_0);
			}
			else
			{
				if (this.bool_0)
				{
					gclass5_0.method_9(this.Int32_0);
					gclass5_0.method_7(this.string_0);
					gclass5_0.method_7("");
					gclass5_0.method_13(true);
					gclass5_0.method_7("");
					gclass5_0.method_7((this.enum1_0 == Enum1.const_1) ? this.string_1 : "");
					gclass5_0.method_13(false);
					gclass5_0.method_13(false);
					gclass5_0.method_9(4);
					gclass5_0.method_13(false);
				}
			}
		}
	}
}
