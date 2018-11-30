using Database;
using Smart_menu;

namespace Database_Menu
{
	internal class ActionShowAppointmentForPaitient : IMenuPoint
	{
		private DatabseController databseController;

		public ActionShowAppointmentForPaitient(DatabseController databseController)
		{
			this.databseController = databseController;
		}

		public string GetMenuPointName()
		{
			return "Vis aftale for patient";
		}

		public void Invoke()
		{
			databseController.ShowAppointmentForPaitient();
		}
	}
}