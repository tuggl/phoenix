using System;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class21
	{
		public string string_0;
		public string string_1;
		public int int_0;
		public List<string> list_0;
		public string string_2;
		public uint uint_0;
		public Class21(uint uint_1, string string_3, string string_4, int int_1, List<string> list_1)
		{
			this.uint_0 = uint_1;
			this.string_0 = string_3;
			this.string_1 = string_4;
			this.int_0 = int_1;
			this.list_0 = list_1;
			this.string_2 = DateTime.Now.ToShortTimeString();
		}
		public GClass5 method_0(Class16 class16_0)
		{
			GClass5 gClass = new GClass5(370u);
			gClass.method_7(string.Concat(class16_0.method_2().uint_0));
			gClass.method_7(class16_0.method_2().string_0);
			gClass.method_7(string.Concat(this.uint_0));
			gClass.method_9(this.int_0);
			gClass.method_7(this.string_0);
			gClass.method_7(this.string_1);
			gClass.method_7(this.string_2);
			gClass.method_9(this.list_0.Count);
			using (GStruct0.smethod_0(this.list_0))
			{
				foreach (string current in this.list_0)
				{
					gClass.method_7(current);
				}
			}
			return gClass;
		}
	}
}
