using System;
namespace ns0
{
	internal sealed class Class238 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			try
			{
				Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
				if (@class != null)
				{
					Class63 class2 = @class.method_28(class18_0.method_15());
					if (class2 != null)
					{
						bool bool_ = false;
						if (@class.method_26(class16_0))
						{
							bool_ = true;
						}
						class2.Class69_0.vmethod_2(class16_0, class2, class18_0.method_14(), bool_);
						if (class16_0.method_2().uint_6 == 12u)
						{
							Phoenix.smethod_15().method_16().method_1(12u, class16_0);
						}
						else
						{
							if (class16_0.method_2().uint_6 == 18u && class2.method_7().string_1 == "bw_lgchair")
							{
								Phoenix.smethod_15().method_16().method_1(18u, class16_0);
							}
							else
							{
								if (class16_0.method_2().uint_6 == 20u && class2.method_7().string_1.Contains("bw_sboard"))
								{
									Phoenix.smethod_15().method_16().method_1(20u, class16_0);
								}
								else
								{
									if (class16_0.method_2().uint_6 == 21u && class2.method_7().string_1.Contains("bw_van"))
									{
										Phoenix.smethod_15().method_16().method_1(21u, class16_0);
									}
									else
									{
										if (class16_0.method_2().uint_6 == 22u && class2.method_7().string_1.Contains("party_floor"))
										{
											Phoenix.smethod_15().method_16().method_1(22u, class16_0);
										}
										else
										{
											if (class16_0.method_2().uint_6 == 23u && class2.method_7().string_1.Contains("party_ball"))
											{
												Phoenix.smethod_15().method_16().method_1(23u, class16_0);
											}
											else
											{
												if (class16_0.method_2().uint_6 == 24u && class2.method_7().string_1.Contains("jukebox"))
												{
													Phoenix.smethod_15().method_16().method_1(24u, class16_0);
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
			catch
			{
			}
		}
	}
}
