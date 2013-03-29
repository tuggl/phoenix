using System;
namespace ns0
{
	internal sealed class Class96 : Class69
	{
		public override void vmethod_0(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_1(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_2(Class16 class16_0, Class63 class63_0, int int_0, bool bool_0)
		{
			if (class16_0 != null)
			{
				Class33 @class = class16_0.method_2().Class14_0.method_53(class16_0.method_2().uint_0);
				Class14 class2 = class63_0.method_8();
				if (class63_0.method_8().method_99(class63_0.Int32_0, class63_0.Int32_1, @class.int_3, @class.int_4))
				{
					class63_0.method_8().method_10(@class, class63_0);
					int num = class63_0.Int32_0;
					int num2 = class63_0.Int32_1;
					class63_0.string_0 = "11";
					if (@class.int_8 == 4)
					{
						num2--;
					}
					else
					{
						if (@class.int_8 == 0)
						{
							num2++;
						}
						else
						{
							if (@class.int_8 == 6)
							{
								num++;
							}
							else
							{
								if (@class.int_8 == 2)
								{
									num--;
								}
								else
								{
									if (@class.int_8 == 3)
									{
										num--;
										num2--;
									}
									else
									{
										if (@class.int_8 == 1)
										{
											num--;
											num2++;
										}
										else
										{
											if (@class.int_8 == 7)
											{
												num++;
												num2++;
											}
											else
											{
												if (@class.int_8 == 5)
												{
													num++;
													num2--;
												}
											}
										}
									}
								}
							}
						}
					}
					@class.method_5(class63_0.Int32_0, class63_0.Int32_1);
					class2.method_79(null, class63_0, num, num2, 0, false, true, true);
				}
			}
		}
	}
}
