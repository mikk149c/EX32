using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Menu
{
	public interface IDatabaseController
	{
		List<string> GetZipCodes();
		void InsertAddress(string street, string housNb, string zipCode);
		string GetAppointmentForPaitient();
	}
}
