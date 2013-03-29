using System;
using System.Data;
using System.Text.RegularExpressions;
namespace ns0
{
	internal sealed class Class17
	{
		private delegate void Delegate1();
		private const int int_0 = 4004;
		private Class16 class16_0;
		private Class18 class18_0;
		private GClass5 gclass5_0;
		private Class17.Delegate1[] delegate1_0;
		public Class17(Class16 class16_1)
		{
			this.class16_0 = class16_1;
			this.delegate1_0 = new Class17.Delegate1[4004];
			this.gclass5_0 = new GClass5(0u);
		}
		public GClass5 method_0()
		{
			return this.gclass5_0;
		}
		public void method_1()
		{
			this.class16_0 = null;
			this.delegate1_0 = null;
			this.class18_0 = null;
			this.gclass5_0 = null;
		}
		public void method_2(Class18 class18_1)
		{
			uint arg_06_0 = class18_1.UInt32_0;
			if (class18_1.UInt32_0 > 4004u)
			{
				GClass4.smethod_1("Warning - out of protocol request: " + class18_1.String_0);
			}
			else
			{
				if (this.delegate1_0[(int)((UIntPtr)class18_1.UInt32_0)] != null && class18_1 != null)
				{
					this.class18_0 = class18_1;
					this.delegate1_0[(int)((UIntPtr)class18_1.UInt32_0)]();
					this.class18_0 = null;
				}
			}
		}
		public void method_3()
		{
			if (this.gclass5_0 != null && this.gclass5_0.UInt32_0 > 0u && this.class16_0.method_0() != null)
			{
				this.class16_0.method_0().method_5(this.gclass5_0);
			}
		}
		public void method_4()
		{
			Class19 @class = Phoenix.smethod_15().method_10().method_1();
			this.gclass5_0.method_2(258u);
			if (@class == null)
			{
				this.gclass5_0.method_7("");
				this.gclass5_0.method_7("");
			}
			else
			{
				this.gclass5_0.method_7(@class.string_0);
				this.gclass5_0.method_7(@class.string_1);
				@class.method_0();
			}
			this.method_3();
		}
		public void method_5(uint uint_0, string string_0)
		{
			this.method_7();
			if (Phoenix.smethod_15().method_9().method_12(uint_0) != null)
			{
				if (this.class16_0.method_2().Boolean_0)
				{
					Class14 @class = Phoenix.smethod_15().method_9().method_19(this.class16_0.method_2().uint_3);
					if (@class != null)
					{
						@class.method_47(this.class16_0, false, false);
					}
				}
				Class14 class2 = Phoenix.smethod_15().method_9().method_15(uint_0);
				if (class2 != null)
				{
					this.class16_0.method_2().uint_2 = uint_0;
					if (class2.method_68(this.class16_0.method_2().uint_0))
					{
						if (!class2.method_71(this.class16_0.method_2().uint_0))
						{
							GClass5 gClass = new GClass5(224u);
							gClass.method_9(4);
							this.class16_0.method_14(gClass);
							GClass5 gClass2 = new GClass5(18u);
							this.class16_0.method_14(gClass2);
							return;
						}
						class2.method_69(this.class16_0.method_2().uint_0);
					}
					if (class2.int_2 >= class2.int_3 && !Phoenix.smethod_15().method_4().method_1(this.class16_0.method_2().uint_1, "acc_enter_fullrooms") && !this.class16_0.method_2().bool_14)
					{
						GClass5 gClass = new GClass5(224u);
						gClass.method_9(1);
						this.class16_0.method_14(gClass);
						GClass5 gClass2 = new GClass5(18u);
						this.class16_0.method_14(gClass2);
					}
					else
					{
						if (class2.string_2 == "public")
						{
							if (class2.int_1 > 0 && !this.class16_0.method_2().method_3("acc_restrictedrooms"))
							{
								this.class16_0.method_8("This public room is accessible to Phoenix staff only.");
								GClass5 gClass2 = new GClass5(18u);
								this.class16_0.method_14(gClass2);
								return;
							}
							GClass5 gClass3 = new GClass5(166u);
							gClass3.method_7("/client/public/" + class2.string_5 + "/0");
							this.class16_0.method_14(gClass3);
						}
						else
						{
							if (class2.string_2 == "private")
							{
								GClass5 gClass4 = new GClass5(19u);
								this.class16_0.method_14(gClass4);
								if (this.class16_0.method_2().bool_7)
								{
									Class63 class3 = class2.method_28(this.class16_0.method_2().uint_5);
									if (class3 == null)
									{
										this.class16_0.method_2().bool_7 = false;
										this.class16_0.method_2().uint_5 = 0u;
										GClass5 gClass5 = new GClass5(131u);
										this.class16_0.method_14(gClass5);
										return;
									}
								}
								if (!this.class16_0.method_2().method_3("acc_enter_anyroom") && !class2.method_27(this.class16_0, true) && !this.class16_0.method_2().bool_7)
								{
									if (class2.int_1 == 1)
									{
										if (class2.Int32_0 == 0)
										{
											GClass5 gClass5 = new GClass5(131u);
											this.class16_0.method_14(gClass5);
											return;
										}
										GClass5 gClass6 = new GClass5(91u);
										gClass6.method_7("");
										this.class16_0.method_14(gClass6);
										this.class16_0.method_2().bool_6 = true;
										GClass5 gClass7 = new GClass5(91u);
										gClass7.method_7(this.class16_0.method_2().string_0);
										class2.method_61(gClass7);
										return;
									}
									else
									{
										if (class2.int_1 == 2 && string_0.ToLower() != class2.string_4.ToLower())
										{
											GClass5 gClass8 = new GClass5(33u);
											gClass8.method_9(-100002);
											this.class16_0.method_14(gClass8);
											GClass5 gClass2 = new GClass5(18u);
											this.class16_0.method_14(gClass2);
											return;
										}
									}
								}
								GClass5 gClass3 = new GClass5(166u);
								gClass3.method_7("/client/private/" + class2.UInt32_0 + "/id");
								this.class16_0.method_14(gClass3);
							}
						}
						this.class16_0.method_2().bool_5 = true;
						this.method_6();
					}
				}
			}
		}
		public void method_6()
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(this.class16_0.method_2().uint_2);
			if (@class != null && this.class16_0.method_2().bool_5)
			{
				GClass5 gClass = new GClass5(69u);
				gClass.method_7(@class.string_5);
				gClass.method_11(@class.UInt32_0);
				this.class16_0.method_14(gClass);
				if (this.class16_0.method_2().bool_8)
				{
					GClass5 gClass2 = new GClass5(254u);
					this.class16_0.method_14(gClass2);
				}
				if (@class.string_2 == "private")
				{
					if (@class.string_7 != "0.0")
					{
						GClass5 gClass3 = new GClass5(46u);
						gClass3.method_7("wallpaper");
						gClass3.method_7(@class.string_7);
						this.class16_0.method_14(gClass3);
					}
					if (@class.string_8 != "0.0")
					{
						GClass5 gClass4 = new GClass5(46u);
						gClass4.method_7("floor");
						gClass4.method_7(@class.string_8);
						this.class16_0.method_14(gClass4);
					}
					GClass5 gClass5 = new GClass5(46u);
					gClass5.method_7("landscape");
					gClass5.method_7(@class.string_9);
					this.class16_0.method_14(gClass5);
					if (@class.method_27(this.class16_0, true))
					{
						GClass5 gClass6 = new GClass5(42u);
						this.class16_0.method_14(gClass6);
						GClass5 gClass7 = new GClass5(47u);
						this.class16_0.method_14(gClass7);
					}
					else
					{
						if (@class.method_26(this.class16_0))
						{
							GClass5 gClass6 = new GClass5(42u);
							this.class16_0.method_14(gClass6);
						}
					}
					GClass5 gClass8 = new GClass5(345u);
					if (this.class16_0.method_2().list_4.Contains(@class.UInt32_0) || @class.method_27(this.class16_0, true))
					{
						gClass8.method_9(@class.int_4);
					}
					else
					{
						gClass8.method_9(-1);
					}
					this.class16_0.method_14(gClass8);
					if (@class.Boolean_0)
					{
						this.class16_0.method_14(@class.class21_0.method_0(this.class16_0));
					}
					else
					{
						GClass5 gClass9 = new GClass5(370u);
						gClass9.method_7("-1");
						this.class16_0.method_14(gClass9);
					}
				}
				this.method_4();
			}
		}
		public void method_7()
		{
			this.class16_0.method_2().uint_2 = 0u;
			this.class16_0.method_2().bool_5 = false;
			this.class16_0.method_2().bool_6 = false;
		}
		public bool method_8(string string_0)
		{
			bool result;
			if (!Regex.IsMatch(string_0, "^[-a-zA-Z0-9._:,]+$"))
			{
				result = false;
			}
			else
			{
				DataRow dataRow = null;
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					dataRow = @class.method_4("SELECT * FROM users WHERE username = '" + string_0 + "'");
				}
				result = (dataRow == null);
			}
			return result;
		}
	}
}
