using System;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class33
	{
		public uint uint_0;
		public int int_0;
		public uint uint_1;
		public int int_1;
		internal int int_2;
		public int int_3;
		public int int_4;
		public double double_0;
		internal byte byte_0;
		public int int_5;
		public int int_6;
		public int int_7;
		public int int_8;
		public bool bool_0;
		public bool bool_1;
		public bool bool_2;
		public int int_9;
		public int int_10;
		public int int_11;
		public bool bool_3;
		public bool bool_4;
		public int int_12;
		public int int_13;
		public double double_1;
		public Class34 class34_0;
		public Class99 class99_0;
		internal byte byte_1;
		internal bool bool_5;
		public Class33 class33_0;
		public Class63 class63_0;
		public Class34 class34_1;
		public Class15 class15_0;
		public bool bool_6;
		public bool bool_7;
		public bool bool_8;
		public int int_14;
		public bool bool_9;
		public Dictionary<string, string> dictionary_0;
		public int int_15;
		public int int_16;
		public bool bool_10;
		public int int_17;
		public int int_18;
		public int int_19;
		internal bool bool_11;
		internal bool bool_12;
		internal string string_0;
		internal int int_20;
		public GStruct1 GStruct1_0
		{
			get
			{
				return new GStruct1(this.int_3, this.int_4);
			}
		}
		public bool Boolean_0
		{
			get
			{
				return this.Boolean_4 && this.class34_0.Boolean_0;
			}
		}
		internal bool Boolean_1
		{
			get
			{
				return this.int_15 >= 1;
			}
		}
		internal bool Boolean_2
		{
			get
			{
				return !this.Boolean_4 && this.int_1 >= Class13.int_15;
			}
		}
		internal bool Boolean_3
		{
			get
			{
				return !this.Boolean_4 && this.dictionary_0.ContainsKey("trd");
			}
		}
		internal bool Boolean_4
		{
			get
			{
				return this.class34_0 != null;
			}
		}
		public Class33(uint uint_2, uint uint_3, int int_21, bool bool_13)
		{
			this.bool_5 = false;
			this.uint_0 = uint_2;
			this.uint_1 = uint_3;
			this.int_0 = int_21;
			this.int_1 = 0;
			this.int_3 = 0;
			this.int_4 = 0;
			this.double_0 = 0.0;
			this.int_7 = 0;
			this.int_8 = 0;
			this.bool_7 = true;
			this.dictionary_0 = new Dictionary<string, string>();
			this.int_16 = 0;
			this.int_19 = -1;
			this.class33_0 = null;
			this.bool_1 = false;
			this.bool_0 = true;
			this.bool_11 = false;
			this.byte_0 = 3;
			this.int_2 = 0;
			this.int_20 = 0;
			this.byte_1 = 0;
			this.bool_12 = bool_13;
			this.string_0 = "";
		}
		public void method_0()
		{
			this.int_1 = 0;
			if (this.bool_8)
			{
				this.bool_8 = false;
				GClass5 gClass = new GClass5(486u);
				gClass.method_9(this.int_0);
				gClass.method_13(false);
				this.method_17().method_59(gClass, null);
			}
		}
		internal void method_1(Class16 class16_0, string string_1, bool bool_13)
		{
			string object_ = string_1;
			if (class16_0 == null || (class16_0.method_2().method_3("ignore_roommute") || !this.method_17().bool_4))
			{
				this.method_0();
				if (!this.Boolean_4 && this.method_16().method_2().bool_3)
				{
					this.method_16().method_8(Class8.smethod_1("error_muted"));
				}
				else
				{
					if (!string_1.StartsWith(":") || class16_0 == null || !Class58.smethod_5(class16_0, string_1.Substring(1)))
					{
						uint num = 24u;
						if (bool_13)
						{
							num = 26u;
						}
						if (!this.Boolean_4 && class16_0.method_2().method_4() > 0)
						{
							TimeSpan timeSpan = DateTime.Now - class16_0.method_2().dateTime_0;
							if (timeSpan.Seconds > 4)
							{
								class16_0.method_2().int_23 = 0;
							}
							if (timeSpan.Seconds < 4 && class16_0.method_2().int_23 > 5 && !this.Boolean_4)
							{
								GClass5 gClass = new GClass5(27u);
								gClass.method_9(class16_0.method_2().method_4());
								this.method_16().method_14(gClass);
								this.method_16().method_2().bool_3 = true;
								this.method_16().method_2().int_4 = class16_0.method_2().method_4();
								return;
							}
							class16_0.method_2().dateTime_0 = DateTime.Now;
							class16_0.method_2().int_23++;
						}
						if (!this.Boolean_4 && !class16_0.method_2().bool_0)
						{
							string_1 = Class58.smethod_4(string_1);
						}
						if (!this.method_17().method_9(this, string_1))
						{
							GClass5 gClass2 = new GClass5(num);
							gClass2.method_9(this.int_0);
							if (string_1.Contains("http://") || string_1.Contains("www.") || string_1.Contains("https://"))
							{
								string[] array = string_1.Split(new char[]
								{
									' '
								});
								int num2 = 0;
								string text = "";
								string text2 = "";
								string[] array2 = array;
								for (int i = 0; i < array2.Length; i++)
								{
									string text3 = array2[i];
									if (Class58.smethod_2(text3))
									{
										if (num2 > 0)
										{
											text += ",";
										}
										text += text3;
										object obj = text2;
										text2 = string.Concat(new object[]
										{
											obj,
											" {",
											num2,
											"}"
										});
										num2++;
									}
									else
									{
										text2 = text2 + " " + text3;
									}
								}
								string_1 = text2;
								string[] array3 = text.Split(new char[]
								{
									','
								});
								gClass2.method_7(string_1);
								if (array3.Length > 0)
								{
									gClass2.method_13(false);
									gClass2.method_9(num2);
									array2 = array3;
									for (int i = 0; i < array2.Length; i++)
									{
										string text4 = array2[i];
										string text5 = Class58.smethod_3(text4.Replace("http://", "").Replace("https://", ""));
										gClass2.method_7(text5.Replace("http://", "").Replace("https://", ""));
										gClass2.method_7(text4);
										gClass2.method_13(false);
									}
								}
							}
							else
							{
								gClass2.method_7(string_1);
							}
							gClass2.method_9(this.method_2(string_1));
							gClass2.method_13(false);
							if (!this.Boolean_4)
							{
								this.method_17().method_58(gClass2, class16_0.method_2().list_2, class16_0.method_2().uint_0);
							}
							else
							{
								this.method_17().method_59(gClass2, null);
							}
						}
						else
						{
							if (!this.Boolean_4)
							{
								class16_0.method_2().method_28(string_1);
							}
						}
						if (!this.Boolean_4)
						{
							this.method_17().method_7(this, string_1, bool_13);
							if (class16_0.method_2().uint_6 == 3u)
							{
								Phoenix.smethod_15().method_16().method_1(3u, class16_0);
							}
						}
						if (Class13.Boolean_4 && !this.Boolean_4 && !class16_0.method_2().bool_0)
						{
							using (Class6 @class = Phoenix.smethod_12().method_0())
							{
								@class.method_0("message", object_);
								@class.method_1(string.Concat(new object[]
								{
									"INSERT INTO chatlogs (user_id,room_id,hour,minute,timestamp,message,user_name,full_date) VALUES ('",
									class16_0.method_2().uint_0,
									"','",
									this.method_17().UInt32_0,
									"','",
									DateTime.Now.Hour,
									"','",
									DateTime.Now.Minute,
									"',UNIX_TIMESTAMP(),@message,'",
									class16_0.method_2().string_0,
									"','",
									DateTime.Now.ToLongDateString(),
									"')"
								}));
							}
						}
					}
				}
			}
		}
		internal int method_2(string string_1)
		{
			string_1 = string_1.ToLower();
			int result;
			if (string_1.Contains(":)") || string_1.Contains(":d") || string_1.Contains("=]") || string_1.Contains("=d") || string_1.Contains(":>"))
			{
				result = 1;
			}
			else
			{
				if (string_1.Contains(">:(") || string_1.Contains(":@"))
				{
					result = 2;
				}
				else
				{
					if (string_1.Contains(":o") || string_1.Contains(";o"))
					{
						result = 3;
					}
					else
					{
						if (string_1.Contains(":(") || string_1.Contains(";<") || string_1.Contains("=[") || string_1.Contains(":'(") || string_1.Contains("='["))
						{
							result = 4;
						}
						else
						{
							result = 0;
						}
					}
				}
			}
			return result;
		}
		internal void method_3(bool bool_13)
		{
			this.bool_6 = false;
			this.bool_10 = false;
			this.dictionary_0.Remove("mv");
			this.int_10 = 0;
			this.int_11 = 0;
			this.bool_4 = false;
			this.int_12 = 0;
			this.int_13 = 0;
			this.double_1 = 0.0;
			if (bool_13)
			{
				this.bool_7 = true;
			}
		}
		internal void method_4(GStruct1 gstruct1_0)
		{
			this.method_5(gstruct1_0.int_0, gstruct1_0.int_1);
		}
		internal void method_5(int int_21, int int_22)
		{
			if (this.method_17().method_92(int_21, int_22) && !this.method_17().method_96(int_21, int_22))
			{
				this.method_0();
				this.bool_6 = true;
				this.bool_10 = true;
				this.int_17 = int_21;
				this.int_18 = int_22;
				if (int_21 >= this.method_17().Class28_0.int_4 || int_22 >= this.method_17().Class28_0.int_5)
				{
					this.int_10 = int_21;
					this.int_11 = int_22;
				}
				else
				{
					this.int_10 = this.method_17().gstruct1_0[int_21, int_22].int_0;
					this.int_11 = this.method_17().gstruct1_0[int_21, int_22].int_1;
				}
			}
		}
		internal void method_6()
		{
			this.bool_1 = false;
			this.bool_0 = true;
		}
		internal void method_7(int int_21, int int_22, double double_2)
		{
			this.int_3 = int_21;
			this.int_4 = int_22;
			this.double_0 = double_2;
		}
		public void method_8(int int_21)
		{
			this.int_5 = int_21;
			if (int_21 > 1000)
			{
				this.int_6 = 5000;
			}
			else
			{
				if (int_21 > 0)
				{
					this.int_6 = 240;
				}
				else
				{
					this.int_6 = 0;
				}
			}
			GClass5 gClass = new GClass5(482u);
			gClass.method_9(this.int_0);
			gClass.method_9(int_21);
			this.method_17().method_59(gClass, null);
		}
		public void method_9(int int_21)
		{
			this.method_10(int_21, false);
		}
		public void method_10(int int_21, bool bool_13)
		{
			if (!this.dictionary_0.ContainsKey("lay") && !this.bool_6)
			{
				int num = this.int_8 - int_21;
				this.int_7 = this.int_8;
				if (this.dictionary_0.ContainsKey("sit") || bool_13)
				{
					if (this.int_8 == 2 || this.int_8 == 4)
					{
						if (num > 0)
						{
							this.int_7 = this.int_8 - 1;
						}
						else
						{
							if (num < 0)
							{
								this.int_7 = this.int_8 + 1;
							}
						}
					}
					else
					{
						if (this.int_8 == 0 || this.int_8 == 6)
						{
							if (num > 0)
							{
								this.int_7 = this.int_8 - 1;
							}
							else
							{
								if (num < 0)
								{
									this.int_7 = this.int_8 + 1;
								}
							}
						}
					}
				}
				else
				{
					if (num <= -2 || num >= 2)
					{
						this.int_7 = int_21;
						this.int_8 = int_21;
					}
					else
					{
						this.int_7 = int_21;
					}
				}
				this.bool_7 = true;
			}
		}
		public void method_11(string string_1, string string_2)
		{
			this.dictionary_0[string_1] = string_2;
		}
		public void method_12(string string_1)
		{
			if (this.dictionary_0.ContainsKey(string_1))
			{
				this.dictionary_0.Remove(string_1);
			}
		}
		public void method_13()
		{
			this.dictionary_0 = new Dictionary<string, string>();
		}
		public void method_14(GClass5 gclass5_0)
		{
			if (gclass5_0 != null && !this.bool_11)
			{
				if (!this.Boolean_4)
				{
					if (this.method_16() != null && this.method_16().method_2() != null)
					{
						Class11 @class = this.method_16().method_2();
						gclass5_0.method_11(@class.uint_0);
						gclass5_0.method_7(@class.string_0);
						gclass5_0.method_7(@class.string_4);
						gclass5_0.method_7(@class.string_5);
						gclass5_0.method_9(this.int_0);
						gclass5_0.method_9(this.int_3);
						gclass5_0.method_9(this.int_4);
						gclass5_0.method_7(this.double_0.ToString().Replace(',', '.'));
						gclass5_0.method_9(2);
						gclass5_0.method_9(1);
						gclass5_0.method_7(@class.string_6.ToLower());
						gclass5_0.method_9(-1);
						if (@class.int_0 > 0)
						{
							gclass5_0.method_9(@class.int_0);
						}
						else
						{
							gclass5_0.method_9(-1);
						}
						gclass5_0.method_9(-1);
						gclass5_0.method_7("");
						gclass5_0.method_9(@class.int_13);
					}
				}
				else
				{
					gclass5_0.method_9(this.class99_0.int_0);
					gclass5_0.method_7(this.class34_0.string_1);
					gclass5_0.method_7(this.class34_0.string_2);
					gclass5_0.method_7(this.class34_0.string_3);
					gclass5_0.method_9(this.int_0);
					gclass5_0.method_9(this.int_3);
					gclass5_0.method_9(this.int_4);
					gclass5_0.method_7(this.double_0.ToString().Replace(',', '.'));
					gclass5_0.method_9(4);
					gclass5_0.method_9((this.class34_0.enum2_0 == Enum2.const_0) ? 2 : 3);
					if (this.class34_0.enum2_0 == Enum2.const_0)
					{
						gclass5_0.method_9(0);
					}
				}
			}
		}
		public void method_15(GClass5 gclass5_0)
		{
			if (!this.bool_11)
			{
				gclass5_0.method_9(this.int_0);
				gclass5_0.method_9(this.int_3);
				gclass5_0.method_9(this.int_4);
				gclass5_0.method_7(this.double_0.ToString().Replace(',', '.'));
				gclass5_0.method_9(this.int_7);
				gclass5_0.method_9(this.int_8);
				gclass5_0.method_6("/");
				try
				{
					foreach (KeyValuePair<string, string> current in this.dictionary_0)
					{
						gclass5_0.method_6(current.Key);
						gclass5_0.method_6(" ");
						gclass5_0.method_6(current.Value);
						gclass5_0.method_6("/");
					}
				}
				catch
				{
				}
				gclass5_0.method_7("/");
			}
		}
		public Class16 method_16()
		{
			Class16 result;
			if (this.Boolean_4)
			{
				result = null;
			}
			else
			{
				result = Phoenix.smethod_15().method_2().method_2(this.uint_0);
			}
			return result;
		}
		private Class14 method_17()
		{
			return Phoenix.smethod_15().method_9().method_19(this.uint_1);
		}
	}
}
