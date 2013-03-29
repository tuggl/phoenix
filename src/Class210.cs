using System;
namespace ns0
{
	internal sealed class Class210 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			GClass5 gClass = new GClass5(827u);
			string text = class18_0.ToString().Split(new char[]
			{
				' '
			})[1];
			if (text.ToLower().Contains("pet"))
			{
				int num = Convert.ToInt32(text.Substring(3));
				gClass.method_7("a0 pet" + num);
				switch (num)
				{
				case 0:
					gClass.method_6(Class8.smethod_1("pet_breeds_0"));
					break;
				case 1:
					gClass.method_6(Class8.smethod_1("pet_breeds_1"));
					break;
				case 2:
					gClass.method_6(Class8.smethod_1("pet_breeds_2"));
					break;
				case 3:
					gClass.method_6(Class8.smethod_1("pet_breeds_3"));
					break;
				case 4:
					gClass.method_6(Class8.smethod_1("pet_breeds_4"));
					break;
				case 5:
					gClass.method_6(Class8.smethod_1("pet_breeds_5"));
					break;
				case 6:
					gClass.method_6(Class8.smethod_1("pet_breeds_6"));
					break;
				case 7:
					gClass.method_6(Class8.smethod_1("pet_breeds_7"));
					break;
				case 8:
					gClass.method_6(Class8.smethod_1("pet_breeds_8"));
					break;
				case 9:
					gClass.method_6(Class8.smethod_1("pet_breeds_9"));
					break;
				case 10:
					gClass.method_6(Class8.smethod_1("pet_breeds_10"));
					break;
				case 11:
					gClass.method_6(Class8.smethod_1("pet_breeds_11"));
					break;
				case 12:
					gClass.method_6(Class8.smethod_1("pet_breeds_12"));
					break;
				case 13:
					gClass.method_6(Class8.smethod_1("pet_breeds_13"));
					break;
				case 14:
					gClass.method_6(Class8.smethod_1("pet_breeds_14"));
					break;
				case 15:
					gClass.method_6(Class8.smethod_1("pet_breeds_15"));
					break;
				case 16:
					gClass.method_6(Class8.smethod_1("pet_breeds_16"));
					break;
				case 17:
					gClass.method_6(Class8.smethod_1("pet_breeds_17"));
					break;
				case 18:
					gClass.method_6(Class8.smethod_1("pet_breeds_18"));
					break;
				case 19:
					gClass.method_6(Class8.smethod_1("pet_breeds_19"));
					break;
				case 20:
					gClass.method_6(Class8.smethod_1("pet_breeds_20"));
					break;
				case 21:
					gClass.method_6(Class8.smethod_1("pet_breeds_21"));
					break;
				case 22:
					gClass.method_6(Class8.smethod_1("pet_breeds_22"));
					break;
				case 23:
					gClass.method_6(Class8.smethod_1("pet_breeds_23"));
					break;
				case 24:
					gClass.method_6(Class8.smethod_1("pet_breeds_24"));
					break;
				case 25:
					gClass.method_6(Class8.smethod_1("pet_breeds_25"));
					break;
				case 26:
					gClass.method_6(Class8.smethod_1("pet_breeds_26"));
					break;
				case 27:
					gClass.method_6(Class8.smethod_1("pet_breeds_27"));
					break;
				case 28:
					gClass.method_6(Class8.smethod_1("pet_breeds_28"));
					break;
				case 29:
					gClass.method_6(Class8.smethod_1("pet_breeds_29"));
					break;
				case 30:
					gClass.method_6(Class8.smethod_1("pet_breeds_30"));
					break;
				}
				class16_0.method_14(gClass);
			}
		}
	}
}
