using System;
namespace ns0
{
	internal sealed class Class297 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			Class27 @class = Phoenix.smethod_15().method_9().method_12(num);
			if (@class == null || class16_0.method_2().list_1.Count >= 30 || class16_0.method_2().list_1.Contains(num) || @class.string_2 == "public")
			{
				GClass5 gClass = new GClass5(33u);
				gClass.method_9(-9001);
				class16_0.method_14(gClass);
			}
			else
			{
				GClass5 gClass2 = new GClass5(459u);
				gClass2.method_11(num);
				gClass2.method_13(true);
				class16_0.method_14(gClass2);
				class16_0.method_2().list_1.Add(num);
				using (Class6 class2 = Phoenix.smethod_12().method_0())
				{
					class2.method_1(string.Concat(new object[]
					{
						"INSERT INTO user_favorites (user_id,room_id) VALUES ('",
						class16_0.method_2().uint_0,
						"','",
						num,
						"')"
					}));
				}
			}
		}
	}
}
