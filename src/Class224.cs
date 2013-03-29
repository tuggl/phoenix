using System;
namespace ns0
{
	internal sealed class Class224 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			string string_ = class18_0.method_9();
			class18_0.method_14();
			if (Phoenix.smethod_11().dictionary_0["emu.messages.roommgr"] == "1")
			{
				GClass4.smethod_1("[RoomMgr] Requesting Private Room [ID: " + num + "]");
			}
			class16_0.method_1().method_5(num, string_);
		}
	}
}
