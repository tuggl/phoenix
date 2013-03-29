using System;
namespace ns0
{
	internal sealed class Class108
	{
		internal static Struct1 smethod_0(int int_0, int int_1, int int_2, int int_3, byte[,] byte_0, double[,] double_0, double[,] double_1, double[,] double_2, int int_4, int int_5, bool bool_0, bool bool_1)
		{
			Struct4 struct4_ = new Struct4(int_4, int_5, byte_0);
			Struct1 @struct = new Struct1(int_2, int_3, int_2, int_3, struct4_.method_0(int_2, int_3), bool_0);
			Struct1 result;
			if (int_0 == int_2 && int_1 == int_3)
			{
				result = @struct;
			}
			else
			{
				Struct3 struct3_ = new Struct3(int_0, int_1, @struct, struct4_, bool_0, bool_1);
				result = Class108.smethod_1(struct3_, new Struct2(int_4, int_5, double_0, double_1, double_2), bool_1);
			}
			return result;
		}
		private static Struct1 smethod_1(Struct3 struct3_0, Struct2 struct2_0, bool bool_0)
		{
			double num = struct3_0.Struct1_1.Double_0;
			Struct1 result = struct3_0.Struct1_1;
			double num2 = struct2_0.method_0(struct3_0.Struct1_1.Int32_0, struct3_0.Struct1_1.Int32_1);
			for (int i = 0; i < 8; i++)
			{
				Struct1 @struct = struct3_0.method_1(i);
				if (@struct.Boolean_1 && @struct.Boolean_0 && struct2_0.method_0(@struct.Int32_0, @struct.Int32_1) - num2 < 2.0)
				{
					double double_ = @struct.Double_0;
					if (num > double_)
					{
						num = double_;
						result = @struct;
					}
				}
			}
			return result;
		}
		internal static double smethod_2(int int_0, int int_1, int int_2, int int_3)
		{
			return Math.Sqrt(Math.Pow((double)(int_0 - int_2), 2.0) + Math.Pow((double)(int_1 - int_3), 2.0));
		}
	}
}
