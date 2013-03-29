using System;
namespace ns0
{
	internal sealed class Class223 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			class18_0.method_14();
			uint num = class18_0.method_15();
			class18_0.method_14();
			if (Phoenix.smethod_11().dictionary_0["emu.messages.roommgr"] == "1")
			{
				GClass4.smethod_1("[RoomMgr] Requesting Public Room [ID: " + num + "]");
			}
			Class27 @class = Phoenix.smethod_15().method_9().method_12(num);
			if (@class != null && !(@class.string_2 != "public"))
			{
				class16_0.method_1().method_5(num, "");
			}
		}
	}
}
