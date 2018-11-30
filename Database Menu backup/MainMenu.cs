using System;
using Smart_menu;
using Database;

namespace Database_Menu
{
	public class MainMenu
	{
		private DatabseController databseController;

		public MainMenu(DatabseController databseController)
		{
			this.databseController = databseController;
		}

		public void Run()
		{
			Menu menu = new Menu("Main menu");
			menu.AddMenuPoint(new ActionInsertAddress(databseController));
			menu.AddMenuPoint(new ActionShowAppointmentForPaitient(databseController));
			menu.Activate();
		}
	}
}
