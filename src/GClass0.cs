using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
namespace ns0
{
	public sealed class GClass0
	{
		private delegate bool Delegate0(GClass0.Enum0 sig);
		private enum Enum0
		{
			const_0,
			const_1,
			const_2,
			const_3 = 5,
			const_4
		}
		private static bool bool_0 = false;
		private static GClass0.Delegate0 delegate0_0;
		//[DllImport("Kernel32")]
		//private static extern bool SetConsoleCtrlHandler(GClass0.Delegate0 delegate0_1, bool bool_1);
		//[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
		public static void Main(string[] args)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.UnhandledException += new UnhandledExceptionEventHandler(GClass0.smethod_0);
			GClass0.delegate0_0 = (GClass0.Delegate0)Delegate.Combine(GClass0.delegate0_0, new GClass0.Delegate0(GClass0.smethod_1));
			//GClass0.SetConsoleCtrlHandler(GClass0.delegate0_0, true);
			try
			{
				Phoenix @class = new Phoenix();
				if (Class66.smethod_0(false))
				{
					return;
				}
				@class.method_0();
				GClass0.bool_0 = true;
			}
			catch (Exception ex)
			{
				Console.Write("  " + ex.ToString());
			}
			while (true)
			{
				Console.ReadKey();
			}
		}
		private static void smethod_0(object sender, UnhandledExceptionEventArgs e)
		{
			GClass4.smethod_7();
			Exception ex = (Exception)e.ExceptionObject;
			GClass4.smethod_3(ex.ToString());
		}
		private static bool smethod_1(GClass0.Enum0 enum0_0)
		{
			if (GClass0.bool_0)
			{
				GClass4.smethod_7();
				Console.WriteLine("  " + "The server is saving users furniture, rooms, etc. WAIT FOR THE SERVER TO CLOSE, DO NOT EXIT THE PROCESS IN TASK MANAGER!!");
				Phoenix.smethod_19("", true);
			}
			return true;
		}
	}
}
