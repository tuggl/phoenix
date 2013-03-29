using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class45
	{
		public Dictionary<int, Class48> dictionary_0;
		public List<Class47> list_0;
		private Class46 class46_0;
		private Class43 class43_0;
		private GClass5[] gclass5_0;
		private uint uint_0 = 0u;
		private readonly object object_0 = new object();
		public Class45()
		{
			this.class46_0 = new Class46();
			this.class43_0 = new Class43();
		}
		public void method_0(Class6 class6_0)
		{
			GClass4.smethod_0("Loading Catalogue..");
			this.dictionary_0 = new Dictionary<int, Class48>();
			this.list_0 = new List<Class47>();
			DataTable dataTable = class6_0.method_3("SELECT * FROM catalog_pages ORDER BY order_num ASC");
			DataTable dataTable2 = class6_0.method_3("SELECT * FROM ecotron_rewards ORDER BY item_id");
			try
			{
				this.uint_0 = (uint)class6_0.method_4("SELECT ID FROM items ORDER BY ID DESC LIMIT 1")[0];
			}
			catch
			{
				this.uint_0 = 0u;
			}
			this.uint_0 += 1u;
			Hashtable hashtable = new Hashtable();
			DataTable dataTable3 = class6_0.method_3("SELECT * FROM catalog_items");
			if (dataTable3 != null)
			{
				foreach (DataRow dataRow in dataTable3.Rows)
				{
					if (!(dataRow["item_ids"].ToString() == "") && (int)dataRow["amount"] > 0)
					{
						hashtable.Add((uint)dataRow["id"], new Class49((uint)dataRow["id"], (string)dataRow["catalog_name"], (string)dataRow["item_ids"], (int)dataRow["cost_credits"], (int)dataRow["cost_pixels"], (int)dataRow["cost_snow"], (int)dataRow["amount"], (int)dataRow["page_id"], Phoenix.smethod_2(dataRow["vip"].ToString()), (uint)dataRow["achievement"]));
					}
				}
			}
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					bool bool_ = false;
					bool bool_2 = false;
					if (dataRow["visible"].ToString() == "1")
					{
						bool_ = true;
					}
					if (dataRow["enabled"].ToString() == "1")
					{
						bool_2 = true;
					}
					this.dictionary_0.Add((int)dataRow["id"], new Class48((int)dataRow["id"], (int)dataRow["parent_id"], (string)dataRow["caption"], bool_, bool_2, (uint)dataRow["min_rank"], Phoenix.smethod_3(dataRow["club_only"].ToString()), (int)dataRow["icon_color"], (int)dataRow["icon_image"], (string)dataRow["page_layout"], (string)dataRow["page_headline"], (string)dataRow["page_teaser"], (string)dataRow["page_special"], (string)dataRow["page_text1"], (string)dataRow["page_text2"], (string)dataRow["page_text_details"], (string)dataRow["page_text_teaser"], (string)dataRow["page_link_description"], (string)dataRow["page_link_pagename"], ref hashtable));
				}
			}
			if (dataTable2 != null)
			{
				foreach (DataRow dataRow in dataTable2.Rows)
				{
					this.list_0.Add(new Class47((uint)dataRow["id"], (uint)dataRow["display_id"], (uint)dataRow["item_id"], (uint)dataRow["reward_level"]));
				}
			}
			GClass4.smethod_1("completed!");
		}
		internal void method_1()
		{
			GClass4.smethod_0("Loading Catalogue Cache..");
			int num = Phoenix.smethod_15().method_4().dictionary_2.Count + 1;
			this.gclass5_0 = new GClass5[num];
			for (int i = 1; i < num; i++)
			{
				this.gclass5_0[i] = this.method_17(i);
			}
			foreach (Class48 current in this.dictionary_0.Values)
			{
				current.method_0();
			}
			GClass4.smethod_1("completed!");
		}
		public Class49 method_2(uint uint_1)
		{
			Class49 result;
			foreach (Class48 current in this.dictionary_0.Values)
			{
				foreach (Class49 current2 in current.list_0)
				{
					if (current2.uint_0 == uint_1)
					{
						result = current2;
						return result;
					}
				}
			}
			result = null;
			return result;
		}
		public bool method_3(uint uint_1)
		{
			DataRow dataRow = null;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				dataRow = @class.method_4("SELECT id FROM catalog_items WHERE item_ids = '" + uint_1 + "' LIMIT 1");
			}
			return dataRow != null;
		}
		public int method_4(int int_0, int int_1)
		{
			int num = 0;
			foreach (Class48 current in this.dictionary_0.Values)
			{
				if ((ulong)current.uint_0 <= (ulong)((long)int_0) && current.int_1 == int_1)
				{
					num++;
				}
			}
			return num;
		}
		public Class48 method_5(int int_0)
		{
			Class48 result;
			if (!this.dictionary_0.ContainsKey(int_0))
			{
				result = null;
			}
			else
			{
				result = this.dictionary_0[int_0];
			}
			return result;
		}
		public bool method_6(Class16 class16_0, int int_0, uint uint_1, string string_0, bool bool_0, string string_1, string string_2, bool bool_1)
		{
			Class48 @class = this.method_5(int_0);
			bool result;
			if (@class == null || !@class.bool_1 || !@class.bool_0 || @class.uint_0 > class16_0.method_2().uint_1)
			{
				result = false;
			}
			else
			{
				if (@class.bool_2 && (!class16_0.method_2().method_20().method_2("habbo_club") || !class16_0.method_2().method_20().method_2("habbo_vip")))
				{
					result = false;
				}
				else
				{
					Class49 class2 = @class.method_1(uint_1);
					if (class2 == null)
					{
						result = false;
					}
					else
					{
						uint num = 0u;
						if (bool_0)
						{
							if (!class2.method_0().bool_6)
							{
								result = false;
								return result;
							}
							if (class16_0.method_2().method_4() > 0)
							{
								TimeSpan timeSpan = DateTime.Now - class16_0.method_2().dateTime_0;
								if (timeSpan.Seconds > 4)
								{
									class16_0.method_2().int_23 = 0;
								}
								if (timeSpan.Seconds < 4 && class16_0.method_2().int_23 > 3)
								{
									class16_0.method_2().bool_15 = true;
									result = false;
									return result;
								}
								if (class16_0.method_2().bool_15 && timeSpan.Seconds < class16_0.method_2().method_4())
								{
									result = false;
									return result;
								}
								class16_0.method_2().bool_15 = false;
								class16_0.method_2().dateTime_0 = DateTime.Now;
								class16_0.method_2().int_23++;
							}
							using (Class6 class3 = Phoenix.smethod_12().method_0())
							{
								class3.method_0("gift_user", string_1);
								try
								{
									num = (uint)class3.method_4("SELECT id FROM users WHERE username = @gift_user LIMIT 1")[0];
								}
								catch (Exception)
								{
								}
							}
							if (num == 0u)
							{
								GClass5 gClass = new GClass5(76u);
								gClass.method_13(true);
								gClass.method_7(string_1);
								class16_0.method_14(gClass);
								result = false;
								return result;
							}
						}
						bool flag = false;
						bool flag2 = false;
						int int_ = class2.int_2;
						if (class16_0.method_2().int_2 < class2.int_0)
						{
							flag = true;
						}
						if ((int_ == 0 && class16_0.method_2().int_3 < class2.int_1) || (int_ > 0 && class16_0.method_2().int_12 < class2.int_1))
						{
							flag2 = true;
						}
						if (flag || flag2)
						{
							GClass5 gClass2 = new GClass5(68u);
							gClass2.method_13(flag);
							gClass2.method_13(flag2);
							class16_0.method_14(gClass2);
							result = false;
						}
						else
						{
							if (bool_0 && class2.method_0().char_0 == 'e')
							{
								class16_0.method_8("You can not send this item as a gift.");
								result = false;
							}
							else
							{
								string text = class2.method_0().string_2.ToLower();
								if (text != null)
								{
									if (!(text == "pet"))
									{
										if (text == "roomeffect")
										{
											double num2 = 0.0;
											try
											{
												num2 = double.Parse(string_0);
											}
											catch (Exception)
											{
											}
											string_0 = num2.ToString().Replace(',', '.');
											goto IL_4FC;
										}
										if (text == "postit")
										{
											string_0 = "FFFF33";
											goto IL_4FC;
										}
										if (text == "dimmer")
										{
											string_0 = "1,1,1,#000000,255";
											goto IL_4FC;
										}
										if (text == "trophy")
										{
											string_0 = string.Concat(new object[]
											{
												class16_0.method_2().string_0,
												Convert.ToChar(9),
												DateTime.Now.Day,
												"-",
												DateTime.Now.Month,
												"-",
												DateTime.Now.Year,
												Convert.ToChar(9),
												Class58.smethod_4(Phoenix.smethod_8(string_0, true, true))
											});
											goto IL_4FC;
										}
									}
									else
									{
										try
										{
											string[] array = string_0.Split(new char[]
											{
												'\n'
											});
											string string_3 = array[0];
											string text2 = array[1];
											string text3 = array[2];
											int.Parse(text2);
											if (!this.method_8(string_3))
											{
												result = false;
												return result;
											}
											if (text2.Length > 2)
											{
												result = false;
												return result;
											}
											if (text3.Length != 6)
											{
												result = false;
												return result;
											}
											goto IL_4FC;
										}
										catch (Exception)
										{
											result = false;
											return result;
										}
									}
								}
								if (class2.string_0.StartsWith("disc_"))
								{
									string_0 = class2.string_0.Split(new char[]
									{
										'_'
									})[1];
								}
								else
								{
									string_0 = "";
								}
								IL_4FC:
								if (class2.int_0 > 0)
								{
									class16_0.method_2().int_2 -= class2.int_0;
									class16_0.method_2().method_13(true);
								}
								if (class2.int_1 > 0 && int_ == 0)
								{
									class16_0.method_2().int_3 -= class2.int_1;
									class16_0.method_2().method_15(true);
								}
								else
								{
									if (class2.int_1 > 0 && int_ > 0)
									{
										class16_0.method_2().int_12 -= class2.int_1;
										class16_0.method_2().method_16(0);
										class16_0.method_2().method_14(false, true);
									}
								}
								GClass5 gClass3 = new GClass5(67u);
								gClass3.method_11(class2.method_0().UInt32_0);
								gClass3.method_7(class2.method_0().string_1);
								gClass3.method_9(class2.int_0);
								gClass3.method_9(class2.int_1);
								gClass3.method_9(class2.int_2);
								if (bool_1)
								{
									gClass3.method_9(1);
								}
								else
								{
									gClass3.method_9(0);
								}
								gClass3.method_7(class2.method_0().char_0.ToString());
								gClass3.method_9(class2.method_0().int_0);
								gClass3.method_7("");
								gClass3.method_9(1);
								gClass3.method_9(-1);
								gClass3.method_7("");
								class16_0.method_14(gClass3);
								if (bool_0)
								{
									uint num3 = this.method_14();
									Class40 class4 = this.method_10();
									using (Class6 class3 = Phoenix.smethod_12().method_0())
									{
										class3.method_0("gift_message", "!" + Class58.smethod_4(Phoenix.smethod_8(string_2, true, true)) + " - " + class16_0.method_2().string_0);
										class3.method_0("extra_data", string_0);
										class3.method_1(string.Concat(new object[]
										{
											"INSERT INTO items (id,user_id,base_item,extra_data,wall_pos) VALUES ('",
											num3,
											"','",
											num,
											"','",
											class4.UInt32_0,
											"',@gift_message,'')"
										}));
										class3.method_1(string.Concat(new object[]
										{
											"INSERT INTO user_presents (item_id,base_id,amount,extra_data) VALUES ('",
											num3,
											"','",
											class2.method_0().UInt32_0,
											"','",
											class2.int_3,
											"',@extra_data)"
										}));
									}
									Class16 class5 = Phoenix.smethod_15().method_2().method_2(num);
									int num4;
									if (class5 != null)
									{
										class5.method_8("You have received a gift! Check your inventory.");
										class5.method_2().method_23().method_9(true);
										class5.method_2().int_20++;
										num4 = class5.method_2().int_20;
										if (num4 <= 60)
										{
											if (num4 <= 15)
											{
												if (num4 != 5)
												{
													if (num4 == 15)
													{
														Phoenix.smethod_15().method_12().method_3(class5, 25u, 2);
													}
												}
												else
												{
													Phoenix.smethod_15().method_12().method_3(class5, 25u, 1);
												}
											}
											else
											{
												if (num4 != 35)
												{
													if (num4 != 50)
													{
														if (num4 == 60)
														{
															Phoenix.smethod_15().method_12().method_3(class5, 25u, 5);
														}
													}
													else
													{
														Phoenix.smethod_15().method_12().method_3(class5, 25u, 4);
													}
												}
												else
												{
													Phoenix.smethod_15().method_12().method_3(class5, 25u, 3);
												}
											}
										}
										else
										{
											if (num4 <= 120)
											{
												if (num4 != 80)
												{
													if (num4 == 120)
													{
														Phoenix.smethod_15().method_12().method_3(class5, 25u, 7);
													}
												}
												else
												{
													Phoenix.smethod_15().method_12().method_3(class5, 25u, 6);
												}
											}
											else
											{
												if (num4 != 140)
												{
													if (num4 != 160)
													{
														if (num4 == 200)
														{
															Phoenix.smethod_15().method_12().method_3(class5, 25u, 10);
														}
													}
													else
													{
														Phoenix.smethod_15().method_12().method_3(class5, 25u, 9);
													}
												}
												else
												{
													Phoenix.smethod_15().method_12().method_3(class5, 25u, 8);
												}
											}
										}
									}
									class16_0.method_2().int_19++;
									num4 = class16_0.method_2().int_19;
									if (num4 <= 60)
									{
										if (num4 <= 15)
										{
											if (num4 != 5)
											{
												if (num4 == 15)
												{
													Phoenix.smethod_15().method_12().method_3(class16_0, 24u, 2);
												}
											}
											else
											{
												Phoenix.smethod_15().method_12().method_3(class16_0, 24u, 1);
											}
										}
										else
										{
											if (num4 != 35)
											{
												if (num4 != 50)
												{
													if (num4 == 60)
													{
														Phoenix.smethod_15().method_12().method_3(class16_0, 24u, 5);
													}
												}
												else
												{
													Phoenix.smethod_15().method_12().method_3(class16_0, 24u, 4);
												}
											}
											else
											{
												Phoenix.smethod_15().method_12().method_3(class16_0, 24u, 3);
											}
										}
									}
									else
									{
										if (num4 <= 120)
										{
											if (num4 != 80)
											{
												if (num4 == 120)
												{
													Phoenix.smethod_15().method_12().method_3(class16_0, 24u, 7);
												}
											}
											else
											{
												Phoenix.smethod_15().method_12().method_3(class16_0, 24u, 6);
											}
										}
										else
										{
											if (num4 != 140)
											{
												if (num4 != 160)
												{
													if (num4 == 200)
													{
														Phoenix.smethod_15().method_12().method_3(class16_0, 24u, 10);
													}
												}
												else
												{
													Phoenix.smethod_15().method_12().method_3(class16_0, 24u, 9);
												}
											}
											else
											{
												Phoenix.smethod_15().method_12().method_3(class16_0, 24u, 8);
											}
										}
									}
									class16_0.method_8("Gift sent successfully!");
									result = true;
								}
								else
								{
									this.method_9(class16_0, class2.method_0(), class2.int_3, string_0, true, 0u);
									if (class2.uint_2 > 0u)
									{
										Phoenix.smethod_15().method_12().method_3(class16_0, class2.uint_2, 1);
									}
									result = true;
								}
							}
						}
					}
				}
			}
			return result;
		}
		public void method_7(string string_0, uint uint_1, uint uint_2, int int_0)
		{
			Class48 @class = this.method_5(int_0);
			Class49 class2 = @class.method_1(uint_2);
			uint num = this.method_14();
			Class40 class3 = this.method_10();
			using (Class6 class4 = Phoenix.smethod_12().method_0())
			{
				class4.method_0("gift_message", "!" + Class58.smethod_4(Phoenix.smethod_8(string_0, true, true)));
				class4.method_1(string.Concat(new object[]
				{
					"INSERT INTO items (id,user_id,base_item,extra_data,wall_pos) VALUES ('",
					num,
					"','",
					uint_1,
					"','",
					class3.UInt32_0,
					"',@gift_message,'')"
				}));
				class4.method_1(string.Concat(new object[]
				{
					"INSERT INTO user_presents (item_id,base_id,amount,extra_data) VALUES ('",
					num,
					"','",
					class2.method_0().UInt32_0,
					"','",
					class2.int_3,
					"','')"
				}));
			}
			Class16 class5 = Phoenix.smethod_15().method_2().method_2(uint_1);
			if (class5 != null)
			{
				class5.method_8("You have received a gift! Check your inventory.");
				class5.method_2().method_23().method_9(true);
			}
		}
		public bool method_8(string string_0)
		{
			return string_0.Length >= 1 && string_0.Length <= 16 && Phoenix.smethod_9(string_0) && !(string_0 != Class58.smethod_4(string_0));
		}
		public void method_9(Class16 class16_0, Class40 class40_0, int int_0, string string_0, bool bool_0, uint uint_1)
		{
			string text = class40_0.char_0.ToString();
			if (text != null)
			{
				if (text == "i" || text == "s")
				{
					int i = 0;
					while (i < int_0)
					{
						uint num;
						if (!bool_0 && uint_1 > 0u)
						{
							num = uint_1;
						}
						else
						{
							num = this.method_14();
						}
						text = class40_0.string_2.ToLower();
						if (text == null)
						{
							goto IL_4CF;
						}
						if (!(text == "pet"))
						{
							if (!(text == "teleport"))
							{
								if (!(text == "dimmer"))
								{
									goto IL_4CF;
								}
								using (Class6 @class = Phoenix.smethod_12().method_0())
								{
									@class.method_1("INSERT INTO room_items_moodlight (item_id,enabled,current_preset,preset_one,preset_two,preset_three) VALUES ('" + num + "','0','1','#000000,255,0','#000000,255,0','#000000,255,0')");
								}
								class16_0.method_2().method_23().method_11(num, class40_0.UInt32_0, string_0, bool_0);
							}
							else
							{
								uint num2 = this.method_14();
								using (Class6 @class = Phoenix.smethod_12().method_0())
								{
									@class.method_1(string.Concat(new object[]
									{
										"INSERT INTO tele_links (tele_one_id,tele_two_id) VALUES ('",
										num,
										"','",
										num2,
										"')"
									}));
									@class.method_1(string.Concat(new object[]
									{
										"INSERT INTO tele_links (tele_one_id,tele_two_id) VALUES ('",
										num2,
										"','",
										num,
										"')"
									}));
								}
								class16_0.method_2().method_23().method_11(num2, class40_0.UInt32_0, "0", bool_0);
								class16_0.method_2().method_23().method_11(num, class40_0.UInt32_0, "0", bool_0);
							}
						}
						else
						{
							string[] array = string_0.Split(new char[]
							{
								'\n'
							});
							Class15 class15_ = this.method_11(class16_0.method_2().uint_0, array[0], Convert.ToInt32(class40_0.string_1.Split(new char[]
							{
								't'
							})[1]), array[1], array[2]);
							class16_0.method_2().method_23().method_7(class15_);
							class16_0.method_2().method_23().method_11(num, 320u, "0", bool_0);
						}
						IL_4EA:
						GClass5 gClass = new GClass5(832u);
						gClass.method_9(1);
						if (class40_0.string_2.ToLower() == "pet")
						{
							gClass.method_9(3);
						}
						else
						{
							if (class40_0.char_0.ToString() == "i")
							{
								gClass.method_9(2);
							}
							else
							{
								gClass.method_9(1);
							}
						}
						gClass.method_9(1);
						gClass.method_11(num);
						class16_0.method_14(gClass);
						i++;
						continue;
						IL_4CF:
						class16_0.method_2().method_23().method_11(num, class40_0.UInt32_0, string_0, bool_0);
						goto IL_4EA;
					}
					class16_0.method_2().method_23().method_9(false);
					return;
				}
				if (text == "e")
				{
					for (int i = 0; i < int_0; i++)
					{
						class16_0.method_2().method_24().method_0(class40_0.int_0, 3600);
					}
					return;
				}
				if (text == "h")
				{
					for (int i = 0; i < int_0; i++)
					{
						class16_0.method_2().method_20().method_3("habbo_club", 2678400);
					}
					if (!class16_0.method_2().method_22().method_1("HC1"))
					{
						class16_0.method_2().method_22().method_2(class16_0, "HC1", true);
					}
					GClass5 gClass2 = new GClass5(7u);
					gClass2.method_7("habbo_club");
					if (class16_0.method_2().method_20().method_2("habbo_club"))
					{
						double num3 = (double)class16_0.method_2().method_20().method_1("habbo_club").Int32_0;
						double num4 = num3 - Phoenix.smethod_6();
						int num5 = (int)Math.Ceiling(num4 / 86400.0);
						int num6 = num5 / 31;
						if (num6 >= 1)
						{
							num6--;
						}
						gClass2.method_9(num5 - num6 * 31);
						gClass2.method_13(true);
						gClass2.method_9(num6);
					}
					else
					{
						for (int i = 0; i < 3; i++)
						{
							gClass2.method_9(0);
						}
					}
					class16_0.method_14(gClass2);
					GClass5 gClass3 = new GClass5(2u);
					if (class16_0.method_2().bool_14 || Class13.Boolean_3)
					{
						gClass3.method_9(2);
					}
					else
					{
						if (class16_0.method_2().method_20().method_2("habbo_club"))
						{
							gClass3.method_9(1);
						}
						else
						{
							gClass3.method_9(0);
						}
					}
					if (class16_0.method_2().method_3("acc_anyroomowner"))
					{
						gClass3.method_9(7);
					}
					else
					{
						if (class16_0.method_2().method_3("acc_anyroomrights"))
						{
							gClass3.method_9(5);
						}
						else
						{
							if (class16_0.method_2().method_3("acc_supporttool"))
							{
								gClass3.method_9(4);
							}
							else
							{
								if (class16_0.method_2().bool_14 || Class13.Boolean_3 || class16_0.method_2().method_20().method_2("habbo_club"))
								{
									gClass3.method_9(2);
								}
								else
								{
									gClass3.method_9(0);
								}
							}
						}
					}
					class16_0.method_14(gClass3);
					return;
				}
			}
			class16_0.method_8("Something went wrong! The item type could not be processed. Please do not try to buy this item anymore, instead inform support as soon as possible.");
		}
		public Class40 method_10()
		{
			switch (Phoenix.smethod_5(0, 6))
			{
			case 0:
			{
				Class40 result = Phoenix.smethod_15().method_8().method_2(164u);
				return result;
			}
			case 1:
			{
				Class40 result = Phoenix.smethod_15().method_8().method_2(165u);
				return result;
			}
			case 2:
			{
				Class40 result = Phoenix.smethod_15().method_8().method_2(166u);
				return result;
			}
			case 3:
			{
				Class40 result = Phoenix.smethod_15().method_8().method_2(167u);
				return result;
			}
			case 4:
			{
				Class40 result = Phoenix.smethod_15().method_8().method_2(168u);
				return result;
			}
			case 5:
			{
				Class40 result = Phoenix.smethod_15().method_8().method_2(169u);
				return result;
			}
			case 6:
			{
				Class40 result = Phoenix.smethod_15().method_8().method_2(170u);
				return result;
			}
            default:
            {
                return null;
            }
			}
			/*goto IL_2C;*/
		}
		public Class15 method_11(uint uint_1, string string_0, int int_0, string string_1, string string_2)
		{
			return new Class15(this.method_14(), uint_1, 0u, string_0, (uint)int_0, string_1, string_2, 0, 100, 100, 0, Phoenix.smethod_6(), 0, 0, 0.0)
			{
				enum3_0 = Enum3.const_2
			};
		}
		public Class15 method_12(DataRow dataRow_0)
		{
			Class15 result;
			if (dataRow_0 == null)
			{
				result = null;
			}
			else
			{
				result = new Class15((uint)dataRow_0["id"], (uint)dataRow_0["user_id"], (uint)dataRow_0["room_id"], (string)dataRow_0["name"], (uint)dataRow_0["type"], (string)dataRow_0["race"], (string)dataRow_0["color"], (int)dataRow_0["expirience"], (int)dataRow_0["energy"], (int)dataRow_0["nutrition"], (int)dataRow_0["respect"], (double)dataRow_0["createstamp"], (int)dataRow_0["x"], (int)dataRow_0["y"], (double)dataRow_0["z"]);
			}
			return result;
		}
		internal Class15 method_13(DataRow dataRow_0, uint uint_1)
		{
			Class15 result;
			if (dataRow_0 == null)
			{
				result = null;
			}
			else
			{
				result = new Class15(uint_1, (uint)dataRow_0["user_id"], (uint)dataRow_0["room_id"], (string)dataRow_0["name"], (uint)dataRow_0["type"], (string)dataRow_0["race"], (string)dataRow_0["color"], (int)dataRow_0["expirience"], (int)dataRow_0["energy"], (int)dataRow_0["nutrition"], (int)dataRow_0["respect"], (double)dataRow_0["createstamp"], (int)dataRow_0["x"], (int)dataRow_0["y"], (double)dataRow_0["z"]);
			}
			return result;
		}
		internal uint method_14()
		{
			uint result;
			lock (this.object_0)
			{
				result = this.uint_0++;
			}
			return result;
		}
		public Class47 method_15()
		{
			uint uint_ = 1u;
			if (Phoenix.smethod_5(1, 2000) == 2000)
			{
				uint_ = 5u;
			}
			else
			{
				if (Phoenix.smethod_5(1, 200) == 200)
				{
					uint_ = 4u;
				}
				else
				{
					if (Phoenix.smethod_5(1, 40) == 40)
					{
						uint_ = 3u;
					}
					else
					{
						if (Phoenix.smethod_5(1, 4) == 4)
						{
							uint_ = 2u;
						}
					}
				}
			}
			List<Class47> list = this.method_16(uint_);
			Class47 result;
			if (list != null && list.Count >= 1)
			{
				result = list[Phoenix.smethod_5(0, list.Count - 1)];
			}
			else
			{
				result = new Class47(0u, 0u, 1479u, 0u);
			}
			return result;
		}
		public List<Class47> method_16(uint uint_1)
		{
			List<Class47> list = new List<Class47>();
			foreach (Class47 current in this.list_0)
			{
				if (current.uint_3 == uint_1)
				{
					list.Add(current);
				}
			}
			return list;
		}
		public GClass5 method_17(int int_0)
		{
			GClass5 gClass = new GClass5(126u);
			gClass.method_13(true);
			gClass.method_9(0);
			gClass.method_9(0);
			gClass.method_9(-1);
			gClass.method_7("");
			gClass.method_9(this.method_4(int_0, -1));
			gClass.method_13(true);
			foreach (Class48 current in this.dictionary_0.Values)
			{
				if (current.int_1 == -1)
				{
					current.method_2(int_0, gClass);
					foreach (Class48 current2 in this.dictionary_0.Values)
					{
						if (current2.int_1 == current.Int32_0)
						{
							current2.method_2(int_0, gClass);
						}
					}
				}
			}
			return gClass;
		}
		internal GClass5 method_18(uint uint_1)
		{
			if (uint_1 < 1u)
			{
				uint_1 = 1u;
			}
			if ((ulong)uint_1 > (ulong)((long)Phoenix.smethod_15().method_4().dictionary_2.Count))
			{
				uint_1 = (uint)Phoenix.smethod_15().method_4().dictionary_2.Count;
			}
			return this.gclass5_0[(int)((UIntPtr)uint_1)];
		}
		public GClass5 method_19(Class48 class48_0)
		{
			GClass5 gClass = new GClass5(127u);
			gClass.method_9(class48_0.Int32_0);
			string string_ = class48_0.string_1;
			switch (string_)
			{
			case "frontpage":
				gClass.method_7("frontpage3");
				gClass.method_9(3);
				gClass.method_7(class48_0.string_2);
				gClass.method_7(class48_0.string_3);
				gClass.method_7("");
				gClass.method_9(11);
				gClass.method_7(class48_0.string_5);
				gClass.method_7(class48_0.string_9);
				gClass.method_7(class48_0.string_6);
				gClass.method_7(class48_0.string_7);
				gClass.method_7(class48_0.string_10);
				gClass.method_7("#FAF8CC");
				gClass.method_7("#FAF8CC");
				gClass.method_7("Read More >");
				gClass.method_7("magic.credits");
				goto IL_47F;
			case "recycler_info":
				gClass.method_7(class48_0.string_1);
				gClass.method_9(2);
				gClass.method_7(class48_0.string_2);
				gClass.method_7(class48_0.string_3);
				gClass.method_9(3);
				gClass.method_7(class48_0.string_5);
				gClass.method_7(class48_0.string_6);
				gClass.method_7(class48_0.string_7);
				goto IL_47F;
			case "recycler_prizes":
				gClass.method_7("recycler_prizes");
				gClass.method_9(1);
				gClass.method_7("catalog_recycler_headline3");
				gClass.method_9(1);
				gClass.method_7(class48_0.string_5);
				goto IL_47F;
			case "spaces":
				gClass.method_7("spaces_new");
				gClass.method_9(1);
				gClass.method_7(class48_0.string_2);
				gClass.method_9(1);
				gClass.method_7(class48_0.string_5);
				goto IL_47F;
			case "recycler":
				gClass.method_7(class48_0.string_1);
				gClass.method_9(2);
				gClass.method_7(class48_0.string_2);
				gClass.method_7(class48_0.string_3);
				gClass.method_9(1);
				gClass.method_8(class48_0.string_5, 10);
				gClass.method_7(class48_0.string_6);
				gClass.method_7(class48_0.string_7);
				goto IL_47F;
			case "trophies":
				gClass.method_7("trophies");
				gClass.method_9(1);
				gClass.method_7(class48_0.string_2);
				gClass.method_9(2);
				gClass.method_7(class48_0.string_5);
				gClass.method_7(class48_0.string_7);
				goto IL_47F;
			case "pets":
				gClass.method_7("pets");
				gClass.method_9(2);
				gClass.method_7(class48_0.string_2);
				gClass.method_7(class48_0.string_3);
				gClass.method_9(4);
				gClass.method_7(class48_0.string_5);
				gClass.method_7("");
				gClass.method_7("Pick a color:");
				gClass.method_7("Pick a race:");
				goto IL_47F;
			case "club_buy":
				gClass.method_7("club_buy");
				gClass.method_9(1);
				gClass.method_7("habboclub_2");
				gClass.method_9(1);
				goto IL_47F;
			case "club_gifts":
				gClass.method_7("club_gifts");
				gClass.method_9(1);
				gClass.method_7("habboclub_2");
				gClass.method_9(1);
				gClass.method_7("");
				gClass.method_9(1);
				goto IL_47F;
			case "soundmachine":
				gClass.method_7(class48_0.string_1);
				gClass.method_9(2);
				gClass.method_7(class48_0.string_2);
				gClass.method_7(class48_0.string_3);
				gClass.method_9(2);
				gClass.method_7(class48_0.string_5);
				gClass.method_7(class48_0.string_7);
				goto IL_47F;
			}
			gClass.method_7(class48_0.string_1);
			gClass.method_9(3);
			gClass.method_7(class48_0.string_2);
			gClass.method_7(class48_0.string_3);
			gClass.method_7(class48_0.string_4);
			gClass.method_9(3);
			gClass.method_7(class48_0.string_5);
			gClass.method_7(class48_0.string_7);
			gClass.method_7(class48_0.string_8);
			IL_47F:
			gClass.method_9(class48_0.list_0.Count);
			foreach (Class49 current in class48_0.list_0)
			{
				current.method_1(gClass);
			}
			return gClass;
		}
		public GClass5 method_20()
		{
			return new GClass5(625u);
		}
		public Class46 method_21()
		{
			return this.class46_0;
		}
		public Class43 method_22()
		{
			return this.class43_0;
		}
	}
}
