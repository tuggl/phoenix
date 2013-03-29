using System;
using System.Text;
namespace ns0
{
	public static class GClass9
	{
		public static string smethod_0(int int_0)
		{
			byte[] array = new byte[6];
			int num = 0;
			int num2 = 0;
			int num3 = 1;
			int num4 = (int_0 >= 0) ? 0 : 4;
			int_0 = Math.Abs(int_0);
			array[num++] = (byte)(64 + (int_0 & 3));
			for (int_0 >>= 2; int_0 != 0; int_0 >>= 6)
			{
				num3++;
				array[num++] = (byte)(64 + (int_0 & 63));
			}
			array[num2] = (byte)((int)array[num2] | num3 << 3 | num4);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			string @string = aSCIIEncoding.GetString(array);
			return @string.Replace("\0", "");
		}
		public static int smethod_1(string string_0)
		{
			return GClass9.smethod_2(string_0.ToCharArray());
		}
		public static int smethod_2(char[] char_0)
		{
			int result;
			try
			{
				bool flag = (char_0[0] & '\u0004') == '\u0004';
				int num = (int)(char_0[0] >> 3 & '\a');
				int num2 = (int)(char_0[0] & '\u0003');
				int num3 = 0 + 1;
				int num4 = 2;
				for (int i = 1; i < num; i++)
				{
					num2 |= (int)((int)(char_0[num3] & '?') << (num4 & 31));
					num4 = 2 + 6 * i;
					num3++;
				}
				if (flag)
				{
					num2 *= -1;
				}
				result = num2;
			}
			catch
			{
				result = 0;
			}
			return result;
		}
	}
}
