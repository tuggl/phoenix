using System;
namespace ns0
{
	public static class GClass7
	{
		public const byte byte_0 = 72;
		public const byte byte_1 = 73;
		public const int int_0 = 6;
		public static byte[] smethod_0(int int_1)
		{
			byte[] array = new byte[6];
			int num = 0;
			int num2 = 1;
			int num3 = 0;
			int num4 = (int_1 >= 0) ? 0 : 4;
			int_1 = Math.Abs(int_1);
			array[num++] = (byte)(64 + (int_1 & 3));
			for (int_1 >>= 2; int_1 != 0; int_1 >>= 6)
			{
				num2++;
				array[num++] = (byte)(64 + (int_1 & 63));
			}
			array[num3] = (byte)((int)array[num3] | num2 << 3 | num4);
			byte[] array2 = new byte[num2];
			for (int i = 0; i < num2; i++)
			{
				array2[i] = array[i];
			}
			return array2;
		}
		public static int smethod_1(byte[] byte_2, out int int_1)
		{
			bool flag = (byte_2[0] & 4) == 4;
			int_1 = (byte_2[0] >> 3 & 7);
			int num = (int)(byte_2[0] & 3);
			int num2 = 0 + 1;
			int num3 = 2;
			for (int i = 1; i < int_1; i++)
			{
				num |= (int)(byte_2[num2] & 63) << num3;
				num3 = 2 + 6 * i;
				num2++;
			}
			if (flag)
			{
				num *= -1;
			}
			return num;
		}
	}
}
