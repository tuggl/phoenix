using System;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class35
	{
		private uint uint_0;
		public uint uint_1;
		public List<string> list_0;
		public string string_0;
		public string string_1;
		public int int_0;
		public Class35(uint uint_2, uint uint_3, string string_2, string string_3, string string_4, int int_1)
		{
			this.uint_0 = uint_2;
			this.uint_1 = uint_3;
			this.list_0 = new List<string>();
			this.string_0 = string_3;
			this.string_1 = string_4;
			this.int_0 = int_1;
			string[] array = string_2.Split(new char[]
			{
				';'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				this.list_0.Add(text.ToLower());
			}
		}
		public bool method_0(string string_2)
		{
			bool result;
			using (GStruct0.smethod_0(this.list_0))
			{
				foreach (string current in this.list_0)
				{
					if (string_2.ToLower().Contains(current.ToLower()))
					{
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}
	}
}
