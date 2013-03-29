using System;
namespace ns0
{
	internal sealed class Class101 : Class99
	{
		private int int_2;
		private int int_3;
		public Class101(int int_4)
		{
			this.int_2 = new Random((int_4 ^ 2) + DateTime.Now.Millisecond).Next(10, 250);
			this.int_3 = new Random((int_4 ^ 2) + DateTime.Now.Millisecond).Next(10, 30);
		}
		public override void vmethod_0()
		{
		}
		public override void vmethod_1(bool bool_0)
		{
		}
		public override void vmethod_2(Class33 class33_0)
		{
		}
		public override void vmethod_3(Class16 class16_0)
		{
		}
		public override void vmethod_4(Class33 class33_0, string string_0)
		{
			if (base.method_1().method_100(base.method_2().int_3, base.method_2().int_4, class33_0.int_3, class33_0.int_4) <= 8)
			{
				Class35 @class = base.method_3().method_2(string_0);
				if (@class != null)
				{
					string text = base.method_1().method_20(class33_0, @class.string_0);
					string text2 = @class.string_1.ToLower();
					if (text2 != null)
					{
						if (!(text2 == "say"))
						{
							if (!(text2 == "shout"))
							{
								if (text2 == "whisper")
								{
									GClass5 gClass = new GClass5(25u);
									gClass.method_9(base.method_2().int_0);
									gClass.method_7(text);
									gClass.method_13(false);
									class33_0.method_16().method_14(gClass);
								}
							}
							else
							{
								base.method_2().method_1(null, text, true);
							}
						}
						else
						{
							base.method_2().method_1(null, text, false);
						}
					}
					if (@class.int_0 >= 1)
					{
						class33_0.method_8(@class.int_0);
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
				if (base.method_3().list_0.Count > 0)
				{
					Class36 @class = base.method_3().method_3();
					base.method_2().method_1(null, @class.string_0, @class.bool_0);
				}
				this.int_2 = Phoenix.smethod_5(10, 300);
			}
			else
			{
				this.int_2--;
			}
			if (this.int_3 <= 0)
			{
				string text = base.method_3().string_0.ToLower();
				if (text != null && !(text == "stand"))
				{
					if (!(text == "freeroam"))
					{
						if (text == "specified_range")
						{
							int int_ = Phoenix.smethod_5(base.method_3().int_4, base.method_3().int_5);
							int int_2 = Phoenix.smethod_5(base.method_3().int_6, base.method_3().int_7);
							base.method_2().method_5(int_, int_2);
						}
					}
					else
					{
						int int_ = Phoenix.smethod_5(0, base.method_1().Class28_0.int_4);
						int int_2 = Phoenix.smethod_5(0, base.method_1().Class28_0.int_5);
						base.method_2().method_5(int_, int_2);
					}
				}
				this.int_3 = Phoenix.smethod_5(1, 30);
			}
			else
			{
				this.int_3--;
			}
		}
	}
}
