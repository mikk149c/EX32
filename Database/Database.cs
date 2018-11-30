using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
	class Database
	{
		private string connectionString;

		public Database(string connectionString)
		{
			this.connectionString = connectionString;
		}

		internal List<string> GetZipCodes()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("SELECT PostNr FROM dbo.PostNrBy", con);
				SqlDataReader reader = cmd.ExecuteReader();
				List<string> zipCodes = new List<string>();
				if (reader.HasRows)
				while (reader.Read())
						zipCodes.Add(reader["PostNr"].ToString());
				return zipCodes;
			}
		}

		internal void InsertAddress(string street, string housNb, string zipCode)
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("IndsætAdresse", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Gade", street);
				cmd.Parameters.AddWithValue("@HusNr", housNb);
				cmd.Parameters.AddWithValue("@PostNr", zipCode);
				cmd.ExecuteNonQuery();
			}
		}
	}
}
