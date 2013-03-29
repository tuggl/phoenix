using System;
using System.Data;
using System.Threading.Tasks;
namespace ns0
{
	internal sealed class Class3
	{
		private Class37 class37_0;
		private Class62 class62_0;
		private Class22 class22_0;
		private Class129 class129_0;
		private Class45 class45_0;
		private Class31 class31_0;
		private Class41 class41_0;
		private Class24 class24_0;
		private Class20 class20_0;
		private Class0 class0_0;
		private Class54 class54_0;
		private Class112 class112_0;
		private Class60 class60_0;
		private Task task_0;
		private Class276 class276_0;
		private Class43 class43_0;
		private Class9 class9_0;
		private Class8 class8_0;
		private Class4 class4_0;
		public Class3(int int_0)
		{
			this.class37_0 = new Class37(int_0);
			if (Phoenix.smethod_11().dictionary_0["client.ping.enabled"] == "1")
			{
				this.class37_0.method_10();
			}
			DateTime arg_45_0 = DateTime.Now;
			GClass4.smethod_0("Connecting to database...");
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				GClass4.smethod_1("completed!");
				Phoenix.Class3_0 = this;
				this.method_17(@class);
				this.class62_0 = new Class62();
				this.class22_0 = new Class22();
				this.class129_0 = new Class129();
				this.class45_0 = new Class45();
				this.class31_0 = new Class31();
				this.class41_0 = new Class41();
				this.class24_0 = new Class24();
				this.class20_0 = new Class20();
				this.class0_0 = new Class0();
				this.class54_0 = new Class54();
				this.class112_0 = new Class112();
				this.class60_0 = new Class60();
				this.class43_0 = new Class43();
				this.class9_0 = new Class9();
				this.class8_0 = new Class8();
				this.class4_0 = new Class4();
				Class8.smethod_0(@class);
				this.class62_0.method_0(@class);
				Class13.String_5 = "FB3A78763D7819F39D79781F6F8DFCCD";
				this.class22_0.method_0(@class);
				this.class129_0.method_0(@class);
				this.class129_0.method_3(@class);
				this.class112_0.method_1(@class);
				this.class112_0.method_2(@class);
				Class13.String_5 = "B8AC48FA7DB791129E59CBA4BC2CC5DD";
				this.class41_0.method_0(@class);
				Class13.String_5 = "7866151A40EEB2379D61F640B26ED23B";
				this.class45_0.method_0(@class);
				this.class45_0.method_1();
				this.class31_0.method_0(@class);
				Class13.String_5 = Class13.String_6;
				this.class24_0.method_8(@class);
				this.class24_0.method_0();
				this.class276_0 = new Class276();
				this.class20_0.method_0(@class);
				this.class60_0.method_0(@class);
				Class13.String_5 = Class13.String_3;
				Class13.String_5 = Class13.String_6.Length.ToString();
				Class54.smethod_0(@class);
				this.class0_0.method_0();
				Class58.smethod_0(@class);
				Class13.String_5 = Class13.String_3.Length.ToString();
				this.class9_0.method_0();
				Class4.smethod_0(@class);
				this.method_0(@class, 1);
			}
			this.task_0 = new Task(new Action(GClass11.smethod_0));
			this.task_0.Start();
		}
		public void method_0(Class6 class6_0, int int_0)
		{
			GClass4.smethod_0(Class8.smethod_1("emu_cleandb"));
			bool flag = true;
			try
			{
				if (int.Parse(Phoenix.smethod_11().dictionary_0["debug"]) == 1)
				{
					flag = false;
				}
			}
			catch
			{
			}
			if (flag)
			{
				class6_0.method_1("UPDATE users SET online = '0' WHERE online != '0'");
				class6_0.method_1("UPDATE rooms SET users_now = '0' WHERE users_now != '0'");
				class6_0.method_1("UPDATE user_roomvisits SET exit_timestamp = UNIX_TIMESTAMP() WHERE exit_timestamp <= 0");
				class6_0.method_1(string.Concat(new object[]
				{
					"UPDATE server_status SET status = '",
					int_0,
					"', users_online = '0', rooms_loaded = '0', server_ver = '",
					Phoenix.String_0,
					"', stamp = UNIX_TIMESTAMP() LIMIT 1;"
				}));
			}
			GClass4.smethod_1("completed!");
		}
		public void method_1()
		{
			if (this.task_0 != null)
			{
				this.task_0 = null;
			}
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				this.method_0(@class, 0);
			}
			if (this.method_2() != null)
			{
				this.method_2().method_6();
				this.method_2().method_11();
			}
			if (this.method_11() != null)
			{
				this.class0_0.bool_0 = false;
			}
			this.class37_0 = null;
			this.class62_0 = null;
			this.class22_0 = null;
			this.class129_0 = null;
			this.class45_0 = null;
			this.class31_0 = null;
			this.class41_0 = null;
			this.class24_0 = null;
			this.class20_0 = null;
			this.class0_0 = null;
		}
		public Class37 method_2()
		{
			return this.class37_0;
		}
		public Class62 method_3()
		{
			return this.class62_0;
		}
		public Class22 method_4()
		{
			return this.class22_0;
		}
		public Class129 method_5()
		{
			return this.class129_0;
		}
		public Class45 method_6()
		{
			return this.class45_0;
		}
		public Class31 method_7()
		{
			return this.class31_0;
		}
		public Class41 method_8()
		{
			return this.class41_0;
		}
		public Class24 method_9()
		{
			return this.class24_0;
		}
		public Class20 method_10()
		{
			return this.class20_0;
		}
		public Class0 method_11()
		{
			return this.class0_0;
		}
		public Class54 method_12()
		{
			return this.class54_0;
		}
		public Class112 method_13()
		{
			return this.class112_0;
		}
		public Class60 method_14()
		{
			return this.class60_0;
		}
		internal Class276 method_15()
		{
			return this.class276_0;
		}
		public Class9 method_16()
		{
			return this.class9_0;
		}
		public void method_17(Class6 class6_0)
		{
			GClass4.smethod_0("Loading your settings..");
			DataRow dataRow = class6_0.method_4("SELECT * FROM server_settings LIMIT 1");
			Class13.Int32_4 = (int)dataRow["MaxRoomsPerUser"];
			Class13.String_4 = (string)dataRow["motd"];
			Class13.Int32_0 = (int)dataRow["timer"];
			Class13.Int32_1 = (int)dataRow["credits"];
			Class13.Int32_3 = (int)dataRow["pixels"];
			Class13.Int32_2 = (int)dataRow["points"];
			Class13.int_3 = (int)dataRow["pixels_max"];
			Class13.int_5 = (int)dataRow["credits_max"];
			Class13.int_4 = (int)dataRow["points_max"];
			Class13.int_2 = (int)dataRow["MaxPetsPerRoom"];
			Class13.int_0 = (int)dataRow["MaxMarketPlacePrice"];
			Class13.int_1 = (int)dataRow["MarketPlaceTax"];
			Class13.bool_0 = Phoenix.smethod_3(dataRow["enable_antiddos"].ToString());
			Class13.Boolean_3 = Phoenix.smethod_3(dataRow["vipclothesforhcusers"].ToString());
			Class13.Boolean_4 = Phoenix.smethod_3(dataRow["enable_chatlogs"].ToString());
			Class13.Boolean_5 = Phoenix.smethod_3(dataRow["enable_cmdlogs"].ToString());
			Class13.Boolean_6 = Phoenix.smethod_3(dataRow["enable_roomlogs"].ToString());
			Class13.String_2 = (string)dataRow["enable_externalchatlinks"];
			Class13.Boolean_2 = Phoenix.smethod_3(dataRow["enable_securesessions"].ToString());
			Class13.Boolean_1 = Phoenix.smethod_3(dataRow["allow_friendfurnidrops"].ToString());
			Class13.Boolean_0 = Phoenix.smethod_3(dataRow["enable_cmd_redeemcredits"].ToString());
			Class13.bool_18 = Phoenix.smethod_3(dataRow["unload_crashedrooms"].ToString());
			Class13.bool_19 = Phoenix.smethod_3(dataRow["ShowUsersAndRoomsInAbout"].ToString());
			Class13.int_14 = (int)dataRow["idlesleep"];
			Class13.int_15 = (int)dataRow["idlekick"];
			Class13.bool_20 = Phoenix.smethod_3(dataRow["ip_lastforbans"].ToString());
			GClass4.smethod_1("completed!");
		}
	}
}
