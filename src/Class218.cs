using System;
namespace ns0
{
	internal sealed class Class218 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			Class14 class14_ = class16_0.method_2().Class14_0;
			if (class14_ != null && (!(class14_.string_3 != class16_0.method_2().string_0) || class16_0.method_2().uint_1 == 7u))
			{
				Phoenix.smethod_15().method_9().method_2(num);
				Class27 @class = Phoenix.smethod_15().method_9().method_12(num);
				if (@class != null && (!(@class.string_3.ToLower() != class16_0.method_2().string_0.ToLower()) || class16_0.method_2().uint_1 == 7u))
				{
					Class14 class2 = Phoenix.smethod_15().method_9().method_19(@class.uint_0);
					if (class2 != null)
					{
						for (int i = 0; i < class2.class33_0.Length; i++)
						{
							Class33 class3 = class2.class33_0[i];
							if (class3 != null && !class3.Boolean_4)
							{
								class3.method_16().method_14(new GClass5(18u));
								class3.method_16().method_2().method_11();
							}
						}
						Phoenix.smethod_15().method_9().method_16(class2);
					}
					using (Class6 class4 = Phoenix.smethod_12().method_0())
					{
						class4.method_1("DELETE FROM rooms WHERE id = '" + num + "' LIMIT 1");
						class4.method_1("DELETE FROM user_favorites WHERE room_id = '" + num + "'");
						class4.method_1("UPDATE items SET room_id = '0' WHERE room_id = '" + num + "'");
						class4.method_1("DELETE FROM room_rights WHERE room_id = '" + num + "'");
						class4.method_1("UPDATE users SET home_room = '0' WHERE home_room = '" + num + "'");
						class4.method_1("UPDATE user_pets SET room_id = '0' WHERE room_id = '" + num + "'");
						class16_0.method_2().method_1(class4);
					}
					class16_0.method_2().method_23().method_9(true);
					class16_0.method_2().method_23().method_3(true);
					class16_0.method_14(Phoenix.smethod_15().method_7().method_12(class16_0, -3));
				}
			}
		}
	}
}
