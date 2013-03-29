using System;
namespace ns0
{
	internal sealed class Class235 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			try
			{
				Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
				if (@class != null)
				{
					Class63 class2 = @class.method_28(class18_0.method_15());
					if (class2 != null)
					{
						bool bool_ = false;
						if (@class.method_26(class16_0))
						{
							bool_ = true;
						}
						class2.Class69_0.vmethod_2(class16_0, class2, -1, bool_);
					}
				}
			}
			catch
			{
			}
		}
	}
}
