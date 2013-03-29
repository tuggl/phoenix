using System;
using System.Data;
namespace ns0
{
	internal sealed class Class160 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			int num = class18_0.method_14();
			if (num > 0 && (class16_0 != null && class16_0.method_2() != null))
			{
				Class5 @class = Class4.smethod_2(num);
				if (@class != null)
				{
					GClass5 gClass = new GClass5(311u);
					gClass.method_9(@class.int_0);
					gClass.method_7(@class.string_0);
					gClass.method_7(@class.string_1);
					gClass.method_7(@class.string_2);
					if (@class.uint_0 > 0u)
					{
						gClass.method_11(@class.uint_0);
						if (Phoenix.smethod_15().method_9().method_19(@class.uint_0) != null)
						{
							gClass.method_7(Phoenix.smethod_15().method_9().method_19(@class.uint_0).string_0);
							goto IL_15A;
						}
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							try
							{
								DataRow dataRow_ = class2.method_4("SELECT * FROM rooms WHERE id = " + @class.uint_0 + " LIMIT 1;");
								string string_ = Phoenix.smethod_15().method_9().method_17(@class.uint_0, dataRow_).string_0;
								gClass.method_7(string_);
							}
							catch
							{
								gClass.method_9(-1);
								gClass.method_7("");
							}
							goto IL_15A;
						}
					}
					gClass.method_9(-1);
					gClass.method_7("");
					IL_15A:
					bool flag = false;
					foreach (DataRow dataRow in class16_0.method_2().dataTable_0.Rows)
					{
						if ((int)dataRow["groupid"] == @class.int_0)
						{
							flag = true;
						}
					}
					if (class16_0.method_2().list_0.Contains(@class.int_0))
					{
						gClass.method_9(2);
					}
					else
					{
						if (flag)
						{
							gClass.method_9(1);
						}
						else
						{
							if (@class.string_3 == "closed")
							{
								gClass.method_9(1);
							}
							else
							{
								if (@class.list_0.Contains((int)class16_0.method_2().uint_0))
								{
									gClass.method_9(1);
								}
								else
								{
									gClass.method_9(0);
								}
							}
						}
					}
					gClass.method_9(@class.list_0.Count);
					if (class16_0.method_2().int_0 == @class.int_0)
					{
						gClass.method_13(true);
					}
					else
					{
						gClass.method_13(false);
					}
					class16_0.method_14(gClass);
				}
			}
		}
	}
}
