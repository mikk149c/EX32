using System;
using Smart_menu;
using Database;

namespace Database_Menu
{
	public class MainMenu
	{
		private DatabaseController databaseController;

		public MainMenu(DatabaseController databseController)
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
