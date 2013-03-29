using System;
namespace ns0
{
	internal sealed class Class162 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0 != null && class16_0.method_2() != null)
			{
				Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
				if (@class != null)
				{
					Class33 class2 = @class.method_53(class18_0.method_15());
					if (class2 != null && !class2.Boolean_4 && class2.method_16() != null)
					{
						GClass5 gClass = new GClass5(228u);
						gClass.method_11(class2.method_16().method_2().uint_0);
						gClass.method_9(class2.method_16().method_2().method_22().Int32_1);
						using (GStruct0.smethod_0(class2.method_16().method_2().method_22().List_0))
						{
							foreach (Class57 current in class2.method_16().method_2().method_22().List_0)
							{
								if (current.int_0 > 0)
								{
									gClass.method_9(current.int_0);
									gClass.method_7(current.string_0);
								}
							}
						}
						class16_0.method_14(gClass);
					}
				}
			}
		}
	}
}
