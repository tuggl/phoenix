using System;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class293 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true) && @class.class21_0 == null && @class.int_1 == 0)
			{
				int int_ = class18_0.method_14();
				string text = Phoenix.smethod_7(class18_0.method_9());
				string string_ = Phoenix.smethod_7(class18_0.method_9());
				int num = class18_0.method_14();
				if (text.Length >= 1)
				{
					@class.class21_0 = new Class21(@class.UInt32_0, text, string_, int_, null);
					@class.class21_0.list_0 = new List<string>();
					for (int i = 0; i < num; i++)
					{
						@class.class21_0.list_0.Add(Phoenix.smethod_7(class18_0.method_9()));
					}
					@class.method_59(@class.class21_0.method_0(class16_0), null);
				}
			}
		}
	}
}
