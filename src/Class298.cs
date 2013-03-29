using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns0
{
	internal sealed class Class298 : Interface0
	{
		[CompilerGenerated]
		private static Func<Class14, int> func_0;
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Dictionary<Class14, int> dictionary = Phoenix.smethod_15().method_9().method_21();
			Class14 @class = null;
			IEnumerable<Class14> arg_35_0 = dictionary.Keys;
			if (Class298.func_0 == null)
			{
				Class298.func_0 = new Func<Class14, int>(Class298.smethod_0);
			}
			IOrderedEnumerable<Class14> orderedEnumerable = arg_35_0.OrderByDescending(Class298.func_0);
			int num = 0;
			foreach (Class14 current in orderedEnumerable)
			{
				num++;
				string a = Phoenix.smethod_5(1, 5).ToString();
				if (a == "2")
				{
					goto IL_83;
				}
				if (num == orderedEnumerable.Count<Class14>())
				{
					goto IL_83;
				}
				bool arg_A2_0 = true;
				IL_A2:
				if (arg_A2_0)
				{
					continue;
				}
				@class = current;
				break;
				IL_83:
				arg_A2_0 = (class16_0.method_2().Class14_0 == null || class16_0.method_2().Class14_0 == current);
				goto IL_A2;
			}
			if (@class == null)
			{
				GClass5 gClass = new GClass5(831u);
				gClass.method_13(false);
				class16_0.method_14(gClass);
			}
			else
			{
				GClass5 gClass2 = new GClass5(286u);
				gClass2.method_13(@class.Boolean_3);
				gClass2.method_11(@class.UInt32_0);
				class16_0.method_14(gClass2);
				GClass5 gClass3 = new GClass5(831u);
				gClass3.method_13(true);
				class16_0.method_14(gClass3);
			}
		}
		[CompilerGenerated]
		private static int smethod_0(Class14 class14_0)
		{
			return class14_0.Int32_0;
		}
	}
}
