using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Text;
namespace ns0
{
	internal sealed class Class323
	{
		private Socket socket_0;
		private byte[] byte_0 = new byte[1024];
		public Class323(Socket socket_1)
		{
			this.socket_0 = socket_1;
			try
			{
				this.socket_0.BeginReceive(this.byte_0, 0, this.byte_0.Length, SocketFlags.None, new AsyncCallback(this.method_1), this.socket_0);
			}
			catch
			{
				this.method_0();
			}
		}
		public void method_0()
		{
			try
			{
				this.socket_0.Shutdown(SocketShutdown.Both);
				this.socket_0.Close();
				this.socket_0.Dispose();
			}
			catch
			{
			}
		}
		public void method_1(IAsyncResult iasyncResult_0)
		{
			try
			{
				int count = 0;
				try
				{
					count = this.socket_0.EndReceive(iasyncResult_0);
				}
				catch
				{
					this.method_0();
					return;
				}
				string @string = Encoding.Default.GetString(this.byte_0, 0, count);
				if (@string.Length > 0)
				{
					this.method_2(@string);
				}
			}
			catch
			{
			}
			this.method_0();
		}
		public void method_2(string string_0)
		{
			string text = string_0.Split(new char[]
			{
				Convert.ToChar(1)
			})[0];
			string text2 = string_0.Split(new char[]
			{
				Convert.ToChar(1)
			})[1];
			Class16 @class = null;
			DataRow dataRow = null;
			string text3 = text.ToLower();
			if (text3 != null)
			{
				if (Class23.dictionary_0 == null)
				{
					Class23.dictionary_0 = new Dictionary<string, int>(29)
					{

						{
							"update_items",
							0
						},

						{
							"update_catalogue",
							1
						},

						{
							"update_catalog",
							2
						},

						{
							"updateusersrooms",
							3
						},

						{
							"senduser",
							4
						},

						{
							"updatevip",
							5
						},

						{
							"giftitem",
							6
						},

						{
							"giveitem",
							7
						},

						{
							"unloadroom",
							8
						},

						{
							"roomalert",
							9
						},

						{
							"updategroup",
							10
						},

						{
							"updateusersgroups",
							11
						},

						{
							"shutdown",
							12
						},

						{
							"update_filter",
							13
						},

						{
							"refresh_filter",
							14
						},

						{
							"updatecredits",
							15
						},

						{
							"updatesettings",
							16
						},

						{
							"updatepixels",
							17
						},

						{
							"updatepoints",
							18
						},

						{
							"reloadbans",
							19
						},

						{
							"update_bots",
							20
						},

						{
							"signout",
							21
						},

						{
							"exe",
							22
						},

						{
							"alert",
							23
						},

						{
							"sa",
							24
						},

						{
							"ha",
							25
						},

						{
							"hal",
							26
						},

						{
							"updatemotto",
							27
						},

						{
							"updatelook",
							28
						}
					};
				}
				int num;
				if (Class23.dictionary_0.TryGetValue(text3, out num))
				{
					uint num2;
					uint uint_2;
					Class14 class4;
					uint num3;
					string text5;
					switch (num)
					{
					case 0:
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							Phoenix.smethod_15().method_8().method_0(class2);
							goto IL_C70;
						}
						break;
					case 1:
					case 2:
						break;
					case 3:
					{
						Class11 class3 = Phoenix.smethod_15().method_2().method_2(Convert.ToUInt32(text2)).method_2();
						if (class3 != null)
						{
							using (Class6 class2 = Phoenix.smethod_12().method_0())
							{
								class3.method_1(class2);
								goto IL_C70;
							}
							goto IL_34E;
						}
						goto IL_C70;
					}
					case 4:
						goto IL_34E;
					case 5:
					{
						Class11 class3 = Phoenix.smethod_15().method_2().method_2(Convert.ToUInt32(text2)).method_2();
						if (class3 != null)
						{
							class3.method_27();
							goto IL_C70;
						}
						goto IL_C70;
					}
					case 6:
					case 7:
					{
						num2 = uint.Parse(text2.Split(new char[]
						{
							' '
						})[0]);
						uint uint_ = uint.Parse(text2.Split(new char[]
						{
							' '
						})[1]);
						int int_ = int.Parse(text2.Split(new char[]
						{
							' '
						})[2]);
						string string_ = text2.Substring(num2.ToString().Length + uint_.ToString().Length + int_.ToString().Length + 3);
						Phoenix.smethod_15().method_6().method_7(string_, num2, uint_, int_);
						goto IL_C70;
					}
					case 8:
						uint_2 = uint.Parse(text2);
						class4 = Phoenix.smethod_15().method_9().method_19(uint_2);
						Phoenix.smethod_15().method_9().method_16(class4);
						goto IL_C70;
					case 9:
						num3 = uint.Parse(text2.Split(new char[]
						{
							' '
						})[0]);
						class4 = Phoenix.smethod_15().method_9().method_19(num3);
						if (class4 != null)
						{
							string string_2 = text2.Substring(num3.ToString().Length + 1);
							for (int i = 0; i < class4.class33_0.Length; i++)
							{
								Class33 class5 = class4.class33_0[i];
								if (class5 != null)
								{
									class5.method_16().method_8(string_2);
								}
							}
							goto IL_C70;
						}
						goto IL_C70;
					case 10:
					{
						int int_2 = int.Parse(text2.Split(new char[]
						{
							' '
						})[0]);
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							Class4.smethod_3(class2, int_2);
							goto IL_C70;
						}
						goto IL_5BF;
					}
					case 11:
						goto IL_5BF;
					case 12:
						goto IL_602;
					case 13:
					case 14:
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							Class58.smethod_1(class2);
							goto IL_C70;
						}
						goto IL_633;
					case 15:
						goto IL_633;
					case 16:
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							Phoenix.smethod_15().method_17(class2);
							goto IL_C70;
						}
						goto IL_6F7;
					case 17:
						goto IL_6F7;
					case 18:
						@class = Phoenix.smethod_15().method_2().method_2(uint.Parse(text2));
						if (@class != null)
						{
							@class.method_2().method_14(true, false);
							goto IL_C70;
						}
						goto IL_C70;
					case 19:
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							Phoenix.smethod_15().method_3().method_0(class2);
						}
						Phoenix.smethod_15().method_2().method_28();
						goto IL_C70;
					case 20:
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							Phoenix.smethod_15().method_14().method_0(class2);
							goto IL_C70;
						}
						goto IL_839;
					case 21:
						goto IL_839;
					case 22:
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							class2.method_1(text2);
							goto IL_C70;
						}
						goto IL_880;
					case 23:
						goto IL_880;
					case 24:
					{
						GClass5 gClass = new GClass5(134u);
						gClass.method_11(0u);
						gClass.method_6("PHX: " + text2);
						Phoenix.smethod_15().method_2().method_16(gClass, gClass);
						goto IL_C70;
					}
					case 25:
					{
						GClass5 gClass2 = new GClass5(808u);
						gClass2.method_7(Class8.smethod_1("mus_ha_title"));
						gClass2.method_7(text2);
						GClass5 gClass3 = new GClass5(161u);
						gClass3.method_7(text2);
						Phoenix.smethod_15().method_2().method_15(gClass2, gClass3);
						goto IL_C70;
					}
					case 26:
					{
						string text4 = text2.Split(new char[]
						{
							' '
						})[0];
						text5 = text2.Substring(text4.Length + 1);
						GClass5 gClass4 = new GClass5(161u);
						gClass4.method_7(string.Concat(new string[]
						{
							Class8.smethod_1("mus_hal_title"),
							"\r\n",
							text5,
							"\r\n-",
							Class8.smethod_1("mus_hal_tail")
						}));
						gClass4.method_7(text4);
						Phoenix.smethod_15().method_2().method_14(gClass4);
						goto IL_C70;
					}
					case 27:
					case 28:
					{
						uint_2 = uint.Parse(text2);
						@class = Phoenix.smethod_15().method_2().method_2(uint_2);
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							dataRow = class2.method_4("SELECT look,gender,motto,mutant_penalty,block_newfriends FROM users WHERE id = '" + @class.method_2().uint_0 + "' LIMIT 1");
						}
						@class.method_2().string_5 = (string)dataRow["look"];
						@class.method_2().string_6 = dataRow["gender"].ToString().ToLower();
						@class.method_2().string_4 = Phoenix.smethod_7((string)dataRow["motto"]);
						@class.method_2().bool_11 = Phoenix.smethod_3(dataRow["block_newfriends"].ToString());
						GClass5 gClass5 = new GClass5(266u);
						gClass5.method_9(-1);
						gClass5.method_7(@class.method_2().string_5);
						gClass5.method_7(@class.method_2().string_6.ToLower());
						gClass5.method_7(@class.method_2().string_4);
						@class.method_14(gClass5);
						if (@class.method_2().Boolean_0)
						{
							class4 = Phoenix.smethod_15().method_9().method_19(@class.method_2().uint_3);
							Class33 class6 = class4.method_53(@class.method_2().uint_0);
							GClass5 gClass6 = new GClass5(266u);
							gClass6.method_9(class6.int_0);
							gClass6.method_7(@class.method_2().string_5);
							gClass6.method_7(@class.method_2().string_6.ToLower());
							gClass6.method_7(@class.method_2().string_4);
							gClass6.method_9(@class.method_2().int_13);
							gClass6.method_7("");
							class4.method_59(gClass6, null);
						}
						text3 = text.ToLower();
						if (text3 == null)
						{
							goto IL_C70;
						}
						if (text3 == "updatemotto")
						{
							Phoenix.smethod_15().method_12().method_3(@class, 5u, 1);
							goto IL_C70;
						}
						if (text3 == "updatelook")
						{
							Phoenix.smethod_15().method_12().method_3(@class, 1u, 1);
							goto IL_C70;
						}
						goto IL_C70;
					}
					default:
						goto IL_C70;
					}
					using (Class6 class2 = Phoenix.smethod_12().method_0())
					{
						Phoenix.smethod_15().method_6().method_0(class2);
					}
					Phoenix.smethod_15().method_6().method_1();
					Phoenix.smethod_15().method_2().method_14(new GClass5(441u));
					goto IL_C70;
					IL_34E:
					num2 = uint.Parse(text2.Split(new char[]
					{
						' '
					})[0]);
					num3 = uint.Parse(text2.Split(new char[]
					{
						' '
					})[1]);
					Class16 class7 = Phoenix.smethod_15().method_2().method_2(num2);
					class4 = Phoenix.smethod_15().method_9().method_19(num3);
					if (class7 != null)
					{
						GClass5 gClass7 = new GClass5(286u);
						gClass7.method_13(class4.Boolean_3);
						gClass7.method_11(num3);
						class7.method_14(gClass7);
						goto IL_C70;
					}
					goto IL_C70;
					IL_5BF:
					uint_2 = uint.Parse(text2);
					using (Class6 class2 = Phoenix.smethod_12().method_0())
					{
						Phoenix.smethod_15().method_2().method_2(uint_2).method_2().method_0(class2);
						goto IL_C70;
					}
					IL_602:
					Phoenix.smethod_18();
					goto IL_C70;
					IL_633:
					@class = Phoenix.smethod_15().method_2().method_2(uint.Parse(text2));
					if (@class != null)
					{
						int int_3 = 0;
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							int_3 = (int)class2.method_4("SELECT credits FROM users WHERE id = '" + @class.method_2().uint_0 + "' LIMIT 1")[0];
						}
						@class.method_2().int_2 = int_3;
						@class.method_2().method_13(false);
						goto IL_C70;
					}
					goto IL_C70;
					IL_6F7:
					@class = Phoenix.smethod_15().method_2().method_2(uint.Parse(text2));
					if (@class != null)
					{
						int int_4 = 0;
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							int_4 = (int)class2.method_4("SELECT activity_points FROM users WHERE id = '" + @class.method_2().uint_0 + "' LIMIT 1")[0];
						}
						@class.method_2().int_3 = int_4;
						@class.method_2().method_15(false);
						goto IL_C70;
					}
					goto IL_C70;
					IL_839:
					Phoenix.smethod_15().method_2().method_2(uint.Parse(text2)).method_12();
					goto IL_C70;
					IL_880:
					string text6 = text2.Split(new char[]
					{
						' '
					})[0];
					text5 = text2.Substring(text6.Length + 1);
					GClass5 gClass8 = new GClass5(808u);
					gClass8.method_7(Class8.smethod_1("mus_alert_title"));
					gClass8.method_7(text5);
					Phoenix.smethod_15().method_2().method_2(uint.Parse(text6)).method_14(gClass8);
				}
			}
			IL_C70:
			GClass5 gClass9 = new GClass5(1u);
			gClass9.method_6("Hello Housekeeping, Love from Phoenix Emu");
			this.socket_0.Send(gClass9.method_14());
		}
	}
}
