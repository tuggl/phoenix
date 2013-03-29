using System;
namespace ns0
{
	internal sealed class Class216 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class48 @class = Phoenix.smethod_15().method_6().method_5(class18_0.method_14());
			if (@class != null && @class.bool_1 && @class.bool_0 && @class.uint_0 <= class16_0.method_2().uint_1)
			{
				if (@class.bool_2 && !class16_0.method_2().method_20().method_2("habbo_club"))
				{
					class16_0.method_8("This page is for Phoenix Club members only!");
				}
				else
				{
					class16_0.method_14(@class.GClass5_0);
					if (@class.string_1 == "recycler")
					{
						GClass5 gClass = new GClass5(507u);
						gClass.method_13(true);
						gClass.method_13(false);
						class16_0.method_14(gClass);
					}
					else
					{
						if (@class.string_1 == "club_buy")
						{
							GClass5 gClass2 = new GClass5(625u);
							if (class16_0.method_2().bool_14)
							{
								gClass2.method_9(2);
								gClass2.method_9(4535);
								gClass2.method_7("HABBO_CLUB_VIP_1_MONTH");
								gClass2.method_9(25);
								gClass2.method_9(0);
								gClass2.method_9(1);
								gClass2.method_9(1);
								gClass2.method_9(101);
								gClass2.method_9(DateTime.Today.AddDays(30.0).Year);
								gClass2.method_9(DateTime.Today.AddDays(30.0).Month);
								gClass2.method_9(DateTime.Today.AddDays(30.0).Day);
								gClass2.method_9(4536);
								gClass2.method_7("HABBO_CLUB_VIP_3_MONTHS");
								gClass2.method_9(60);
								gClass2.method_9(0);
								gClass2.method_9(1);
								gClass2.method_9(3);
								gClass2.method_9(163);
								gClass2.method_9(DateTime.Today.AddDays(90.0).Year);
								gClass2.method_9(DateTime.Today.AddDays(90.0).Month);
								gClass2.method_9(DateTime.Today.AddDays(90.0).Day);
							}
							else
							{
								gClass2.method_9(4);
								gClass2.method_9(4533);
								gClass2.method_7("HABBO_CLUB_BASIC_1_MONTH");
								gClass2.method_9(15);
								gClass2.method_9(0);
								gClass2.method_9(0);
								gClass2.method_9(1);
								gClass2.method_9(31);
								gClass2.method_9(DateTime.Today.AddDays(30.0).Year);
								gClass2.method_9(DateTime.Today.AddDays(30.0).Month);
								gClass2.method_9(DateTime.Today.AddDays(30.0).Day);
								gClass2.method_9(4534);
								gClass2.method_7("HABBO_CLUB_BASIC_3_MONTHS");
								gClass2.method_9(45);
								gClass2.method_9(0);
								gClass2.method_9(0);
								gClass2.method_9(3);
								gClass2.method_9(93);
								gClass2.method_9(DateTime.Today.AddDays(90.0).Year);
								gClass2.method_9(DateTime.Today.AddDays(90.0).Month);
								gClass2.method_9(DateTime.Today.AddDays(90.0).Day);
								gClass2.method_9(4535);
								gClass2.method_7("HABBO_CLUB_VIP_1_MONTH");
								gClass2.method_9(25);
								gClass2.method_9(0);
								gClass2.method_9(1);
								gClass2.method_9(1);
								gClass2.method_9(101);
								gClass2.method_9(DateTime.Today.AddDays(30.0).Year);
								gClass2.method_9(DateTime.Today.AddDays(30.0).Month);
								gClass2.method_9(DateTime.Today.AddDays(30.0).Day);
								gClass2.method_9(4536);
								gClass2.method_7("HABBO_CLUB_VIP_3_MONTHS");
								gClass2.method_9(60);
								gClass2.method_9(0);
								gClass2.method_9(1);
								gClass2.method_9(3);
								gClass2.method_9(163);
								gClass2.method_9(DateTime.Today.AddDays(90.0).Year);
								gClass2.method_9(DateTime.Today.AddDays(90.0).Month);
								gClass2.method_9(DateTime.Today.AddDays(90.0).Day);
							}
							class16_0.method_14(gClass2);
						}
					}
				}
			}
		}
	}
}
