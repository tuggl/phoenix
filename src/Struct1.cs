using System;
namespace ns0
{
	internal struct Struct1
	{
		private int int_0;
		private int int_1;
		private double double_0;
		private byte byte_0;
		private bool bool_0;
		private bool bool_1;
		private bool bool_2;
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
		internal double Double_0
		{
			get
			{
				return this.double_0;
			}
		}
		internal bool Boolean_0
		{
			get
			{
				bool result;
				if (!this.bool_2)
				{
					result = (this.bool_1 || this.byte_0 == 1 || this.byte_0 == 4);
				}
				else
				{
					result = (this.bool_1 || this.byte_0 == 3 || this.byte_0 == 1);
				}
				return result;
			}
		}
		internal bool Boolean_1
		{
			get
			{
				return this.bool_0;
			}
		}
		public Struct1(int int_2, int int_3, int int_4, int int_5, byte byte_1, bool bool_3)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
			this.byte_0 = byte_1;
			this.bool_0 = true;
			this.bool_1 = bool_3;
			this.double_0 = 0.0;
			this.bool_2 = (int_2 == int_4 && int_3 == int_5);
			this.double_0 = Class108.smethod_2(int_2, int_3, int_4, int_5);
		}
	}
}
