using System;
using System.Data;
namespace ns0
{
	internal sealed class Class110
	{
		public static uint smethod_0(uint uint_0)
		{
			uint result;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				DataRow dataRow = @class.method_4("SELECT tele_two_id FROM tele_links WHERE tele_one_id = '" + uint_0 + "' LIMIT 1;");
				if (dataRow == null)
				{
					result = 0u;
				}
				else
				{
					result = (uint)dataRow[0];
				}
			}
			return result;
		}
		public static uint smethod_1(uint uint_0)
		{
			uint result;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				DataRow dataRow = @class.method_4("SELECT room_id FROM items WHERE id = '" + uint_0 + "' LIMIT 1;");
				if (dataRow == null)
				{
					result = 0u;
				}
				else
				{
					result = (uint)dataRow[0];
				}
			}
			return result;
		}
		public static bool smethod_2(uint uint_0)
		{
			uint num = Class110.smethod_0(uint_0);
			bool result;
			if (num == 0u)
			{
				result = false;
			}
			else
			{
				uint num2 = Class110.smethod_1(num);
				result = (num2 != 0u);
			}
			return result;
		}
	}
}
