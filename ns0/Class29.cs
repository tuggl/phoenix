using System;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class29
	{
		public int int_0;
		public int int_1;
		public Dictionary<int, int> dictionary_0;
		public Class29(int int_2, int int_3, Dictionary<int, int> dictionary_1)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
			this.dictionary_0 = dictionary_1;
		}
		public void method_0(GClass5 gclass5_0)
		{
			gclass5_0.method_9(this.int_0);
			gclass5_0.method_9(this.int_1);
			gclass5_0.method_9(this.dictionary_0.Count);
			foreach (KeyValuePair<int, int> current in this.dictionary_0)
			{
				gclass5_0.method_9(current.Key);
				gclass5_0.method_9(current.Value);
			}
		}
	}
}
