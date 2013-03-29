using System;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class121 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			List<Class39> list = new List<Class39>();
			foreach (Class39 current in class16_0.method_2().method_23().list_0)
			{
				if (current != null && !(current.method_1().string_1 != "song_disk") && !class16_0.method_2().method_23().list_1.Contains(current.uint_0))
				{
					list.Add(current);
				}
			}
			GClass5 gClass = new GClass5(333u);
			gClass.method_9(list.Count);
			foreach (Class39 current2 in list)
			{
				int int_ = 0;
				if (current2.string_0.Length > 0)
				{
					int_ = int.Parse(current2.string_0);
				}
				Class42 @class = Phoenix.smethod_15().method_8().method_4(int_);
				if (@class == null)
				{
					return;
				}
				gClass.method_11(current2.uint_0);
				gClass.method_9(@class.int_0);
			}
			class16_0.method_14(gClass);
		}
	}
}
