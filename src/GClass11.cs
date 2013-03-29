using System;
using System.Diagnostics;
using System.Threading;
namespace ns0
{
	public sealed class GClass11
	{
		public static void smethod_0()
		{
			while (true)
			{
				try
				{
					DateTime now = DateTime.Now;
					TimeSpan timeSpan = now - Phoenix.dateTime_0;
					new PerformanceCounter("Processor", "% Processor Time", "_Total");
					int num = 1;
					int num2 = Phoenix.smethod_15().method_2().Int32_0 + -1;
					int int32_ = Phoenix.smethod_15().method_9().Int32_0;
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
						using (Class6 @class = Phoenix.smethod_12().method_0())
						{
							@class.method_1(string.Concat(new object[]
							{
								"UPDATE server_status SET stamp = UNIX_TIMESTAMP(), status = '",
								num,
								"', users_online = '",
								num2,
								"', rooms_loaded = '",
								int32_,
								"', server_ver = '",
								Phoenix.String_0,
								"' LIMIT 1"
							}));
							uint num3 = (uint)@class.method_6("SELECT users FROM system_stats ORDER BY ID DESC LIMIT 1");
							if ((long)num2 > (long)((ulong)num3))
							{
								@class.method_1(string.Concat(new object[]
								{
									"UPDATE system_stats SET users = '",
									num2,
									"', rooms = '",
									int32_,
									"' ORDER BY ID DESC LIMIT 1"
								}));
							}
						}
					}
					Phoenix.smethod_15().method_2().method_23();
					Console.Title = string.Concat(new object[]
					{
						"Phoenix 3.0 | Online Users: ",
						num2,
						" | Rooms Loaded: ",
						int32_,
						" | Uptime: ",
						timeSpan.Days,
						" days, ",
						timeSpan.Hours,
						" hours and ",
						timeSpan.Minutes,
						" minutes"
					});
				}
				catch (Exception ex)
				{
					GClass4.smethod_6(ex.ToString(), "Server status update task");
				}
				Thread.Sleep(5000);
			}
		}
	}
}
