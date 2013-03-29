using System;
namespace ns0
{
	internal sealed class Class15
	{
		public uint uint_0;
		public uint uint_1;
		public int int_0;
		public uint uint_2;
		public string string_0;
		public string string_1;
		public string string_2;
		public int int_1;
		public int int_2;
		public int int_3;
		public uint uint_3;
		public int int_4;
		public int int_5;
		public double double_0;
		public int int_6;
		public double double_1;
		public bool bool_0;
		public int[] int_7 = new int[]
		{
			100,
			200,
			400,
			600,
			1000,
			1300,
			1800,
			2400,
			3200,
			4300,
			7200,
			8500,
			10100,
			13300,
			17500,
			23000,
			51900,
			120000,
			240000
		};
		internal Enum3 enum3_0;
		public Class14 Class14_0
		{
			get
			{
				Class14 result;
				if (!this.Boolean_0)
				{
					result = null;
				}
				else
				{
					result = Phoenix.smethod_15().method_9().method_19(this.uint_3);
				}
				return result;
			}
		}
		public bool Boolean_0
		{
			get
			{
				return this.uint_3 > 0u;
			}
		}
		public int Int32_0
		{
			get
			{
				int result;
				for (int i = 0; i < this.int_7.Length; i++)
				{
					if (this.int_1 < this.int_7[i])
					{
						result = i + 1;
						return result;
					}
				}
				result = this.Int32_1;
				return result;
			}
		}
		public int Int32_1
		{
			get
			{
				return 20;
			}
		}
		public int Int32_2
		{
			get
			{
				int result;
				if (this.Int32_0 != this.Int32_1)
				{
					result = this.int_7[this.Int32_0 - 1];
				}
				else
				{
					result = 240000;
				}
				return result;
			}
		}
		public int Int32_3
		{
			get
			{
				return 100;
			}
		}
		public int Int32_4
		{
			get
			{
				return 150;
			}
		}
		public int Int32_5
		{
			get
			{
				return (int)Math.Floor((Phoenix.smethod_6() - this.double_1) / 86400.0);
			}
		}
		public string String_0
		{
			get
			{
				return string.Concat(new object[]
				{
					this.uint_2,
					" ",
					this.string_1,
					" ",
					this.string_2
				});
			}
		}
		public string String_1
		{
			get
			{
				return GClass9.smethod_0((int)this.uint_2) + GClass9.smethod_0(Convert.ToInt32(this.string_1)) + this.string_2;
			}
		}
		public string String_2
		{
			get
			{
				return Phoenix.smethod_15().method_2().method_26(this.uint_1);
			}
		}
		public Class15(uint uint_4, uint uint_5, uint uint_6, string string_3, uint uint_7, string string_4, string string_5, int int_8, int int_9, int int_10, int int_11, double double_2, int int_12, int int_13, double double_3)
		{
			this.uint_0 = uint_4;
			this.uint_1 = uint_5;
			this.uint_3 = uint_6;
			this.string_0 = string_3;
			this.uint_2 = uint_7;
			this.string_1 = string_4;
			this.string_2 = string_5;
			this.int_1 = int_8;
			this.int_2 = int_9;
			this.int_3 = int_10;
			this.int_6 = int_11;
			this.double_1 = double_2;
			this.int_4 = int_12;
			this.int_5 = int_13;
			this.double_0 = double_3;
			this.bool_0 = false;
			this.enum3_0 = Enum3.const_0;
		}
		public void method_0()
		{
			this.int_6++;
			if (this.enum3_0 != Enum3.const_2)
			{
				this.enum3_0 = Enum3.const_1;
			}
			if (this.int_1 <= 51900)
			{
				this.method_1(10, 0);
			}
			GClass5 gClass = new GClass5(606u);
			gClass.method_9(this.int_6);
			gClass.method_11(this.uint_1);
			gClass.method_11(this.uint_0);
			gClass.method_7(this.string_0);
			gClass.method_13(false);
			gClass.method_9(10);
			gClass.method_13(false);
			gClass.method_9(-2);
			gClass.method_13(true);
			gClass.method_7("281");
			this.Class14_0.method_59(gClass, null);
		}
		public void method_1(int int_8, int int_9)
		{
			this.method_2(int_9);
			if (this.Class14_0 != null && this.int_1 + int_8 >= this.Int32_2 && this.Int32_0 != this.Int32_1)
			{
				this.int_2 = this.Int32_3;
				GClass5 gClass = new GClass5(24u);
				gClass.method_9(this.int_0);
				gClass.method_7("*leveled up to level " + (this.Int32_0 + 1) + "*");
				gClass.method_9(0);
				this.Class14_0.method_59(gClass, null);
			}
			this.int_1 += int_8;
			if (this.int_1 < 51900)
			{
				if (this.enum3_0 != Enum3.const_2)
				{
					this.enum3_0 = Enum3.const_1;
				}
				if (this.Class14_0 != null)
				{
					GClass5 gClass2 = new GClass5(609u);
					gClass2.method_11(this.uint_0);
					gClass2.method_9(this.int_0);
					gClass2.method_9(int_8);
					this.Class14_0.method_59(gClass2, null);
				}
			}
		}
		public void method_2(int int_8)
		{
			this.int_2 -= int_8;
			if (this.int_2 > 100)
			{
				this.int_2 = 100;
			}
			else
			{
				if (this.int_2 < 0)
				{
					this.int_2 = 0;
				}
			}
			if (this.enum3_0 != Enum3.const_2)
			{
				this.enum3_0 = Enum3.const_1;
			}
		}
		public void method_3(GClass5 gclass5_0)
		{
			gclass5_0.method_11(this.uint_0);
			gclass5_0.method_7(this.string_0);
			gclass5_0.method_7(this.String_1);
		}
		public GClass5 method_4()
		{
			GClass5 gClass = new GClass5(601u);
			gClass.method_11(this.uint_0);
			gClass.method_7(this.string_0);
			gClass.method_9(this.Int32_0);
			gClass.method_9(this.Int32_1);
			gClass.method_9(this.int_1);
			gClass.method_9(this.Int32_2);
			gClass.method_9(this.int_2);
			gClass.method_9(this.Int32_3);
			gClass.method_9(this.int_3);
			gClass.method_9(this.Int32_4);
			gClass.method_7(this.String_0);
			gClass.method_9(this.int_6);
			gClass.method_11(this.uint_1);
			gClass.method_9(this.Int32_5);
			gClass.method_7(this.String_2);
			return gClass;
		}
	}
}
