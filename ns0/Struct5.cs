using System;
using System.Data;
namespace ns0
{
	internal struct Struct5
	{
		private string string_0;
		private int int_0;
		private int int_1;
		private string string_1;
		private bool bool_0;
		private int int_2;
		internal string String_0
		{
			get
			{
				return this.string_0;
			}
		}
		internal int Int32_0
		{
			get
			{
				return this.int_0;
			}
		}
		internal int Int32_1
		{
			get
			{
				return this.int_1;
			}
		}
		internal string String_1
		{
			get
			{
				return this.string_1;
			}
		}
		internal bool Boolean_0
		{
			get
			{
				return this.bool_0;
			}
		}
		internal int Int32_2
		{
			get
			{
				return this.int_2;
			}
		}
		public Struct5(DataRow dataRow_0)
		{
			this.string_0 = (string)dataRow_0["model"];
			this.int_0 = (int)dataRow_0["x"];
			this.int_1 = (int)dataRow_0["y"];
			this.string_1 = (string)dataRow_0["name"];
			this.bool_0 = ((int)dataRow_0["seat"] == 1);
			this.int_2 = (int)dataRow_0["rotation"];
		}
	}
}
