using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
namespace ns0
{
    internal sealed class Phoenix
    {
        public const int int_0 = 14986;
        public const string string_0 = "quackster.net";
        public const string string_1 = "http://quackster.net/phx/";
        private static Class117 class117_0;
        private static Class1 class1_0;
        private static Class7 class7_0;
        private static Encoding encoding_0;
        private static Class113 class113_0;
        private static Class322 class322_0;
        private static Class3 class3_0;
        internal static DateTime dateTime_0;
        public string string_2 = Phoenix.smethod_1(14986.ToString());
        public string string_3 = "http://quackster.net/phx/licence" + Convert.ToChar(46).ToString() + "php" + Convert.ToChar(63).ToString();
        public static string string_4 = "http://quackster.net/phx/override" + Convert.ToChar(46).ToString() + "php";
        public static bool bool_0 = false;
        public static int int_1 = 0;
        public static int int_2 = 0;
        public static string string_5 = null;
        public static string string_6;
        public static string string_7;
        private static bool bool_1 = false;
        public static string String_0
        {
            get
            {
                return "Phoenix v3.11.0 (Build " + 14986 + ")";
            }
        }
        internal static Class3 Class3_0
        {
            get
            {
                return Phoenix.class3_0;
            }
            set
            {
                Phoenix.class3_0 = value;
            }
        }

        public static void pause()
        {
            while (true) {
                System.Threading.Thread.Sleep(5000);
            }
        }

        public static string smethod_0(string string_8)
        {
            MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(string_8);
            array = mD5CryptoServiceProvider.ComputeHash(array);
            StringBuilder stringBuilder = new StringBuilder();
            byte[] array2 = array;
            for (int i = 0; i < array2.Length; i++)
            {
                byte b = array2[i];
                stringBuilder.Append(b.ToString("x2").ToLower());
            }
            string text = stringBuilder.ToString();
            return text.ToUpper();
        }
        public static string smethod_1(string string_8)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(string_8);
            byte[] array = new SHA1Managed().ComputeHash(bytes);
            string text = string.Empty;
            byte[] array2 = array;
            for (int i = 0; i < array2.Length; i++)
            {
                byte b = array2[i];
                text += b.ToString("X2");
            }
            return text;
        }
        public void method_0()
        {
            Console.Title = "Phoenix Emulator 3.11.0";
            
            if (!Class66.smethod_0(true))
            {
                Phoenix.dateTime_0 = DateTime.Now;
                Phoenix.encoding_0 = Encoding.Default;
                Class8.smethod_3();

                try
                {
                    Phoenix.class1_0 = new Class1("config.conf");
                    DateTime now = DateTime.Now;
                    //Phoenix.string_6 = Phoenix.smethod_11().dictionary_0["Otaku-Studios.username"];
                    //Phoenix.string_7 = new Random().Next(Int32.MaxValue).ToString();//Class2.smethod_11().dictionary_0["Otaku-Studios.password"];
                    //int num = Phoenix.string_6.Length * Phoenix.string_7.Length;
                    int num = 45;

                    //if (Phoenix.string_6 == "" || Phoenix.string_7 == "" || Class13.Boolean_7)
                    //{
                        //Console.ForegroundColor = ConsoleColor.Red;
                        //Phoenix.smethod_19("Invalid Licence details found #0001", false);
                    //}
                    //else
                    //{
                        Class13.String_6 = Phoenix.string_6;
                        Class13.String_3 = Phoenix.string_7;
                        string text = new Random().Next(Int32.MaxValue).ToString();
                        text = Class66.smethod_1(text, this.string_3);

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        string str = new Random().Next(Int32.MaxValue).ToString();//text.Substring(32, 32);
                        str = Phoenix.smethod_0(str + Phoenix.string_6);
                        str = Phoenix.smethod_0(str + "4g");
                        str = Phoenix.smethod_1(str + Phoenix.string_7);
                        string b = Phoenix.smethod_0(num.ToString());

                        GClass3 gclass3_ = new GClass3(Phoenix.smethod_11().dictionary_0["db.hostname"], uint.Parse(Phoenix.smethod_11().dictionary_0["db.port"]), Phoenix.smethod_11().dictionary_0["db.username"], Phoenix.smethod_11().dictionary_0["db.password"]);
                        text = "r4r43mfgp3kkkr3mgprekw[gktp6ijhy[h]5h76ju6j7uj7";//text.Substring(64, 96);
                        GClass2 gclass2_ = new GClass2(Phoenix.smethod_11().dictionary_0["db.name"], uint.Parse(Phoenix.smethod_11().dictionary_0["db.pool.minsize"]), uint.Parse(Phoenix.smethod_11().dictionary_0["db.pool.maxsize"]));
                        Phoenix.class7_0 = new Class7(gclass3_, gclass2_);

                        try
                        {
                            using (Class6 @class = Phoenix.smethod_12().method_0())
                            {
                                @class.method_1("UPDATE users SET online = '0'");
                                @class.method_1("UPDATE rooms SET users_now = '0'");
                            }
                            Phoenix.class113_0.method_7();
                            Phoenix.class3_0.method_1();
                        }
                        catch
                        {
                        }

                        Class13.String_1 = text;
                        Phoenix.class3_0 = new Class3(int.Parse(Phoenix.smethod_11().dictionary_0["game.tcp.conlimit"]));
                        string text2 = Class13.String_5 + Phoenix.smethod_0((Class13.String_6.Length * 14986).ToString());
                        text2 += Phoenix.smethod_0((Class13.String_3.Length % 14986).ToString());

                        Phoenix.class117_0 = new Class117();
                        Phoenix.class117_0.method_1();
                        Phoenix.class117_0.method_2();
                        Phoenix.class117_0.method_3();
                        Phoenix.class117_0.method_4();
                        Phoenix.class117_0.method_5();
                        Phoenix.class117_0.method_6();
                        Phoenix.class117_0.method_7();
                        Phoenix.class117_0.method_8();
                        Phoenix.class117_0.method_9();
                        Phoenix.class117_0.method_10();
                        Phoenix.class117_0.method_11();
                        Phoenix.class117_0.method_12();
                        Phoenix.class117_0.method_13();
                        Phoenix.class117_0.method_14();
                        Phoenix.class117_0.method_15();
                        Phoenix.class117_0.method_21();
                        Phoenix.class117_0.method_20();
                        Phoenix.class117_0.method_18();
                        Phoenix.class117_0.method_17();
                        Phoenix.class117_0.method_16();
                        Phoenix.class117_0.method_19();
                        Phoenix.class117_0.method_22();
                        Phoenix.class117_0.method_24();
                        Phoenix.class117_0.method_23();
                        Phoenix.class117_0.method_25();
                        Phoenix.class117_0.method_26();
                        Phoenix.class117_0.method_27();
                    //}

                    Class13.int_12 = int.Parse(Phoenix.smethod_11().dictionary_0["game.tcp.port"]);
                    Class13.int_13 = int.Parse(Phoenix.smethod_11().dictionary_0["mus.tcp.port"]);

                    Phoenix.class322_0 = new Class322(Phoenix.smethod_11().dictionary_0["mus.tcp.bindip"], Class13.int_13, Phoenix.smethod_11().dictionary_0["mus.tcp.allowedaddr"].Split(new char[] { ';' }), 20);
                    Phoenix.class113_0 = new Class113(Class13.string_33, Class13.int_12, int.Parse(Phoenix.smethod_11().dictionary_0["game.tcp.conlimit"]));
                    Phoenix.class113_0.method_3().method_0();
                    TimeSpan timeSpan = DateTime.Now - now;
                    GClass4.smethod_1(string.Concat(new object[]
					{
						"Server -> READY! (",
						timeSpan.Seconds,
						" s, ",
						timeSpan.Milliseconds,
						" ms)"
					}));
                    Console.Beep();
                }
                catch (KeyNotFoundException)
                {
                    GClass4.smethod_1("Failed to boot, key not found.");
                    GClass4.smethod_1("Press any key to shut down ...");
                    Console.ReadKey(true);
                    Phoenix.smethod_16();
                }
                catch (InvalidOperationException ex)
                {
                    GClass4.smethod_1("Failed to initialize PhoenixEmulator: " + ex.Message);
                    GClass4.smethod_1("Press any key to shut down ...");
                    Console.ReadKey(true);
                    Phoenix.smethod_16();
                }
            }
        }
        public static int smethod_2(string string_8)
        {
            return Convert.ToInt32(string_8);
        }
        public static bool smethod_3(string string_8)
        {
            return string_8 == "1";
        }
        public static string smethod_4(bool bool_2)
        {
            string result;
            if (bool_2)
            {
                result = "1";
            }
            else
            {
                result = "0";
            }
            return result;
        }
        public static int smethod_5(int int_3, int int_4)
        {
            RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] array = new byte[4];
            rNGCryptoServiceProvider.GetBytes(array);
            int seed = BitConverter.ToInt32(array, 0);
            return new Random(seed).Next(int_3, int_4 + 1);
        }
        public static double smethod_6()
        {
            return (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
        }
        public static string smethod_7(string string_8)
        {
            return Phoenix.smethod_8(string_8, false, false);
        }
        public static string smethod_8(string string_8, bool bool_2, bool bool_3)
        {
            string_8 = string_8.Replace(Convert.ToChar(1), ' ');
            string_8 = string_8.Replace(Convert.ToChar(2), ' ');
            string_8 = string_8.Replace(Convert.ToChar(9), ' ');
            if (!bool_2)
            {
                string_8 = string_8.Replace(Convert.ToChar(13), ' ');
            }
            if (bool_3)
            {
                string_8 = string_8.Replace('\'', ' ');
            }
            return string_8;
        }
        public static bool smethod_9(string string_8)
        {
            bool result;
            if (string.IsNullOrEmpty(string_8))
            {
                result = false;
            }
            else
            {
                for (int i = 0; i < string_8.Length; i++)
                {
                    if (!char.IsLetter(string_8[i]) && !char.IsNumber(string_8[i]))
                    {
                        result = false;
                        return result;
                    }
                }
                result = true;
            }
            return result;
        }
        public static Class117 smethod_10()
        {
            return Phoenix.class117_0;
        }
        public static Class1 smethod_11()
        {
            return Phoenix.class1_0;
        }
        public static Class7 smethod_12()
        {
            return Phoenix.class7_0;
        }
        public static Encoding smethod_13()
        {
            return Phoenix.encoding_0;
        }
        public static Class113 smethod_14()
        {
            return Phoenix.class113_0;
        }
        internal static Class3 smethod_15()
        {
            return Phoenix.class3_0;
        }
        public static void smethod_16()
        {
            GClass4.smethod_1("Destroying PhoenixEmu environment...");
            if (Phoenix.smethod_15() != null)
            {
                Phoenix.smethod_15().method_1();
                Phoenix.class3_0 = null;
            }
            if (Phoenix.smethod_14() != null)
            {
                GClass4.smethod_1("Destroying connection manager.");
                Phoenix.smethod_14().method_3().method_2();
                Phoenix.smethod_14().method_0();
                Phoenix.class113_0 = null;
            }
            if (Phoenix.smethod_12() != null)
            {
                try
                {
                    GClass4.smethod_1("Destroying database manager.");
                    MySqlConnection.ClearAllPools();
                    Phoenix.class7_0 = null;
                }
                catch
                {
                }
            }
            GClass4.smethod_1("Uninitialized successfully. Closing.");
        }
        internal static void smethod_17(string string_8)
        {
            try
            {
                GClass5 gClass = new GClass5(139u);
                gClass.method_7(string_8);
                Phoenix.smethod_15().method_2().method_14(gClass);
            }
            catch
            {
            }
        }
        internal static void smethod_18()
        {
            Phoenix.smethod_19("", true);
        }
        internal static void smethod_19(string string_8, bool bool_2)
        {
            Class13.bool_16 = true;
            try
            {
                Phoenix.smethod_10().method_28();
            }
            catch
            {
            }
            if (string_8 != "")
            {
                if (Phoenix.bool_1)
                {
                    return;
                }
                Console.WriteLine("  " + string_8);
                GClass4.smethod_7();
                Phoenix.smethod_17("ATTENTION:\r\nThe server is shutting down. All furniture placed in rooms/traded/bought after this message is on your own responsibillity.");
                Phoenix.bool_1 = true;
                Console.WriteLine("  " + "Server shutting down...");
                try
                {
                    Phoenix.class3_0.method_9().method_4();
                }
                catch
                {
                }
                try
                {
                    Phoenix.smethod_14().method_3().method_1();
                    Phoenix.smethod_15().method_2().method_24();
                }
                catch
                {

                }
                try
                {
                    Console.WriteLine("  " + "Destroying database manager.");
                    MySqlConnection.ClearAllPools();
                    Phoenix.class7_0 = null;
                }
                catch
                {
                }
                Console.WriteLine("  " + "System disposed, goodbye!");
            }
            else
            {
                GClass4.smethod_7();
                Phoenix.bool_1 = true;
                try
                {
                    Phoenix.class3_0.method_9().method_4();
                }
                catch
                {
                }
                try
                {
                    Phoenix.smethod_14().method_3().method_1();
                    Phoenix.smethod_15().method_2().method_24();
                }
                catch
                {
                }
                Phoenix.class113_0.method_7();
                Phoenix.class3_0.method_1();
                Console.WriteLine("  " + string_8);
            }
            if (bool_2)
            {
                Environment.Exit(0);
            }
        }
        public static bool smethod_20(int int_3, int int_4)
        {
            return int_3 % int_4 == 0;
        }
        public static DateTime smethod_21(double double_0)
        {
            DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            result = result.AddSeconds(double_0).ToLocalTime();
            return result;
        }
    }
}
