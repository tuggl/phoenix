using System;
namespace ns0
{
	internal sealed class Class291 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			class16_0.method_2().list_1.Remove(num);
			GClass5 gClass = new GClass5(459u);
			gClass.method_11(num);
			gClass.method_13(false);
			class16_0.method_14(gClass);
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_1(string.Concat(new object[]
				{
					"DELETE FROM user_favorites WHERE user_id = '",
					class16_0.method_2().uint_0,
					"' AND room_id = '",
					num,
					"' LIMIT 1"
				}));
			}
		}
	}
}
