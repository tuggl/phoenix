using System;
namespace ns0
{
	internal sealed class Class103 : Class99
	{
		private int int_2;
		private int int_3;
		public Class103(int int_4)
		{
			this.int_2 = new Random((int_4 ^ 2) + DateTime.Now.Millisecond).Next(25, 60);
			this.int_3 = new Random((int_4 ^ 2) + DateTime.Now.Millisecond).Next(10, 60);
		}
		private int method_4()
		{
			Class33 @class = base.method_2();
			int result = 5;
			if (@class.class15_0.Int32_0 >= 1)
			{
				result = Phoenix.smethod_5(1, 8);
			}
			else
			{
				if (@class.class15_0.Int32_0 >= 5)
				{
					result = Phoenix.smethod_5(1, 7);
				}
				else
				{
					if (@class.class15_0.Int32_0 >= 10)
					{
						result = Phoenix.smethod_5(1, 6);
					}
				}
			}
			return result;
		}
		private void method_5(int int_4, int int_5, bool bool_0)
		{
			Class33 @class = base.method_2();
			if (bool_0)
			{
				int int_6 = Phoenix.smethod_5(0, base.method_1().Class28_0.int_4);
				int int_7 = Phoenix.smethod_5(0, base.method_1().Class28_0.int_5);
				@class.method_5(int_6, int_7);
			}
			else
			{
				if (int_4 < base.method_1().Class28_0.int_4 && int_5 < base.method_1().Class28_0.int_5 && int_4 >= 0 && int_5 >= 0)
				{
					@class.method_5(int_4, int_5);
				}
			}
		}
		public override void vmethod_0()
		{
			if (base.method_2().class15_0.int_4 > 0 && base.method_2().class15_0.int_5 > 0)
			{
				base.method_2().int_3 = base.method_2().class15_0.int_4;
				base.method_2().int_4 = base.method_2().class15_0.int_5;
			}
			this.method_5(0, 0, true);
		}
		public override void vmethod_1(bool bool_0)
		{
			if (base.method_3().class33_0 != null)
			{
				Class33 class33_ = base.method_3().class33_0;
				if (class33_.class34_1 != null && class33_ == base.method_3().class33_0)
				{
					base.method_3().class33_0 = null;
					class33_.method_16().method_2().method_24().method_2(-1, true);
					class33_.class34_1 = null;
					class33_.class33_0 = null;
				}
			}
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				if (base.method_2().class15_0.enum3_0 == Enum3.const_2)
				{
					@class.method_0("petname" + base.method_2().class15_0.uint_0, base.method_2().class15_0.string_0);
					@class.method_0("petcolor" + base.method_2().class15_0.uint_0, base.method_2().class15_0.string_2);
					@class.method_0("petrace" + base.method_2().class15_0.uint_0, base.method_2().class15_0.string_1);
					@class.method_1(string.Concat(new object[]
					{
						"INSERT INTO `user_pets` VALUES ('",
						base.method_2().class15_0.uint_0,
						"', '",
						base.method_2().class15_0.uint_1,
						"', '0', @petname",
						base.method_2().class15_0.uint_0,
						", @petrace",
						base.method_2().class15_0.uint_0,
						", @petcolor",
						base.method_2().class15_0.uint_0,
						", '",
						base.method_2().class15_0.uint_2,
						"', '",
						base.method_2().class15_0.int_1,
						"', '",
						base.method_2().class15_0.int_2,
						"', '",
						base.method_2().class15_0.int_3,
						"', '",
						base.method_2().class15_0.int_6,
						"', '",
						base.method_2().class15_0.double_1,
						"', '",
						base.method_2().class15_0.int_4,
						"', '",
						base.method_2().class15_0.int_5,
						"', '",
						base.method_2().class15_0.double_0,
						"');"
					}));
				}
				else
				{
					@class.method_1(string.Concat(new object[]
					{
						"UPDATE user_pets SET room_id = '0', expirience = '",
						base.method_2().class15_0.int_1,
						"', energy = '",
						base.method_2().class15_0.int_2,
						"', nutrition = '",
						base.method_2().class15_0.int_3,
						"', respect = '",
						base.method_2().class15_0.int_6,
						"' WHERE id = '",
						base.method_2().class15_0.uint_0,
						"' LIMIT 1; "
					}));
				}
				base.method_2().class15_0.enum3_0 = Enum3.const_0;
			}
		}
		public override void vmethod_2(Class33 class33_0)
		{
		}
		public override void vmethod_3(Class16 class16_0)
		{
			if (class16_0 != null && class16_0.method_2() != null)
			{
				string string_ = class16_0.method_2().string_0;
				Class33 @class = base.method_1().method_53(class16_0.method_2().uint_0);
				if (base.method_3().class33_0 != null && @class != null && @class.class34_1 != null && @class == base.method_3().class33_0)
				{
					base.method_3().class33_0 = null;
				}
				try
				{
					if (string_.ToLower() == base.method_2().class15_0.String_2.ToLower() && string_.ToLower() != base.method_1().string_3.ToLower())
					{
						base.method_1().method_6(base.method_2().class15_0.int_0, false);
						class16_0.method_2().method_23().method_7(base.method_2().class15_0);
					}
				}
				catch
				{
				}
			}
		}
		public override void vmethod_4(Class33 class33_0, string string_0)
		{
			Class33 @class = base.method_2();
			if (@class.class34_0.class33_0 == null)
			{
				if (string_0.ToLower().Equals(@class.class15_0.string_0.ToLower()))
				{
					@class.method_9(Class107.smethod_0(@class.int_3, @class.int_4, class33_0.int_3, class33_0.int_4));
				}
				else
				{
					if (string_0.ToLower().StartsWith(@class.class15_0.string_0.ToLower() + " ") && class33_0.method_16().method_2().string_0.ToLower() == base.method_2().class15_0.String_2.ToLower())
					{
						string key = string_0.Substring(@class.class15_0.string_0.ToLower().Length + 1);
						if ((@class.class15_0.int_2 >= 10 && this.method_4() < 6) || @class.class15_0.Int32_0 >= 15)
						{
							@class.dictionary_0.Clear();
							if (!Phoenix.smethod_15().method_4().dictionary_5.ContainsKey(key))
							{
								string[] array = new string[]
								{
									Class8.smethod_1("pet_response_confused1"),
									Class8.smethod_1("pet_response_confused2"),
									Class8.smethod_1("pet_response_confused3"),
									Class8.smethod_1("pet_response_confused4"),
									Class8.smethod_1("pet_response_confused5"),
									Class8.smethod_1("pet_response_confused6"),
									Class8.smethod_1("pet_response_confused7")
								};
								Random random = new Random();
								@class.method_1(null, array[random.Next(0, array.Length - 1)], false);
							}
							else
							{
								switch (Phoenix.smethod_15().method_4().dictionary_5[key])
								{
								case 1:
									@class.class15_0.method_1(10, -25);
									@class.method_1(null, Class8.smethod_1("pet_response_sleep"), false);
									@class.dictionary_0.Add("lay", @class.double_0.ToString());
									break;
								case 2:
									this.method_5(0, 0, true);
									@class.class15_0.method_1(5, 5);
									break;
								case 3:
									@class.class15_0.method_1(5, 5);
									@class.dictionary_0.Add("sit", @class.double_0.ToString());
									break;
								case 4:
									@class.class15_0.method_1(5, 5);
									@class.dictionary_0.Add("lay", @class.double_0.ToString());
									break;
								case 5:
									@class.class15_0.method_1(10, 10);
									this.int_3 = 60;
									break;
								case 6:
								{
									int int_ = class33_0.int_3;
									int int_2 = class33_0.int_4;
									if (class33_0.int_8 == 4)
									{
										int_2 = class33_0.int_4 + 1;
									}
									else
									{
										if (class33_0.int_8 == 0)
										{
											int_2 = class33_0.int_4 - 1;
										}
										else
										{
											if (class33_0.int_8 == 6)
											{
												int_ = class33_0.int_3 - 1;
											}
											else
											{
												if (class33_0.int_8 == 2)
												{
													int_ = class33_0.int_3 + 1;
												}
												else
												{
													if (class33_0.int_8 == 3)
													{
														int_ = class33_0.int_3 + 1;
														int_2 = class33_0.int_4 + 1;
													}
													else
													{
														if (class33_0.int_8 == 1)
														{
															int_ = class33_0.int_3 + 1;
															int_2 = class33_0.int_4 - 1;
														}
														else
														{
															if (class33_0.int_8 == 7)
															{
																int_ = class33_0.int_3 - 1;
																int_2 = class33_0.int_4 - 1;
															}
															else
															{
																if (class33_0.int_8 == 5)
																{
																	int_ = class33_0.int_3 - 1;
																	int_2 = class33_0.int_4 + 1;
																}
															}
														}
													}
												}
											}
										}
									}
									@class.class15_0.method_1(15, 15);
									this.method_5(int_, int_2, false);
									break;
								}
								case 7:
									@class.class15_0.method_1(20, 20);
									@class.dictionary_0.Add("ded", @class.double_0.ToString());
									break;
								case 8:
									@class.class15_0.method_1(10, 10);
									@class.dictionary_0.Add("beg", @class.double_0.ToString());
									break;
								case 9:
									@class.class15_0.method_1(15, 15);
									@class.dictionary_0.Add("jmp", @class.double_0.ToString());
									break;
								case 10:
									@class.class15_0.method_1(25, 25);
									@class.method_1(null, Class8.smethod_1("pet_response_silent"), false);
									this.int_2 = 120;
									break;
								case 11:
									@class.class15_0.method_1(15, 15);
									this.int_2 = 2;
									break;
								}
							}
						}
						else
						{
							string[] array2 = new string[]
							{
								Class8.smethod_1("pet_response_sleeping1"),
								Class8.smethod_1("pet_response_sleeping2"),
								Class8.smethod_1("pet_response_sleeping3"),
								Class8.smethod_1("pet_response_sleeping4"),
								Class8.smethod_1("pet_response_sleeping5")
							};
							string[] array3 = new string[]
							{
								Class8.smethod_1("pet_response_refusal1"),
								Class8.smethod_1("pet_response_refusal2"),
								Class8.smethod_1("pet_response_refusal3"),
								Class8.smethod_1("pet_response_refusal4"),
								Class8.smethod_1("pet_response_refusal5")
							};
							@class.int_10 = @class.int_12;
							@class.int_11 = @class.int_13;
							@class.dictionary_0.Clear();
							if (@class.class15_0.int_2 < 10)
							{
								Random random2 = new Random();
								@class.method_1(null, array2[random2.Next(0, array2.Length - 1)], false);
								if (@class.class15_0.uint_2 != 13u)
								{
									@class.dictionary_0.Add("lay", @class.double_0.ToString());
								}
								else
								{
									@class.dictionary_0.Add("lay", (@class.double_0 - 1.0).ToString());
								}
								this.int_2 = 25;
								this.int_3 = 20;
								base.method_2().class15_0.method_2(-25);
							}
							else
							{
								Random random2 = new Random();
								@class.method_1(null, array3[random2.Next(0, array3.Length - 1)], false);
							}
						}
						@class.bool_7 = true;
					}
				}
			}
		}
		public override void vmethod_5(Class33 class33_0, string string_0)
		{
		}
		public override void vmethod_6()
		{
			if (this.int_2 <= 0)
			{
				Class33 @class = base.method_2();
				string[] array = new string[]
				{
					Class8.smethod_1("pet_chatter_dog1"),
					Class8.smethod_1("pet_chatter_dog2"),
					Class8.smethod_1("pet_chatter_dog3"),
					Class8.smethod_1("pet_chatter_dog4"),
					Class8.smethod_1("pet_chatter_dog5")
				};
				string[] array2 = new string[]
				{
					Class8.smethod_1("pet_chatter_cat1"),
					Class8.smethod_1("pet_chatter_cat2"),
					Class8.smethod_1("pet_chatter_cat3"),
					Class8.smethod_1("pet_chatter_cat4"),
					Class8.smethod_1("pet_chatter_cat5")
				};
				string[] array3 = new string[]
				{
					Class8.smethod_1("pet_chatter_croc1"),
					Class8.smethod_1("pet_chatter_croc2"),
					Class8.smethod_1("pet_chatter_croc3"),
					Class8.smethod_1("pet_chatter_croc4"),
					Class8.smethod_1("pet_chatter_croc5")
				};
				string[] array4 = new string[]
				{
					Class8.smethod_1("pet_chatter_dog1"),
					Class8.smethod_1("pet_chatter_dog2"),
					Class8.smethod_1("pet_chatter_dog3"),
					Class8.smethod_1("pet_chatter_dog4"),
					Class8.smethod_1("pet_chatter_dog5")
				};
				string[] array5 = new string[]
				{
					Class8.smethod_1("pet_chatter_bear1"),
					Class8.smethod_1("pet_chatter_bear2"),
					Class8.smethod_1("pet_chatter_bear3"),
					Class8.smethod_1("pet_chatter_bear4"),
					Class8.smethod_1("pet_chatter_bear5")
				};
				string[] array6 = new string[]
				{
					Class8.smethod_1("pet_chatter_pig1"),
					Class8.smethod_1("pet_chatter_pig2"),
					Class8.smethod_1("pet_chatter_pig3"),
					Class8.smethod_1("pet_chatter_pig4"),
					Class8.smethod_1("pet_chatter_pig5")
				};
				string[] array7 = new string[]
				{
					Class8.smethod_1("pet_chatter_lion1"),
					Class8.smethod_1("pet_chatter_lion2"),
					Class8.smethod_1("pet_chatter_lion3"),
					Class8.smethod_1("pet_chatter_lion4"),
					Class8.smethod_1("pet_chatter_lion5")
				};
				string[] array8 = new string[]
				{
					Class8.smethod_1("pet_chatter_rhino1"),
					Class8.smethod_1("pet_chatter_rhino2"),
					Class8.smethod_1("pet_chatter_rhino3"),
					Class8.smethod_1("pet_chatter_rhino4"),
					Class8.smethod_1("pet_chatter_rhino5")
				};
				string[] array9 = new string[]
				{
					Class8.smethod_1("pet_chatter_spider1"),
					Class8.smethod_1("pet_chatter_spider2"),
					Class8.smethod_1("pet_chatter_spider3"),
					Class8.smethod_1("pet_chatter_spider4"),
					Class8.smethod_1("pet_chatter_spider5")
				};
				string[] array10 = new string[]
				{
					Class8.smethod_1("pet_chatter_turtle1"),
					Class8.smethod_1("pet_chatter_turtle2"),
					Class8.smethod_1("pet_chatter_turtle3"),
					Class8.smethod_1("pet_chatter_turtle4"),
					Class8.smethod_1("pet_chatter_turtle5")
				};
				string[] array11 = new string[]
				{
					Class8.smethod_1("pet_chatter_chic1"),
					Class8.smethod_1("pet_chatter_chic2"),
					Class8.smethod_1("pet_chatter_chic3"),
					Class8.smethod_1("pet_chatter_chic4"),
					Class8.smethod_1("pet_chatter_chic5")
				};
				string[] array12 = new string[]
				{
					Class8.smethod_1("pet_chatter_frog1"),
					Class8.smethod_1("pet_chatter_frog2"),
					Class8.smethod_1("pet_chatter_frog3"),
					Class8.smethod_1("pet_chatter_frog4"),
					Class8.smethod_1("pet_chatter_frog5")
				};
				string[] array13 = new string[]
				{
					Class8.smethod_1("pet_chatter_dragon1"),
					Class8.smethod_1("pet_chatter_dragon2"),
					Class8.smethod_1("pet_chatter_dragon3"),
					Class8.smethod_1("pet_chatter_dragon4"),
					Class8.smethod_1("pet_chatter_dragon5")
				};
				string[] array14 = new string[]
				{
					Class8.smethod_1("pet_chatter_horse1"),
					Class8.smethod_1("pet_chatter_horse2"),
					Class8.smethod_1("pet_chatter_horse3"),
					Class8.smethod_1("pet_chatter_horse4"),
					Class8.smethod_1("pet_chatter_horse5")
				};
				string[] array15 = new string[]
				{
					Class8.smethod_1("pet_chatter_monkey1"),
					Class8.smethod_1("pet_chatter_monkey2"),
					Class8.smethod_1("pet_chatter_monkey3"),
					Class8.smethod_1("pet_chatter_monkey4"),
					Class8.smethod_1("pet_chatter_monkey5")
				};
				string[] array16 = new string[]
				{
					Class8.smethod_1("pet_chatter_generic1"),
					Class8.smethod_1("pet_chatter_generic2"),
					Class8.smethod_1("pet_chatter_generic3"),
					Class8.smethod_1("pet_chatter_generic4"),
					Class8.smethod_1("pet_chatter_generic5")
				};
				string[] array17 = new string[]
				{
					"sit",
					"lay",
					"snf",
					"ded",
					"jmp",
					"snf",
					"sit",
					"snf"
				};
				string[] array18 = new string[]
				{
					"sit",
					"lay"
				};
				string[] array19 = new string[]
				{
					"wng",
					"grn",
					"flm",
					"std",
					"swg",
					"sit",
					"lay",
					"snf",
					"plf",
					"jmp",
					"flm",
					"crk",
					"rlx",
					"flm"
				};
				if (@class != null)
				{
					Random random = new Random();
					int num = Phoenix.smethod_5(1, 4);
					if (num == 2)
					{
						@class.dictionary_0.Clear();
						if (base.method_2().class34_0.class33_0 == null)
						{
							if (@class.class15_0.uint_2 == 13u)
							{
								@class.dictionary_0.Add(array18[random.Next(0, array18.Length - 1)], @class.double_0.ToString());
							}
							else
							{
								if (@class.class15_0.uint_2 != 12u)
								{
									@class.dictionary_0.Add(array17[random.Next(0, array17.Length - 1)], @class.double_0.ToString());
								}
								else
								{
									@class.dictionary_0.Add(array19[random.Next(0, array19.Length - 1)], @class.double_0.ToString());
								}
							}
						}
					}
					switch (@class.class15_0.uint_2)
					{
					case 0u:
						@class.method_1(null, array[random.Next(0, array.Length - 1)], false);
						break;
					case 1u:
						@class.method_1(null, array2[random.Next(0, array2.Length - 1)], false);
						break;
					case 2u:
						@class.method_1(null, array3[random.Next(0, array3.Length - 1)], false);
						break;
					case 3u:
						@class.method_1(null, array4[random.Next(0, array4.Length - 1)], false);
						break;
					case 4u:
						@class.method_1(null, array5[random.Next(0, array5.Length - 1)], false);
						break;
					case 5u:
						@class.method_1(null, array6[random.Next(0, array6.Length - 1)], false);
						break;
					case 6u:
						@class.method_1(null, array7[random.Next(0, array7.Length - 1)], false);
						break;
					case 7u:
						@class.method_1(null, array8[random.Next(0, array8.Length - 1)], false);
						break;
					case 8u:
						@class.method_1(null, array9[random.Next(0, array9.Length - 1)], false);
						break;
					case 9u:
						@class.method_1(null, array10[random.Next(0, array10.Length - 1)], false);
						break;
					case 10u:
						@class.method_1(null, array11[random.Next(0, array11.Length - 1)], false);
						break;
					case 11u:
						@class.method_1(null, array12[random.Next(0, array12.Length - 1)], false);
						break;
					case 12u:
						@class.method_1(null, array13[random.Next(0, array13.Length - 1)], false);
						break;
					case 13u:
						@class.method_1(null, array14[random.Next(0, array14.Length - 1)], false);
						break;
					case 14u:
						@class.method_1(null, array15[random.Next(0, array15.Length - 1)], false);
						break;
					default:
						@class.method_1(null, array16[random.Next(0, array16.Length - 1)], false);
						break;
					}
				}
				this.int_2 = Phoenix.smethod_5(30, 120);
			}
			else
			{
				this.int_2--;
			}
			if (this.int_3 <= 0)
			{
				base.method_2().class15_0.method_2(-10);
				if (base.method_2().class34_0.class33_0 == null)
				{
					this.method_5(0, 0, true);
				}
				this.int_3 = 30;
			}
			else
			{
				this.int_3--;
			}
		}
	}
}
