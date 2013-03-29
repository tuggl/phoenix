using System;
namespace ns0
{
	internal sealed class Class156 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && class16_0.method_2().int_21 > 0)
			{
				Class33 class2 = @class.method_53(class18_0.method_15());
				if (class2 != null && class2.method_16().method_2().uint_0 != class16_0.method_2().uint_0 && !class2.Boolean_4)
				{
					class16_0.method_2().int_21--;
					class16_0.method_2().int_18++;
					class2.method_16().method_2().int_17++;
					using (Class6 class3 = Phoenix.smethod_12().method_0())
					{
						class3.method_1("UPDATE user_stats SET Respect = respect + 1 WHERE id = '" + class2.method_16().method_2().uint_0 + "' LIMIT 1");
						class3.method_1("UPDATE user_stats SET RespectGiven = RespectGiven + 1 WHERE id = '" + class16_0.method_2().uint_0 + "' LIMIT 1");
						class3.method_1("UPDATE user_stats SET dailyrespectpoints = dailyrespectpoints - 1 WHERE id = '" + class16_0.method_2().uint_0 + "' LIMIT 1");
					}
					GClass5 gClass = new GClass5(440u);
					gClass.method_11(class2.method_16().method_2().uint_0);
					gClass.method_9(class2.method_16().method_2().int_17);
					@class.method_59(gClass, null);
					if (class16_0.method_2().int_18 == 100)
					{
						Phoenix.smethod_15().method_12().method_3(class16_0, 8u, 1);
					}
					int int_ = class2.method_16().method_2().int_17;
					if (int_ <= 166)
					{
						if (int_ <= 6)
						{
							if (int_ != 1)
							{
								if (int_ == 6)
								{
									Phoenix.smethod_15().method_12().method_3(class2.method_16(), 14u, 2);
								}
							}
							else
							{
								Phoenix.smethod_15().method_12().method_3(class2.method_16(), 14u, 1);
							}
						}
						else
						{
							if (int_ != 16)
							{
								if (int_ != 66)
								{
									if (int_ == 166)
									{
										Phoenix.smethod_15().method_12().method_3(class2.method_16(), 14u, 5);
									}
								}
								else
								{
									Phoenix.smethod_15().method_12().method_3(class2.method_16(), 14u, 4);
								}
							}
							else
							{
								Phoenix.smethod_15().method_12().method_3(class2.method_16(), 14u, 3);
							}
						}
					}
					else
					{
						if (int_ <= 566)
						{
							if (int_ != 366)
							{
								if (int_ == 566)
								{
									Phoenix.smethod_15().method_12().method_3(class2.method_16(), 14u, 7);
								}
							}
							else
							{
								Phoenix.smethod_15().method_12().method_3(class2.method_16(), 14u, 6);
							}
						}
						else
						{
							if (int_ != 766)
							{
								if (int_ != 966)
								{
									if (int_ == 1116)
									{
										Phoenix.smethod_15().method_12().method_3(class2.method_16(), 14u, 10);
									}
								}
								else
								{
									Phoenix.smethod_15().method_12().method_3(class2.method_16(), 14u, 9);
								}
							}
							else
							{
								Phoenix.smethod_15().method_12().method_3(class2.method_16(), 14u, 8);
							}
						}
					}
					if (class16_0.method_2().uint_6 == 5u)
					{
						Phoenix.smethod_15().method_16().method_1(5u, class16_0);
					}
				}
			}
		}
	}
}
