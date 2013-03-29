using System;
namespace ns0
{
	public sealed class GClass2
	{
		private readonly string string_0;
		private readonly uint uint_0;
		private readonly uint uint_1;
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
		public uint UInt32_1
		{
			get
			{
				return this.uint_1;
			}
		}
		public GClass2(string string_1, uint uint_2, uint uint_3)
		{
			if (string_1 == null || string_1.Length == 0)
			{
				throw new ArgumentException(string_1);
			}
			this.string_0 = string_1;
			this.uint_0 = uint_2;
			this.uint_1 = uint_3;
		}
	}
}
