using System;
namespace ns0
{
	internal sealed class Class158 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 class14_ = class16_0.method_2().Class14_0;
			if (class14_ != null)
			{
				class18_0.method_15();
				string string_ = class18_0.method_9();
				Class33 @class = class14_.method_56(string_);
				if (@class != null && @class.method_16().method_2().uint_1 <= 2u)
				{
					uint uint_ = @class.method_16().method_2().uint_0;
					if (!class16_0.method_2().list_2.Contains(uint_))
					{
						class16_0.method_2().list_2.Add(uint_);
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							class2.method_1(string.Concat(new object[]
							{
								"INSERT INTO user_ignores(user_id, ignore_id) VALUES (",
								class16_0.method_2().uint_0,
								", ",
								uint_,
								");"
							}));
						}
						GClass5 gClass = new GClass5(419u);
						gClass.method_9(1);
						class16_0.method_14(gClass);
					}
				}
			}
		}
	}
}
