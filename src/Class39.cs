using System;
namespace ns0
{
	internal sealed class Class39
	{
		internal uint uint_0;
		internal uint uint_1;
		internal string string_0;
		private Class40 class40_0;
		internal Class39(uint uint_2, uint uint_3, string string_1)
		{
			this.uint_0 = uint_2;
			this.uint_1 = uint_3;
			this.string_0 = string_1;
			this.class40_0 = this.method_1();
		}
		internal void method_0(GClass5 gclass5_0, bool bool_0)
		{
			if (this.class40_0 == null)
			{
				GClass4.smethod_2("Unknown base: " + this.uint_1);
			}
			gclass5_0.method_11(this.uint_0);
			gclass5_0.method_7(this.class40_0.char_0.ToString().ToUpper());
			gclass5_0.method_11(this.uint_0);
			gclass5_0.method_9(this.class40_0.int_0);
			if (this.class40_0.string_1.Contains("a2 "))
			{
				gclass5_0.method_9(3);
			}
			else
			{
				if (this.class40_0.string_1.Contains("wallpaper"))
				{
					gclass5_0.method_9(2);
				}
				else
				{
					if (this.class40_0.string_1.Contains("landscape"))
					{
						gclass5_0.method_9(4);
					}
					else
					{
						if (this.method_1().string_1 == "poster")
						{
							gclass5_0.method_9(6);
						}
						else
						{
							if (this.method_1().string_1 == "song_disk")
							{
								gclass5_0.method_9(8);
							}
							else
							{
								gclass5_0.method_9(1);
							}
						}
					}
				}
			}
			if (this.method_1().string_1 == "song_disk")
			{
				gclass5_0.method_9(0);
				gclass5_0.method_7("");
			}
			else
			{
				if (this.method_1().string_1.StartsWith("poster_"))
				{
					gclass5_0.method_7(this.method_1().string_1.Split(new char[]
					{
						'_'
					})[1]);
				}
				else
				{
					gclass5_0.method_9(0);
					gclass5_0.method_7(this.string_0);
				}
			}
			gclass5_0.method_13(this.class40_0.bool_3);
			gclass5_0.method_13(this.class40_0.bool_4);
			gclass5_0.method_13(this.class40_0.bool_7);
			gclass5_0.method_13(Phoenix.smethod_15().method_6().method_22().method_0(this));
			gclass5_0.method_9(-1);
			if (this.class40_0.char_0 == 's')
			{
				gclass5_0.method_7("");
				if (this.method_1().string_1 == "song_disk" && this.string_0.Length > 0)
				{
					gclass5_0.method_9(Convert.ToInt32(this.string_0));
				}
				else
				{
					gclass5_0.method_9(0);
				}
			}
		}
		internal Class40 method_1()
		{
			return Phoenix.smethod_15().method_8().method_2(this.uint_1);
		}
	}
}
