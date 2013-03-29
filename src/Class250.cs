using System;
using System.Collections;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class250 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0.method_2().uint_2 > 0u && class16_0.method_2().bool_5)
			{
				Class27 @class = Phoenix.smethod_15().method_9().method_12(class16_0.method_2().uint_2);
				if (@class != null)
				{
					if (@class.Class28_0 == null)
					{
						class16_0.method_8("Error loading room, please try again soon! (Error Code: MdlData)");
						class16_0.method_14(new GClass5(18u));
						class16_0.method_1().method_7();
					}
					else
					{
						class16_0.method_14(@class.Class28_0.method_1());
						class16_0.method_14(@class.Class28_0.method_2());
						Class14 class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_2);
						if (class2 != null)
						{
							class16_0.method_1().method_7();
							GClass5 gClass = new GClass5(30u);
							if (class2.Class28_0.string_2 != "")
							{
								gClass.method_7(class2.Class28_0.string_2);
							}
							else
							{
								gClass.method_9(0);
							}
							class16_0.method_14(gClass);
							if (class2.string_2 == "private")
							{
								Hashtable hashtable_ = class2.Hashtable_0;
								Hashtable hashtable_2 = class2.Hashtable_1;
								GClass5 gClass2 = new GClass5(32u);
								gClass2.method_9(hashtable_.Count);
								foreach (Class63 class3 in hashtable_.Values)
								{
									class3.method_6(gClass2);
								}
								class16_0.method_14(gClass2);
								GClass5 gClass3 = new GClass5(45u);
								gClass3.method_9(hashtable_2.Count);
								foreach (Class63 class3 in hashtable_2.Values)
								{
									class3.method_6(gClass3);
								}
								class16_0.method_14(gClass3);
							}
							class2.method_46(class16_0, class16_0.method_2().bool_8);
							List<Class33> list = new List<Class33>();
							for (int i = 0; i < class2.class33_0.Length; i++)
							{
								Class33 class4 = class2.class33_0[i];
								if (class4 != null && (!class4.bool_11 && class4.bool_12))
								{
									list.Add(class4);
								}
							}
							GClass5 gClass4 = new GClass5(28u);
							gClass4.method_9(list.Count);
							foreach (Class33 class4 in list)
							{
								class4.method_14(gClass4);
							}
							class16_0.method_14(gClass4);
							GClass5 gClass5 = new GClass5(472u);
							gClass5.method_13(class2.bool_3);
							gClass5.method_9(class2.int_5);
							gClass5.method_9(class2.int_6);
							class16_0.method_14(gClass5);
							if (class2.string_2 == "public")
							{
								GClass5 gClass6 = new GClass5(471u);
								gClass6.method_13(false);
								gClass6.method_7(class2.string_5);
								gClass6.method_13(false);
								class16_0.method_14(gClass6);
							}
							else
							{
								if (class2.string_2 == "private")
								{
									GClass5 gClass6 = new GClass5(471u);
									gClass6.method_13(true);
									gClass6.method_11(class2.UInt32_0);
									if (class2.method_27(class16_0, true))
									{
										gClass6.method_13(true);
									}
									else
									{
										gClass6.method_13(false);
									}
									class16_0.method_14(gClass6);
									GClass5 gClass7 = new GClass5(454u);
									gClass7.method_13(false);
									@class.method_3(gClass7, false, false);
									class16_0.method_14(gClass7);
								}
							}
							GClass5 gClass8 = class2.method_67(true);
							if (gClass8 != null)
							{
								class16_0.method_14(gClass8);
							}
							for (int i = 0; i < class2.class33_0.Length; i++)
							{
								Class33 class4 = class2.class33_0[i];
								if (class4 != null && !class4.bool_11)
								{
									if (class4.Boolean_1)
									{
										GClass5 gClass9 = new GClass5(480u);
										gClass9.method_9(class4.int_0);
										gClass9.method_9(class4.int_15);
										class16_0.method_14(gClass9);
									}
									if (class4.bool_8)
									{
										GClass5 gClass10 = new GClass5(486u);
										gClass10.method_9(class4.int_0);
										gClass10.method_13(true);
										class16_0.method_14(gClass10);
									}
									if (class4.int_5 > 0 && class4.int_6 > 0)
									{
										GClass5 gClass11 = new GClass5(482u);
										gClass11.method_9(class4.int_0);
										gClass11.method_9(class4.int_5);
										class16_0.method_14(gClass11);
									}
									if (!class4.Boolean_4)
									{
										try
										{
											if (class4.method_16().method_2() != null && class4.method_16().method_2().method_24() != null && class4.method_16().method_2().method_24().int_0 >= 1)
											{
												GClass5 gClass12 = new GClass5(485u);
												gClass12.method_9(class4.int_0);
												gClass12.method_9(class4.method_16().method_2().method_24().int_0);
												class16_0.method_14(gClass12);
											}
											goto IL_5C5;
										}
										catch
										{
											goto IL_5C5;
										}
									}
									if (!class4.Boolean_0 && class4.class34_0.int_0 != 0)
									{
										GClass5 gClass12 = new GClass5(485u);
										gClass12.method_9(class4.int_0);
										gClass12.method_9(class4.class34_0.int_0);
										class16_0.method_14(gClass12);
									}
								}
								IL_5C5:;
							}
							if (class2 != null && class16_0 != null && class16_0.method_2().Class14_0 != null)
							{
								class2.method_8(class16_0.method_2().Class14_0.method_53(class16_0.method_2().uint_0));
							}
							if (class2.uint_1 > 0u)
							{
								Phoenix.smethod_15().method_12().method_3(class16_0, class2.uint_1, 1);
							}
							if (class16_0.method_2().bool_3 && class16_0.method_2().int_4 > 0)
							{
								GClass5 gClass13 = new GClass5(27u);
								gClass13.method_9(class16_0.method_2().int_4);
								class16_0.method_14(gClass13);
							}
						}
					}
				}
			}
		}
	}
}
