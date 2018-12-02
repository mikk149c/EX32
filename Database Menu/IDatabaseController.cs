using System.Collections.Generic;

namespace Database_Menu
{
	public interface IDatabaseController
	{
		List<string> GetZipCodes();

		void InsertAddress(string street, string housNb, string zipCode);

		string GetAppointmentForPaitient();
	}
}