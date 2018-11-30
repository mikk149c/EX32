using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Database
{
	public class DatabaseController
	{
		private Database DB;

		public DatabaseController(string connectionString)
		{
			DB = new Database(connectionString);
		}

		public void InsertAddress(string street, string housNb, string zipCode)
		{
			try
			{
				DB.InsertAddress(street, housNb, zipCode);
			}
			catch (SqlException e)
			{
				Console.WriteLine($"Kunne ikke insætte adressen i databasen ({street} {housNb} {zipCode})\n" + e);
			}
		}

		public void ShowAppointmentForPaitient()
		{
			throw new NotImplementedException();
		}

		public List<string> GetZipCodes()
		{
			try
			{
				return DB.GetZipCodes();
			}
			catch (SqlException e)
			{
				Console.WriteLine("Post nummre kunne ikke hæntes fra database\n" + e);
			}
			return null;
		}
	}
}
