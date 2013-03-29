using System;
using System.Data;
namespace ns0
{
	internal sealed class Class230 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && !@class.Boolean_3)
			{
				Class33 class2 = @class.method_48(num);
				if (class2 == null || class2.class15_0 == null)
				{
					DataRow dataRow = null;
					using (Class6 class3 = Phoenix.smethod_12().method_0())
					{
						class3.method_0("petid", num);
						dataRow = class3.method_4("SELECT id, user_id, room_id, name, type, race, color, expirience, energy, nutrition, respect, createstamp, x, y, z FROM user_pets WHERE id = @petid LIMIT 1");
					}
					if (dataRow != null)
					{
						class16_0.method_14(Phoenix.smethod_15().method_6().method_12(dataRow).method_4());
					}
				}
				else
				{
					class16_0.method_14(class2.class15_0.method_4());
				}
			}
		}
	}
}
