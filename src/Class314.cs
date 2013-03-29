using System;
namespace ns0
{
	internal sealed class Class314 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0.method_2() == null)
			{
				class16_0.method_6(class18_0.method_9());
				if (class16_0.method_2() != null && class16_0.method_2().list_2 != null && class16_0.method_2().list_2.Count > 0)
				{
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						try
						{
							GClass5 gClass = new GClass5(420u);
							gClass.method_9(class16_0.method_2().list_2.Count);
							foreach (uint current in class16_0.method_2().list_2)
							{
								string string_ = @class.method_5("SELECT username FROM users WHERE id = " + current + " LIMIT 1;");
								gClass.method_7(string_);
							}
							class16_0.method_14(gClass);
						}
						catch
						{
							Console.ForegroundColor = ConsoleColor.Red;
							GClass4.smethod_1("Login error: User is ignoring a user that no longer exists");
							Console.ForegroundColor = ConsoleColor.Gray;
						}

					}
				}
			}
		}
	}
}
