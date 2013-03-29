using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace ns0
{
	internal sealed class Class6 : IDisposable
	{
		private Class7 class7_0;
		private MySqlConnection mySqlConnection_0;
		private MySqlCommand mySqlCommand_0;
		public Class6(Class7 class7_1)
		{
			this.class7_0 = class7_1;
			this.mySqlConnection_0 = new MySqlConnection(class7_1.String_0);
			this.mySqlCommand_0 = this.mySqlConnection_0.CreateCommand();
			this.mySqlConnection_0.Open();
		}
		public void Dispose()
		{
			this.mySqlConnection_0.Close();
			this.mySqlCommand_0.Dispose();
			this.mySqlConnection_0.Dispose();
		}
		public void method_0(string string_0, object object_0)
		{
			this.mySqlCommand_0.Parameters.AddWithValue(string_0, object_0);
		}
		public void method_1(string string_0)
		{
			this.mySqlCommand_0.CommandText = string_0;
			this.mySqlCommand_0.ExecuteScalar();
			this.mySqlCommand_0.CommandText = null;
		}
		public DataSet method_2(string string_0)
		{
			DataSet dataSet = new DataSet();
			this.mySqlCommand_0.CommandText = string_0;
			using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(this.mySqlCommand_0))
			{
				mySqlDataAdapter.Fill(dataSet);
			}
			this.mySqlCommand_0.CommandText = null;
			return dataSet;
		}
		public DataTable method_3(string string_0)
		{
			DataTable dataTable = new DataTable();
			this.mySqlCommand_0.CommandText = string_0;
			using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(this.mySqlCommand_0))
			{
				mySqlDataAdapter.Fill(dataTable);
			}
			this.mySqlCommand_0.CommandText = null;
			return dataTable;
		}
		public DataRow method_4(string string_0)
		{
			DataTable dataTable = this.method_3(string_0);
			DataRow result;
			if (dataTable != null && dataTable.Rows.Count > 0)
			{
				result = dataTable.Rows[0];
			}
			else
			{
				result = null;
			}
			return result;
		}
		public string method_5(string string_0)
		{
			this.mySqlCommand_0.CommandText = string_0;
			string result = this.mySqlCommand_0.ExecuteScalar().ToString();
			this.mySqlCommand_0.CommandText = null;
			return result;
		}
		public int method_6(string string_0)
		{
			this.mySqlCommand_0.CommandText = string_0;
			int result = int.Parse(this.mySqlCommand_0.ExecuteScalar().ToString());
			this.mySqlCommand_0.CommandText = null;
			return result;
		}
		public uint method_7(string string_0)
		{
			this.mySqlCommand_0.CommandText = string_0;
			uint result = (uint)this.mySqlCommand_0.ExecuteScalar();
			this.mySqlCommand_0.CommandText = null;
			return result;
		}
	}
}
