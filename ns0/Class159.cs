using System;
using System.Data;
namespace ns0
{
	internal sealed class Class159 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			DataTable dataTable_ = class16_0.method_2().dataTable_0;
			if (dataTable_ != null)
			{
				GClass5 gClass = new GClass5(915u);
				gClass.method_9(dataTable_.Rows.Count);
				foreach (DataRow dataRow in dataTable_.Rows)
				{
					Class5 @class = Class4.smethod_2((int)dataRow["groupid"]);
					gClass.method_9(@class.int_0);
					gClass.method_7(@class.string_0);
					gClass.method_7(@class.string_2);
					if (class16_0.method_2().int_0 == @class.int_0)
					{
						gClass.method_13(true);
					}
					else
					{
						gClass.method_13(false);
					}
				}
				class16_0.method_14(gClass);
			}
		}
	}
}
