using System;
namespace ns0
{
	internal struct Struct2
	{
		private double[,] double_0;
		private double[,] double_1;
		private double[,] double_2;
		private int int_0;
		private int int_1;
		public Struct2(int int_2, int int_3, double[,] double_3, double[,] double_4, double[,] double_5)
		{
			this.double_0 = double_3;
			this.double_2 = double_4;
			this.double_1 = double_5;
			this.int_0 = int_2;
			this.int_1 = int_3;
		}
		internal double method_0(int int_2, int int_3)
		{
			double result;
			if (int_2 >= this.int_0 || int_2 < 0)
			{
				result = 0.0;
			}
			else
			{
				if (int_3 >= this.int_1 || int_3 < 0)
				{
					result = 0.0;
				}
				else
				{
					if (this.double_2[int_2, int_3] > this.double_0[int_2, int_3] && this.double_1[int_2, int_3] == 0.0)
					{
						result = this.double_2[int_2, int_3];
					}
					else
					{
						if (this.double_1[int_2, int_3] == 0.0)
						{
							result = this.double_0[int_2, int_3];
						}
						else
						{
							result = this.double_1[int_2, int_3];
						}
					}
				}
			}
			return result;
		}
	}
}
