using System;
namespace ns0
{
	internal sealed class Class115
	{
		public static byte[] smethod_0(byte[] byte_0, int int_0, int int_1)
		{
			int num = int_0 + int_1;
			if (num > byte_0.Length)
			{
				num = byte_0.Length;
			}
			if (int_1 > byte_0.Length)
			{
				int_1 = byte_0.Length;
			}
			if (int_1 < 0)
			{
				int_1 = 0;
			}
			byte[] array = new byte[int_1];
			for (int i = 0; i < int_1; i++)
			{
				array[i] = byte_0[int_0++];
			}
			return array;
		}
	}
}
