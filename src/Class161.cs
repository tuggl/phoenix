using System;
namespace ns0
{
	internal sealed class Class161 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0 != null && class16_0.method_2() != null && class16_0.method_2().uint_2 > 0u)
			{
				Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_2);
				if (@class != null && class16_0.method_2().int_0 > 0)
				{
					Class5 class2 = Class4.smethod_2(class16_0.method_2().int_0);
					if (class2 != null && !@class.list_17.Contains(class2))
					{
						@class.list_17.Add(class2);
						GClass5 gClass = new GClass5(309u);
						gClass.method_9(@class.list_17.Count);
						foreach (Class5 current in @class.list_17)
						{
							gClass.method_9(current.int_0);
							gClass.method_7(current.string_2);
						}
						@class.method_59(gClass, null);
					}
					else
					{
						foreach (Class5 current2 in @class.list_17)
						{
							if (current2 == class2 && current2.string_2 != class2.string_2)
							{
								GClass5 gClass = new GClass5(309u);
								gClass.method_9(@class.list_17.Count);
								foreach (Class5 current in @class.list_17)
								{
									gClass.method_9(current.int_0);
									gClass.method_7(current.string_2);
								}
								@class.method_59(gClass, null);
							}
						}
					}
				}
				if (@class != null && @class.list_17.Count > 0)
				{
					GClass5 gClass = new GClass5(309u);
					gClass.method_9(@class.list_17.Count);
					foreach (Class5 current in @class.list_17)
					{
						gClass.method_9(current.int_0);
						gClass.method_7(current.string_2);
					}
					class16_0.method_14(gClass);
				}
			}
		}
	}
}
