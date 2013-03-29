using System;
using System.Data;
namespace ns0
{
	internal sealed class Class59
	{
		internal static Class11 smethod_0(string string_0, Class16 class16_0, Class12 class12_0, Class12 class12_1)
		{
			return Class59.smethod_1(class12_0.DataRow_0, string_0, class16_0, class12_1);
		}
		private static Class11 smethod_1(DataRow dataRow_0, string string_0, Class16 class16_0, Class12 class12_0)
		{
			uint uint_ = (uint)dataRow_0["id"];
			string string_ = (string)dataRow_0["username"];
			string string_2 = (string)dataRow_0["real_name"];
			uint uint_2 = (uint)dataRow_0["rank"];
			string string_3 = (string)dataRow_0["motto"];
			string string_4 = (string)dataRow_0["ip_last"];
			string string_5 = (string)dataRow_0["look"];
			string string_6 = (string)dataRow_0["gender"];
			int int_ = (int)dataRow_0["credits"];
			int int_2 = (int)dataRow_0["activity_points"];
			double double_ = (double)dataRow_0["activity_points_lastupdate"];
			return new Class11(uint_, string_, string_2, string_0, uint_2, string_3, string_5, string_6, int_, int_2, double_, Phoenix.smethod_3(dataRow_0["is_muted"].ToString()), (uint)dataRow_0["home_room"], (int)dataRow_0["newbie_status"], Phoenix.smethod_3(dataRow_0["block_newfriends"].ToString()), Phoenix.smethod_3(dataRow_0["hide_inroom"].ToString()), Phoenix.smethod_3(dataRow_0["hide_online"].ToString()), Phoenix.smethod_3(dataRow_0["vip"].ToString()), (int)dataRow_0["volume"], (int)dataRow_0["vip_points"], Phoenix.smethod_3(dataRow_0["accept_trading"].ToString()), string_4, class16_0, class12_0);
		}
		internal static Class11 smethod_2(string string_0)
		{
			Class12 @class = new Class12(string_0, false);
			return Class59.smethod_1(@class.DataRow_0, "", null, @class);
		}
	}
}
