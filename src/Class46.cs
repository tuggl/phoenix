using System;
using System.Data;
namespace ns0
{
	internal sealed class Class46
	{
		public bool method_0(string string_0)
		{
			bool result;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_0("code", string_0);
				if (@class.method_4("SELECT null FROM vouchers WHERE code = @code LIMIT 1") != null)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
		public void method_1(string string_0)
		{
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_0("code", string_0);
				@class.method_1("DELETE FROM vouchers WHERE code = @code LIMIT 1");
			}
		}
		public void method_2(Class16 class16_0, string string_0)
		{
			if (!this.method_0(string_0))
			{
				GClass5 gClass = new GClass5(213u);
				gClass.method_10(0);
				class16_0.method_14(gClass);
			}
			else
			{
				DataRow dataRow = null;
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_0("code", string_0);
					dataRow = @class.method_4("SELECT * FROM vouchers WHERE code = @code LIMIT 1");
				}
				int num = (int)dataRow["credits"];
				int num2 = (int)dataRow["pixels"];
				int num3 = (int)dataRow["vip_points"];
				this.method_1(string_0);
				if (num > 0)
				{
					class16_0.method_2().int_2 += num;
					class16_0.method_2().method_13(true);
				}
				if (num2 > 0)
				{
					class16_0.method_2().int_3 += num2;
					class16_0.method_2().method_15(true);
				}
				if (num3 > 0)
				{
					class16_0.method_2().int_12 += num3;
					class16_0.method_2().method_14(false, true);
				}
				class16_0.method_14(new GClass5(212u));
			}
		}
	}
}
