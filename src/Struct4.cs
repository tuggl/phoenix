using System;
namespace ns0
{
	internal struct Struct4
	{
		private byte[,] byte_0;
		private int int_0;
		private int int_1;
		public Struct4(int int_2, int int_3, byte[,] byte_1)
		{
			this.byte_0 = byte_1;
			this.int_0 = int_2;
			this.int_1 = int_3;
		}
		internal byte method_0(int int_2, int int_3)
		{
			byte result;
			if (int_2 >= this.int_0 || int_2 < 0)
			{
				result = 0;
			}
			else
			{
				if (int_3 >= this.int_1 || int_3 < 0)
				{
					result = 0;
				}
				else
				{
					result = this.byte_0[int_2, int_3];
				}
			}
			return result;
		}
	}
}
