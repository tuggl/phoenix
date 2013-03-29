using System;
using System.Data;
namespace ns0
{
	internal sealed class Class237 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			try
			{
				Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
				if (@class != null && @class.method_27(class16_0, true))
				{
					Class63 class2 = @class.method_28(class18_0.method_15());
					Class39 class3 = class16_0.method_2().method_23().method_10(class2.uint_0);
					if (class2 != null)
					{
						if (class2.method_7().string_1.StartsWith("CF_") || class2.method_7().string_1.StartsWith("CFC_") || class2.method_7().string_1.StartsWith("PixEx_") || class2.method_7().string_1.StartsWith("PntEx_"))
						{
							if (class3 != null)
							{
								@class.method_29(null, class3.uint_0, true, true);
							}
							else
							{
								DataRow dataRow = null;
								using (Class6 class4 = Phoenix.smethod_12().method_0())
								{
									dataRow = class4.method_4("SELECT ID FROM items WHERE ID = '" + class2.uint_0 + "' LIMIT 1");
								}
								if (dataRow != null)
								{
									string[] array = class2.method_7().string_1.Split(new char[]
									{
										'_'
									});
									int num = int.Parse(array[1]);
									if (num > 0)
									{
										if (class2.method_7().string_1.StartsWith("CF_") || class2.method_7().string_1.StartsWith("CFC_"))
										{
											class16_0.method_2().int_2 += num;
											class16_0.method_2().method_13(true);
										}
										else
										{
											if (class2.method_7().string_1.StartsWith("PixEx_"))
											{
												class16_0.method_2().int_3 += num;
												class16_0.method_2().method_15(true);
											}
											else
											{
												if (class2.method_7().string_1.StartsWith("PntEx_"))
												{
													class16_0.method_2().int_12 += num;
													class16_0.method_2().method_14(false, true);
												}
											}
										}
									}
								}
								@class.method_29(null, class2.uint_0, true, true);
								GClass5 gclass5_ = new GClass5(219u);
								class16_0.method_14(gclass5_);
							}
						}
					}
				}
			}
			catch
			{
			}
		}
	}
}
