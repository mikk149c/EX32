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
			try
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
			catch (SqlException e)
			{
				Console.WriteLine("Post nummre kunne ikke hæntes fra database\n" + e);
			}
			return null;
		}

		internal void InsertAddress(string street, string housNb, string zipCode)
		{
			try
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
			catch (SqlException e)
			{
				Console.WriteLine($"Kunne ikke insætte adressen i databasen ({street} {housNb} {zipCode})\n" + e);
			}
		}
	}
}
