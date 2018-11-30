using Smart_menu;

namespace Database_Menu
{
	internal class ActionShowAppointmentForPaitient : IMenuPoint
	{
		private IDatabaseController databaseController;

		public ActionShowAppointmentForPaitient(IDatabaseController databseController)
		{
			this.databaseController = databseController;
		}

		public string GetMenuPointName()
		{
			return "Vis aftale for patient";
		}

		public void Invoke()
		{
			string appointment = databaseController.GetAppointmentForPaitient();
			System.Console.WriteLine(appointment);
		}
	}
}