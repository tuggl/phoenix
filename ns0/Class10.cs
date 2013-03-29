using System;
namespace ns0
{
	internal sealed class Class10
	{
		private readonly uint uint_0;
		public string string_0;
		public string string_1;
		public int int_0;
		public int int_1;
		public int int_2;
		public Class10(uint uint_1, string string_2, string string_3, int int_3, int int_4, int int_5)
		{
			this.uint_0 = uint_1;
			this.string_0 = string_2;
			this.string_1 = string_3;
			this.int_0 = int_3;
			this.int_1 = int_4;
			this.int_2 = int_5;
		}
		public uint method_0()
		{
			return this.uint_0;
		}
		public void method_1(GClass5 gclass5_0, Class16 class16_0, bool bool_0)
		{
			gclass5_0.method_7(this.string_0);
			if (class16_0.method_2().list_5.Contains(this.uint_0))
			{
				gclass5_0.method_9(this.int_1);
			}
			else
			{
				gclass5_0.method_9(this.int_1 - 1);
			}
			gclass5_0.method_9(Phoenix.smethod_15().method_16().method_2(this.string_0));
			if (Phoenix.smethod_15().method_16().method_2(this.string_0) == this.int_1 && class16_0.method_2().list_5.Contains(this.uint_0) && !bool_0)
			{
				gclass5_0.method_9(0);
				gclass5_0.method_9(0);
				gclass5_0.method_9(0);
				gclass5_0.method_7("");
				gclass5_0.method_7("");
				gclass5_0.method_9(0);
				gclass5_0.method_7("");
				gclass5_0.method_9(0);
				gclass5_0.method_9(0);
				gclass5_0.method_9(0);
			}
			else
			{
				gclass5_0.method_13(false);
				gclass5_0.method_11(this.uint_0);
				gclass5_0.method_13(class16_0.method_2().uint_6 == this.uint_0);
				gclass5_0.method_7(this.string_1.StartsWith("FIND") ? "FIND_STUFF" : this.string_1);
				gclass5_0.method_7("_2");
				gclass5_0.method_9(this.int_2);
				gclass5_0.method_7(this.string_1.Replace("_", ""));
				gclass5_0.method_9(class16_0.method_2().int_5);
				gclass5_0.method_9(this.int_0);
				gclass5_0.method_9(0);
			}
		}
	}
}
