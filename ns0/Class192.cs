using System;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class192 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			GClass5 gClass = new GClass5(506u);
			gClass.method_9(5);
			for (uint num = 5u; num >= 1u; num -= 1u)
			{
				gClass.method_11(num);
				if (num <= 1u)
				{
					gClass.method_9(0);
				}
				else
				{
					if (num == 2u)
					{
						gClass.method_9(4);
					}
					else
					{
						if (num == 3u)
						{
							gClass.method_9(40);
						}
						else
						{
							if (num == 4u)
							{
								gClass.method_9(200);
							}
							else
							{
								if (num >= 5u)
								{
									gClass.method_9(2000);
								}
							}
						}
					}
				}
				List<Class47> list = Phoenix.smethod_15().method_6().method_16(num);
				gClass.method_9(list.Count);
				foreach (Class47 current in list)
				{
					gClass.method_7(current.method_0().char_0.ToString().ToLower());
					gClass.method_11(current.uint_1);
				}
			}
			class16_0.method_14(gClass);
		}
	}
}
