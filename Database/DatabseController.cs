using Database_Menu;
using System;
using System.Collections.Generic;

namespace Database
{
	public class DatabaseController : IDatabaseController
	{
		private Database DB;

		public DatabaseController(string connectionString)
		{
			DB = new Database(connectionString);
		}

		public void InsertAddress(string street, string housNb, string zipCode)
		{
			DB.InsertAddress(street, housNb, zipCode);
		}

		public List<string> GetZipCodes()
		{
			return DB.GetZipCodes();
		}

		public string GetAppointmentForPaitient()
		{
			throw new NotImplementedException();
		}
	}
}