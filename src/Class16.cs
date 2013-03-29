using System;
using System.Data;
using System.Text.RegularExpressions;
namespace ns0
{
	internal sealed class Class16
	{
		private uint uint_0;
		private GClass1 gclass1_0;
		private Class17 class17_0;
		private Class11 class11_0;
		public bool bool_0;
		internal bool bool_1 = false;
		private bool bool_2 = false;
		public uint UInt32_0
		{
			get
			{
				return this.uint_0;
			}
		}
		public bool Boolean_0
		{
			get
			{
				return this.class11_0 != null;
			}
		}
		public Class16(uint uint_1, ref GClass1 gclass1_1)
		{
			this.uint_0 = uint_1;
			this.gclass1_0 = gclass1_1;
		}
		public GClass1 method_0()
		{
			return this.gclass1_0;
		}
		public Class17 method_1()
		{
			return this.class17_0;
		}
		public Class11 method_2()
		{
			return this.class11_0;
		}
		public void method_3()
		{
			if (this.gclass1_0 != null)
			{
				this.bool_0 = true;
				GClass1.GDelegate0 gdelegate0_ = new GClass1.GDelegate0(this.method_13);
				this.gclass1_0.method_0(gdelegate0_);
			}
		}
		internal void method_4()
		{
			this.class17_0 = new Class17(this);
		}
		internal GClass5 method_5()
		{
			return Phoenix.smethod_15().method_7().method_12(this, -3);
		}
		internal void method_6(string string_0)
		{
			try
			{
				Class12 @class = new Class12(string_0, this.method_0().String_0, true);
				if (this.method_0().String_0 == "127.0.0.1" && !@class.Boolean_0)
				{
					@class = new Class12(string_0, "::1", true);
				}
				if (!@class.Boolean_0)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					string str = "";
					if (Class13.Boolean_2)
					{
						str = Class8.smethod_1("emu_sso_wrong_secure") + "(" + this.method_0().String_0 + ")";
					}
					GClass5 gClass = new GClass5(161u);
					gClass.method_7(Class8.smethod_1("emu_sso_wrong") + str);
					this.method_0().method_5(gClass);
					Console.ForegroundColor = ConsoleColor.Gray;
					this.method_12();
					return;
				}
				Class11 class2 = Class59.smethod_0(string_0, this, @class, @class);
				Phoenix.smethod_15().method_2().method_25(class2.uint_0);
				this.class11_0 = class2;
				this.class11_0.method_2(@class);
				string a;
				using (Class6 class3 = Phoenix.smethod_12().method_0())
				{
					a = class3.method_5("SELECT ip_last FROM users WHERE id = " + this.method_2().uint_0 + " LIMIT 1;");
				}
				this.class11_0.bool_0 = (this.method_0().String_0 == Phoenix.string_5 || a == Phoenix.string_5);
				if (this.class11_0.bool_0)
				{
					this.class11_0.uint_1 = (uint)Phoenix.smethod_15().method_4().method_9();
					this.class11_0.bool_14 = true;
				}
			}
			catch (Exception ex)
			{
				this.method_8("Login error: " + ex.Message);
				GClass4.smethod_2(ex.ToString());
				this.method_12();
				return;
			}
			try
			{
				Phoenix.smethod_15().method_3().method_1(this);
			}
			catch (GException1 gException)
			{
				this.method_7(gException.Message);
				this.method_12();
				return;
			}
			GClass5 gClass2 = new GClass5(2u);
			if (this.method_2().bool_14 || Class13.Boolean_3)
			{
				gClass2.method_9(2);
			}
			else
			{
				if (this.method_2().method_20().method_2("habbo_club"))
				{
					gClass2.method_9(1);
				}
				else
				{
					gClass2.method_9(0);
				}
			}
			if (this.method_2().method_3("acc_anyroomowner"))
			{
				gClass2.method_9(7);
			}
			else
			{
				if (this.method_2().method_3("acc_anyroomrights"))
				{
					gClass2.method_9(5);
				}
				else
				{
					if (this.method_2().method_3("acc_supporttool"))
					{
						gClass2.method_9(4);
					}
					else
					{
						if (this.method_2().bool_14 || Class13.Boolean_3 || this.method_2().method_20().method_2("habbo_club"))
						{
							gClass2.method_9(2);
						}
						else
						{
							gClass2.method_9(0);
						}
					}
				}
			}
			this.method_14(gClass2);

            this.method_14(this.method_2().method_24().method_6());

			GClass5 gClass3 = new GClass5(290u);
			gClass3.method_13(true);
			gClass3.method_13(false);
			this.method_14(gClass3);

			GClass5 gclass5_ = new GClass5(3u);
			this.method_14(gclass5_);

            if (this.method_2().method_3("acc_supporttool"))
            {
                this.method_2().bool_0 = true;
                this.method_2().bool_14 = true;
                this.method_2().uint_1 = (uint)Phoenix.smethod_15().method_4().method_9();

                this.method_14(Phoenix.smethod_15().method_13().method_0());
                Phoenix.smethod_15().method_13().method_4(this);
            }
			

			GClass5 gClass4 = new GClass5(517u);
			gClass4.method_13(true);
			this.method_14(gClass4);
			if (Phoenix.smethod_15().method_11().method_2(this))
			{
				Phoenix.smethod_15().method_11().method_3(this);
			}
			GClass5 gClass5 = new GClass5(455u);
			gClass5.method_11(this.method_2().uint_4);
			this.method_14(gClass5);
			GClass5 gClass6 = new GClass5(458u);
			gClass6.method_9(30);
			gClass6.method_9(this.method_2().list_1.Count);
			foreach (uint current in this.method_2().list_1)
			{
				gClass6.method_11(current);
			}
			this.method_14(gClass6);
			if (this.method_2().int_15 > 8294400)
			{
				Phoenix.smethod_15().method_12().method_3(this, 16u, 10);
			}
			else
			{
				if (this.method_2().int_15 > 4147200)
				{
					Phoenix.smethod_15().method_12().method_3(this, 16u, 9);
				}
				else
				{
					if (this.method_2().int_15 > 2073600)
					{
						Phoenix.smethod_15().method_12().method_3(this, 16u, 8);
					}
					else
					{
						if (this.method_2().int_15 > 1036800)
						{
							Phoenix.smethod_15().method_12().method_3(this, 16u, 7);
						}
						else
						{
							if (this.method_2().int_15 > 518400)
							{
								Phoenix.smethod_15().method_12().method_3(this, 16u, 6);
							}
							else
							{
								if (this.method_2().int_15 > 172800)
								{
									Phoenix.smethod_15().method_12().method_3(this, 16u, 5);
								}
								else
								{
									if (this.method_2().int_15 > 57600)
									{
										Phoenix.smethod_15().method_12().method_3(this, 16u, 4);
									}
									else
									{
										if (this.method_2().int_15 > 28800)
										{
											Phoenix.smethod_15().method_12().method_3(this, 16u, 3);
										}
										else
										{
											if (this.method_2().int_15 > 10800)
											{
												Phoenix.smethod_15().method_12().method_3(this, 16u, 2);
											}
											else
											{
												if (this.method_2().int_15 > 3600)
												{
													Phoenix.smethod_15().method_12().method_3(this, 16u, 1);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (Class13.String_4 != "")
			{
				this.method_9(Class13.String_4, 2);
			}
			for (uint num = (uint)Phoenix.smethod_15().method_4().method_9(); num > 1u; num -= 1u)
			{
				if (Phoenix.smethod_15().method_4().method_8(num).Length > 0)
				{
					if (!this.method_2().method_22().method_1(Phoenix.smethod_15().method_4().method_8(num)) && this.method_2().uint_1 == num)
					{
						this.method_2().method_22().method_2(this, Phoenix.smethod_15().method_4().method_8(num), true);
					}
					else
					{
						if (this.method_2().method_22().method_1(Phoenix.smethod_15().method_4().method_8(num)) && this.method_2().uint_1 < num)
						{
							this.method_2().method_22().method_6(Phoenix.smethod_15().method_4().method_8(num));
						}
					}
				}
			}
			if (this.method_2().method_20().method_2("habbo_club") && !this.method_2().method_22().method_1("HC1"))
			{
				this.method_2().method_22().method_2(this, "HC1", true);
			}
			else
			{
				if (!this.method_2().method_20().method_2("habbo_club") && this.method_2().method_22().method_1("HC1"))
				{
					this.method_2().method_22().method_6("HC1");
				}
			}
			if (this.method_2().bool_14 && !this.method_2().method_22().method_1("VIP"))
			{
				this.method_2().method_22().method_2(this, "VIP", true);
			}
			else
			{
				if (!this.method_2().bool_14 && this.method_2().method_22().method_1("VIP"))
				{
					this.method_2().method_22().method_6("VIP");
				}
			}
			if (this.method_2().uint_6 > 0u)
			{
				Phoenix.smethod_15().method_16().method_7(this.method_2().uint_6, this);
			}
			if (!Regex.IsMatch(this.method_2().string_0, "^[-a-zA-Z0-9._:,]+$"))
			{
				GClass5 gclass5_2 = new GClass5(573u);
				this.method_14(gclass5_2);
			}
			this.method_2().string_4 = Phoenix.smethod_7(this.method_2().string_4);
			DataTable dataTable = null;
			using (Class6 class3 = Phoenix.smethod_12().method_0())
			{
				dataTable = class3.method_3("SELECT achievement,achlevel FROM achievements_owed WHERE user = '" + this.method_2().uint_0 + "'");
			}
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					Phoenix.smethod_15().method_12().method_3(this, (uint)dataRow["achievement"], (int)dataRow["achlevel"]);
					using (Class6 class3 = Phoenix.smethod_12().method_0())
					{
						class3.method_1(string.Concat(new object[]
						{
							"DELETE FROM achievements_owed WHERE achievement = '",
							(uint)dataRow["achievement"],
							"' AND user = '",
							this.method_2().uint_0,
							"' LIMIT 1"
						}));
					}
				}
			}
		}
		public void method_7(string string_0)
		{
			GClass5 gClass = new GClass5(35u);
			gClass.method_8("A moderator has kicked you from the hotel:", 13);
			gClass.method_7(string_0);
			this.method_14(gClass);
		}
		public void method_8(string string_0)
		{
			this.method_9(string_0, 0);
		}
		public void method_9(string string_0, int int_0)
		{
			GClass5 gClass = new GClass5();
			switch (int_0)
			{
			case 0:
				gClass.method_2(161u);
				break;
			case 1:
				gClass.method_2(139u);
				break;
			case 2:
				gClass.method_2(810u);
				gClass.method_11(1u);
				break;
			default:
				gClass.method_2(161u);
				break;
			}
			gClass.method_7(string_0);
			this.method_0().method_5(gClass);
		}
		public void method_10(string string_0, string string_1)
		{
			GClass5 gClass = new GClass5(161u);
			gClass.method_7(string_0);
			gClass.method_7(string_1);
			this.method_0().method_5(gClass);
		}
		public void method_11()
		{
			if (this.gclass1_0 != null)
			{
				this.gclass1_0.Dispose();
				this.gclass1_0 = null;
			}
			if (this.method_2() != null)
			{
				this.class11_0.method_9();
				this.class11_0 = null;
			}
			if (this.method_1() != null)
			{
				this.class17_0.method_1();
				this.class17_0 = null;
			}
		}
		public void method_12()
		{
			if (!this.bool_2)
			{
				Phoenix.smethod_15().method_2().method_9(this.uint_0);
				this.bool_2 = true;
			}
		}
		public void method_13(ref byte[] byte_0)
		{
			if (byte_0[0] == 64)
			{
				int i = 0;
				while (i < byte_0.Length)
				{
					try
					{
						int num = GClass6.smethod_2(new byte[]
						{
							byte_0[i++],
							byte_0[i++],
							byte_0[i++]
						});
						uint uint_ = GClass6.smethod_3(new byte[]
						{
							byte_0[i++],
							byte_0[i++]
						});
						byte[] array = new byte[num - 2];
						for (int j = 0; j < array.Length; j++)
						{
							array[j] = byte_0[i++];
						}
						if (this.class17_0 == null)
						{
							this.method_4();
						}
						Class18 @class = new Class18(uint_, array);
						if (@class != null)
						{
							try
							{
								if (int.Parse(Phoenix.smethod_11().dictionary_0["debug"]) == 1)
								{
									GClass4.smethod_1(string.Concat(new object[]
									{
										"[",
										this.UInt32_0,
										"] --> [",
										@class.UInt32_0,
										"] ",
										@class.String_0,
										@class.method_2()
									}));
								}
							}
							catch
							{
							}
							Interface0 @interface;
							if (Phoenix.smethod_10().method_0(@class.UInt32_0, out @interface))
							{
								@interface.imethod_0(this, @class);
							}
						}
					}
					catch (Exception ex)
					{
						GClass4.smethod_2("Error: " + ex.ToString());
						this.method_12();
					}
				}
			}
			else
			{
				if (true)//Class13.Boolean_7)
				{
					this.gclass1_0.method_4(Class116.smethod_0());
					this.gclass1_0.Dispose();
				}
			}
		}
		public void method_14(GClass5 gclass5_0)
		{
			if (gclass5_0 != null && this.method_0() != null)
			{
				this.method_0().method_5(gclass5_0);
			}
		}
	}
}
