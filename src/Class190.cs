using System;
namespace ns0
{
	internal sealed class Class190 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0.method_2().Boolean_0)
			{
				int num = class18_0.method_14();
				if (num == 5)
				{
					for (int i = 0; i < num; i++)
					{
						Class39 @class = class16_0.method_2().method_23().method_10(class18_0.method_15());
						if (@class == null || !@class.method_1().bool_3)
						{
							return;
						}
						class16_0.method_2().method_23().method_12(@class.uint_0, 0u, false);
					}
					uint num2 = Phoenix.smethod_15().method_6().method_14();
					Class47 class2 = Phoenix.smethod_15().method_6().method_15();
					using (Class6 class3 = Phoenix.smethod_12().method_0())
					{
						class3.method_1(string.Concat(new object[]
						{
							"INSERT INTO items (id,user_id,base_item,extra_data,wall_pos) VALUES ('",
							num2,
							"','",
							class16_0.method_2().uint_0,
							"','1478','",
							DateTime.Now.ToLongDateString(),
							"', '')"
						}));
						class3.method_1(string.Concat(new object[]
						{
							"INSERT INTO user_presents (item_id,base_id,amount,extra_data) VALUES ('",
							num2,
							"','",
							class2.uint_2,
							"','1','')"
						}));
					}
					class16_0.method_2().method_23().method_9(true);
					GClass5 gClass = new GClass5(508u);
					gClass.method_13(true);
					gClass.method_11(num2);
					class16_0.method_14(gClass);
				}
			}
		}
	}
}
