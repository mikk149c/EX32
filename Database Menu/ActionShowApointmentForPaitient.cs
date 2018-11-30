using Database;
using Smart_menu;

namespace Database_Menu
{
	internal class ActionShowAppointmentForPaitient : IMenuPoint
	{
		private DatabaseController databaseController;

		public ActionShowAppointmentForPaitient(DatabaseController databseController)
		{
			this.databaseController = databseController;
		}

		public string GetMenuPointName()
		{
			return "Vis aftale for patient";
		}

		public void Invoke()
		{
			databaseController.ShowAppointmentForPaitient();
		}
	}
}