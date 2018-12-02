using Smart_menu;

namespace Database_Menu
{
	public class MainMenu
	{
		private IDatabaseController databaseController;

		public MainMenu(IDatabaseController databseController)
		{
			this.databaseController = databseController;
		}

		public void Run()
		{
			Menu menu = new Menu("Main menu");
			menu.AddMenuPoint(new ActionInsertAddress(databaseController));
			menu.AddMenuPoint(new ActionShowAppointmentForPaitient(databaseController));
			menu.Activate();
		}
	}
}