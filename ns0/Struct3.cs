using System;
namespace ns0
{
	internal struct Struct3
	{
		private int int_0;
		private int int_1;
		private Struct1[] struct1_0;
		private Struct1 struct1_1;
		private Struct1 struct1_2;
		internal int Int32_0
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}
		internal int Int32_1
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}
		internal Struct1 Struct1_0
		{
			get
			{
				return this.struct1_1;
			}
		}
		internal Struct1 Struct1_1
		{
			get
			{
				return this.struct1_2;
			}
		}
		public Struct3(int int_2, int int_3, Struct1 struct1_3, Struct4 struct4_0, bool bool_0, bool bool_1)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
			this.struct1_1 = struct1_3;
			this.struct1_2 = new Struct1(int_2, int_3, struct1_3.Int32_0, struct1_3.Int32_1, struct4_0.method_0(int_2, int_3), bool_0);
			this.struct1_0 = new Struct1[8];
			if (bool_1)
			{
				this.struct1_0[1] = new Struct1(int_2 - 1, int_3 - 1, struct1_3.Int32_0, struct1_3.Int32_1, struct4_0.method_0(int_2 - 1, int_3 - 1), bool_0);
				this.struct1_0[3] = new Struct1(int_2 - 1, int_3 + 1, struct1_3.Int32_0, struct1_3.Int32_1, struct4_0.method_0(int_2 - 1, int_3 + 1), bool_0);
				this.struct1_0[5] = new Struct1(int_2 + 1, int_3 + 1, struct1_3.Int32_0, struct1_3.Int32_1, struct4_0.method_0(int_2 + 1, int_3 + 1), bool_0);
				this.struct1_0[7] = new Struct1(int_2 + 1, int_3 - 1, struct1_3.Int32_0, struct1_3.Int32_1, struct4_0.method_0(int_2 + 1, int_3 - 1), bool_0);
			}
			this.struct1_0[0] = new Struct1(int_2, int_3 - 1, struct1_3.Int32_0, struct1_3.Int32_1, struct4_0.method_0(int_2, int_3 - 1), bool_0);
			this.struct1_0[2] = new Struct1(int_2 - 1, int_3, struct1_3.Int32_0, struct1_3.Int32_1, struct4_0.method_0(int_2 - 1, int_3), bool_0);
			this.struct1_0[4] = new Struct1(int_2, int_3 + 1, struct1_3.Int32_0, struct1_3.Int32_1, struct4_0.method_0(int_2, int_3 + 1), bool_0);
			this.struct1_0[6] = new Struct1(int_2 + 1, int_3, struct1_3.Int32_0, struct1_3.Int32_1, struct4_0.method_0(int_2 + 1, int_3), bool_0);
		}
		private byte method_0(int int_2, int int_3, byte[,] byte_0, int int_4, int int_5)
		{
			byte result;
			if (int_2 >= int_4)
			{
				result = 0;
			}
			else
			{
				if (int_3 >= int_5)
				{
					result = 0;
				}
				else
				{
					result = byte_0[int_4, int_5];
				}
			}
			return result;
		}
		internal Struct1 method_1(int int_2)
		{
			return this.struct1_0[int_2];
		}
	}
}
