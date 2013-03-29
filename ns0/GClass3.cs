using System;
namespace ns0
{
	public sealed class GClass3
	{
		private readonly string string_0;
		private readonly uint uint_0;
		private readonly string string_1;
		private readonly string string_2;
		public string String_0
		{
			get
			{
				return this.string_0;
			}
		}
		public uint UInt32_0
		{
			get
			{
				return this.uint_0;
			}
		}
		public string String_1
		{
			get
			{
				return this.string_1;
			}
		}
		public string String_2
		{
			get
			{
				return this.string_2;
			}
		}
		public GClass3(string string_3, uint uint_1, string string_4, string string_5)
		{
			if (string_3 == null || string_3.Length == 0)
			{
				throw new ArgumentException("sHost");
			}
			if (string_4 == null || string_4.Length == 0)
			{
				throw new ArgumentException("sUser");
			}
			this.string_0 = string_3;
			this.uint_0 = uint_1;
			this.string_1 = string_4;
			this.string_2 = ((string_5 != null) ? string_5 : "");
		}
		public override string ToString()
		{
			return this.string_1 + "@" + this.string_0;
		}
	}
}
