using System;
namespace ns0
{
	internal sealed class Class244 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null)
			{
				Class63 class2 = @class.method_28(class18_0.method_15());
				if (class2 != null && !(class2.method_7().string_2.ToLower() != "postit"))
				{
					string text = class18_0.method_9();
					string text2 = text.Split(new char[]
					{
						' '
					})[0];
					string str = Phoenix.smethod_8(text.Substring(text2.Length + 1), true, true);
					if (@class.method_26(class16_0) || text.StartsWith(class2.string_0))
					{
						string text3 = text2;
						if (text3 != null && (text3 == "FFFF33" || text3 == "FF9CFF" || text3 == "9CCEFF" || text3 == "9CFF9C"))
						{
							class2.string_0 = text2 + " " + str;
							class2.method_5(true, true);
						}
					}
				}
			}
		}
	}
}
