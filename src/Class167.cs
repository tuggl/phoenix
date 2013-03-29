using System;
namespace ns0
{
	internal sealed class Class167 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			string text = class18_0.method_9();
			string text2 = class18_0.method_9();
			if (Class98.smethod_0(text, text2))
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_0("userid", class16_0.method_2().uint_0);
					@class.method_0("slotid", num);
					@class.method_0("look", text);
					@class.method_0("gender", text2.ToUpper());
					if (@class.method_4("SELECT null FROM user_wardrobe WHERE user_id = @userid AND slot_id = @slotid LIMIT 1") != null)
					{
						@class.method_1("UPDATE user_wardrobe SET look = @look, gender = @gender WHERE user_id = @userid AND slot_id = @slotid LIMIT 1;");
					}
					else
					{
						@class.method_1("INSERT INTO user_wardrobe (user_id,slot_id,look,gender) VALUES (@userid,@slotid,@look,@gender)");
					}
				}
			}
		}
	}
}
