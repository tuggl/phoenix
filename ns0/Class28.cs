using System;
using System.Globalization;
using System.Text;
namespace ns0
{
	internal sealed class Class28
	{
		public string string_0;
		public int int_0;
		public int int_1;
		public double double_0;
		public int int_2;
		public string string_1;
		public GEnum0[,] genum0_0;
		public double[,] double_1;
		public int[,] int_3;
		public int int_4;
		public int int_5;
		public string string_2;
		public bool bool_0;
		public Class28(string string_3, int int_6, int int_7, double double_2, int int_8, string string_4, string string_5, bool bool_1)
		{
			this.string_0 = string_3;
			this.int_0 = int_6;
			this.int_1 = int_7;
			this.double_0 = double_2;
			this.int_2 = int_8;
			this.string_1 = string_4.ToLower();
			this.string_2 = string_5;
			string[] array = string_4.Split(new char[]
			{
				Convert.ToChar(13)
			});
			this.int_4 = array[0].Length;
			this.int_5 = array.Length;
			this.bool_0 = bool_1;
			this.genum0_0 = new GEnum0[this.int_4, this.int_5];
			this.double_1 = new double[this.int_4, this.int_5];
			this.int_3 = new int[this.int_4, this.int_5];
			for (int i = 0; i < this.int_5; i++)
			{
				if (i > 0)
				{
					array[i] = array[i].Substring(1);
				}
				for (int j = 0; j < this.int_4; j++)
				{
					string text = array[i].Substring(j, 1).Trim().ToLower();
					if (text == "x")
					{
						this.genum0_0[j, i] = GEnum0.const_1;
					}
					else
					{
						if (this.method_0(text, NumberStyles.Integer))
						{
							this.genum0_0[j, i] = GEnum0.const_0;
							this.double_1[j, i] = double.Parse(text);
						}
					}
				}
			}
			this.double_1[int_6, int_7] = double_2;
			int num = 0;
			int num2 = 0;
			if (string_5 != "")
			{
				num2 = GClass9.smethod_1(string_5);
			}
			num += GClass9.smethod_0(num2).Length;
			for (int k = 0; k < num2; k++)
			{
				string_5.Substring(num);
				int num3 = GClass9.smethod_1(string_5.Substring(num));
				num += GClass9.smethod_0(num3).Length;
				string_5.Substring(num, 1);
				num++;
				int.Parse(string_5.Substring(num).Split(new char[]
				{
					Convert.ToChar(2)
				})[0]);
				num += string_5.Substring(num).Split(new char[]
				{
					Convert.ToChar(2)
				})[0].Length;
				num++;
				string text2 = string_5.Substring(num).Split(new char[]
				{
					Convert.ToChar(2)
				})[0];
				num += string_5.Substring(num).Split(new char[]
				{
					Convert.ToChar(2)
				})[0].Length;
				num++;
				int j = GClass9.smethod_1(string_5.Substring(num));
				num += GClass9.smethod_0(j).Length;
				int i = GClass9.smethod_1(string_5.Substring(num));
				num += GClass9.smethod_0(i).Length;
				int num4 = GClass9.smethod_1(string_5.Substring(num));
				num += GClass9.smethod_0(num4).Length;
				int num5 = GClass9.smethod_1(string_5.Substring(num));
				num += GClass9.smethod_0(num5).Length;
				this.genum0_0[j, i] = GEnum0.const_1;
				if (text2.Contains("bench") || text2.Contains("chair") || text2.Contains("stool") || text2.Contains("seat") || text2.Contains("sofa"))
				{
					this.genum0_0[j, i] = GEnum0.const_2;
					this.int_3[j, i] = num5;
				}
			}
		}
		public bool method_0(string string_3, NumberStyles numberStyles_0)
		{
			double num;
			return double.TryParse(string_3, numberStyles_0, CultureInfo.CurrentCulture, out num);
		}
		public GClass5 method_1()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string[] array = this.string_1.Split("\r\n".ToCharArray());
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (!(text == ""))
				{
					stringBuilder.Append(text);
					stringBuilder.Append(Convert.ToChar(13));
				}
			}
			GClass5 gClass = new GClass5(31u);
			gClass.method_7(stringBuilder.ToString());
			return gClass;
		}
		public GClass5 method_2()
		{
			GClass5 gClass = new GClass5(470u);
			string[] array = this.string_1.Split(new char[]
			{
				Convert.ToChar(13)
			});
			for (int i = 0; i < this.int_5; i++)
			{
				if (i > 0)
				{
					array[i] = array[i].Substring(1);
				}
				for (int j = 0; j < this.int_4; j++)
				{
					string text = array[i].Substring(j, 1).Trim().ToLower();
					if (this.int_0 == j && this.int_1 == i)
					{
						text = string.Concat((int)this.double_0);
					}
					gClass.method_6(text);
				}
				gClass.method_6(string.Concat(Convert.ToChar(13)));
			}
			return gClass;
		}
	}
}
