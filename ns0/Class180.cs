using System;
namespace ns0
{
	internal sealed class Class180 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			class16_0.method_2().method_22().method_5();
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_1("UPDATE user_badges SET badge_slot = '0' WHERE user_id = '" + class16_0.method_2().uint_0 + "'");
				goto IL_131;
			}
			IL_52:
			int num = class18_0.method_14();
			string text = class18_0.method_9();
			if (text.Length != 0)
			{
				if (!class16_0.method_2().method_22().method_1(text) || num < 1 || num > 5)
				{
					return;
				}
				if (class16_0.method_2().uint_6 == 16u)
				{
					Phoenix.smethod_15().method_16().method_1(16u, class16_0);
				}
				class16_0.method_2().method_22().method_0(text).int_0 = num;
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_0("slotid", num);
					@class.method_0("badge", text);
					@class.method_0("userid", class16_0.method_2().uint_0);
					@class.method_1("UPDATE user_badges SET badge_slot = @slotid WHERE badge_id = @badge AND user_id = @userid LIMIT 1");
				}
			}
			IL_131:
			if (class18_0.Int32_1 > 0)
			{
				goto IL_52;
			}
			GClass5 gClass = new GClass5(228u);
			gClass.method_11(class16_0.method_2().uint_0);
			gClass.method_9(class16_0.method_2().method_22().Int32_1);
			foreach (Class57 current in class16_0.method_2().method_22().List_0)
			{
				if (current.int_0 > 0)
				{
					gClass.method_9(current.int_0);
					gClass.method_7(current.string_0);
				}
			}
			if (class16_0.method_2().Boolean_0 && Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3) != null)
			{
				Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3).method_59(gClass, null);
			}
			else
			{
				class16_0.method_14(gClass);
			}
		}
	}
}
