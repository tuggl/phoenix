using System;
namespace ns0
{
	internal sealed class Class228 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && !@class.Boolean_3 && (@class.bool_0 || @class.method_27(class16_0, true)))
			{
				uint uint_ = class18_0.method_15();
				Class33 class2 = @class.method_48(uint_);
				if (class2 != null && class2.class15_0 != null && class2.class15_0.uint_1 == class16_0.method_2().uint_0)
				{
					using (Class6 class3 = Phoenix.smethod_12().method_0())
					{
						if (class2.class15_0.enum3_0 == Enum3.const_2)
						{
							class3.method_0("petname" + class2.class15_0.uint_0, class2.class15_0.string_0);
							class3.method_0("petcolor" + class2.class15_0.uint_0, class2.class15_0.string_2);
							class3.method_0("petrace" + class2.class15_0.uint_0, class2.class15_0.string_1);
							class3.method_1(string.Concat(new object[]
							{
								"INSERT INTO `user_pets` VALUES ('",
								class2.class15_0.uint_0,
								"', '",
								class2.class15_0.uint_1,
								"', '0', @petname",
								class2.class15_0.uint_0,
								", @petrace",
								class2.class15_0.uint_0,
								", @petcolor",
								class2.class15_0.uint_0,
								", '",
								class2.class15_0.uint_2,
								"', '",
								class2.class15_0.int_1,
								"', '",
								class2.class15_0.int_2,
								"', '",
								class2.class15_0.int_3,
								"', '",
								class2.class15_0.int_6,
								"', '",
								class2.class15_0.double_1,
								"', '",
								class2.class15_0.int_4,
								"', '",
								class2.class15_0.int_5,
								"', '",
								class2.class15_0.double_0,
								"');"
							}));
						}
						else
						{
							class3.method_1(string.Concat(new object[]
							{
								"UPDATE user_pets SET room_id = '0', expirience = '",
								class2.class15_0.int_1,
								"', energy = '",
								class2.class15_0.int_2,
								"', nutrition = '",
								class2.class15_0.int_3,
								"', respect = '",
								class2.class15_0.int_6,
								"' WHERE id = '",
								class2.class15_0.uint_0,
								"' LIMIT 1; "
							}));
						}
						class2.class15_0.enum3_0 = Enum3.const_0;
					}
					class16_0.method_2().method_23().method_7(class2.class15_0);
					@class.method_6(class2.int_0, false);
					class2.uint_1 = 0u;
				}
			}
		}
	}
}
