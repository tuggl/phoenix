using System;
using System.Linq;
namespace ns0
{
	internal sealed class Class252 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_26(class16_0))
			{
				uint num = class18_0.method_15();
				string a = class18_0.method_9().ToUpper();
				string text = Phoenix.smethod_7(class18_0.method_9());
				text = text.Replace("hd-99999-99999", "");
				text += ".";
				Class63 class2 = @class.Hashtable_0[num] as Class63;
				if (class2.string_0.Contains(','))
				{
					class2.string_2 = class2.string_0.Split(new char[]
					{
						','
					})[0];
					class2.string_3 = class2.string_0.Split(new char[]
					{
						','
					})[1];
				}
				if (a == "M")
				{
					class2.string_2 = text;
				}
				else
				{
					class2.string_3 = text;
				}
				class2.string_0 = class2.string_2 + "," + class2.string_3;
				class2.method_5(true, true);
			}
		}
	}
}
