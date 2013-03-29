using MySql.Data.MySqlClient;
using System;
namespace ns0
{
	internal sealed class Class7
	{
		public GClass3 gclass3_0;
		public GClass2 gclass2_0;
		public string String_0
		{
			get
			{
				MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
				mySqlConnectionStringBuilder.Server = this.gclass3_0.String_0;
				mySqlConnectionStringBuilder.Port = this.gclass3_0.UInt32_0;
				mySqlConnectionStringBuilder.UserID = this.gclass3_0.String_1;
				mySqlConnectionStringBuilder.Password = this.gclass3_0.String_2;
				mySqlConnectionStringBuilder.Database = this.gclass2_0.String_0;
				mySqlConnectionStringBuilder.MinimumPoolSize = this.gclass2_0.UInt32_0;
				mySqlConnectionStringBuilder.MaximumPoolSize = this.gclass2_0.UInt32_1;
				mySqlConnectionStringBuilder.Pooling = true;
				return mySqlConnectionStringBuilder.ToString();
			}
		}
		public Class7(GClass3 gclass3_1, GClass2 gclass2_1)
		{
			this.gclass3_0 = gclass3_1;
			this.gclass2_0 = gclass2_1;
		}
		public Class6 method_0()
		{
			return new Class6(this);
		}
	}
}
