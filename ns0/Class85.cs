using System;
namespace ns0
{
	internal sealed class Class85 : Class69
	{
		public override void vmethod_0(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_1(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_2(Class16 class16_0, Class63 class63_0, int int_0, bool bool_0)
		{
			if (bool_0)
			{
				int num = 0;
				if (class63_0.string_0.Length > 0)
				{
					num = int.Parse(class63_0.string_0);
				}
				if (int_0 == 0)
				{
					if (num <= -1)
					{
						num = 0;
					}
					else
					{
						if (num >= 0)
						{
							num = -1;
						}
					}
				}
				else
				{
					if (int_0 >= 1)
					{
						if (int_0 == 1)
						{
							if (!class63_0.bool_0)
							{
								class63_0.bool_0 = true;
								class63_0.method_3(1);
								if (class16_0 != null)
								{
									Class33 class33_ = class16_0.method_2().Class14_0.method_53(class16_0.method_2().uint_0);
									class63_0.method_8().method_14(class33_);
								}
							}
							else
							{
								class63_0.bool_0 = false;
							}
						}
						else
						{
							if (int_0 == 2)
							{
								num += 60;
								if (num >= 600)
								{
									num = 0;
								}
							}
						}
					}
				}
				class63_0.string_0 = num.ToString();
				class63_0.method_5(true, true);
			}
		}
	}
}
