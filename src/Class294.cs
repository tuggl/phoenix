using System;
namespace ns0
{
	internal sealed class Class294 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			GClass5 gClass = new GClass5(512u);
			if (class16_0.method_2().list_6.Count > Class13.Int32_4)
			{
				gClass.method_13(true);
				gClass.method_9(Class13.Int32_4);
			}
			else
			{
				gClass.method_13(false);
			}
			class16_0.method_14(gClass);
		}
	}
}
