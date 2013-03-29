using System;
namespace ns0
{
	public sealed class GClass6
	{
		public const byte byte_0 = 64;
		public const byte byte_1 = 65;
		public static byte[] smethod_0(int int_0, int int_1)
		{
			byte[] array = new byte[int_1];
			for (int i = 1; i <= int_1; i++)
			{
				int num = (int_1 - i) * 6;
				array[i - 1] = (byte)(64 + (int_0 >> num & 63));
			}
			return array;
		}
		public static byte[] smethod_1(uint uint_0, int int_0)
		{
			return GClass6.smethod_0((int)uint_0, int_0);
		}
		public static int smethod_2(byte[] byte_2)
		{
			int num = 0;
			int num2 = 0;
			for (int i = byte_2.Length - 1; i >= 0; i--)
			{
				int num3 = (int)(byte_2[i] - 64);
				if (num2 > 0)
				{
					num3 *= (int)Math.Pow(64.0, (double)num2);
				}
				num += num3;
				num2++;
			}
			return num;
		}
		public static uint smethod_3(byte[] byte_2)
		{
			return (uint)GClass6.smethod_2(byte_2);
		}
	}
}
