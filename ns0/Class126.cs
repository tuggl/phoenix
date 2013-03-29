using System;
namespace ns0
{
	internal sealed class Class126 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			int num = class18_0.method_14();
			if (num < 0)
			{
				num = 0;
			}
			else
			{
				if (num > 100)
				{
					num = 100;
				}
			}
			class16_0.method_2().int_11 = num;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_0("user_id", class16_0.method_2().uint_0);
				@class.method_0("volume", num);
				@class.method_1("UPDATE users SET volume = @volume WHERE id = @user_id LIMIT 1;");
			}
		}
	}
}
