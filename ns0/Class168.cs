using System;
using System.Data;
namespace ns0
{
	internal sealed class Class168 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			GClass5 gClass = new GClass5(267u);
			gClass.method_13(class16_0.method_2().method_20().method_2("habbo_club"));
			if (class16_0.method_2().method_20().method_2("habbo_club"))
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_0("userid", class16_0.method_2().uint_0);
					DataTable dataTable = @class.method_3("SELECT slot_id, look, gender FROM user_wardrobe WHERE user_id = @userid;");
					if (dataTable == null)
					{
						gClass.method_9(0);
					}
					else
					{
						gClass.method_9(dataTable.Rows.Count);
						foreach (DataRow dataRow in dataTable.Rows)
						{
							gClass.method_11((uint)dataRow["slot_id"]);
							gClass.method_7((string)dataRow["look"]);
							gClass.method_7((string)dataRow["gender"]);
						}
					}
				}
				class16_0.method_14(gClass);
			}
		}
	}
}
