using Smart_menu;
using System;
using System.Collections.Generic;

namespace Database_Menu
{
	internal class ActionInsertAddress : IMenuPoint
	{
		private IDatabaseController databaseController;

		public ActionInsertAddress(IDatabaseController databseController)
		{
			this.databaseController = databseController;
		}

		public string GetMenuPointName()
		{
			return "Insæt adrasse";
		}

		public void Invoke()
		{
			Console.WriteLine("Intast Gade navn");
			string street = Console.ReadLine();
			Console.WriteLine("Intast Hus nummer");
			string housNb = Console.ReadLine();
			Console.WriteLine("Intast Post Nummer");
			List<string> zipCodes = databaseController.GetZipCodes();
			string zipCode;
			MenuUtility.SearchMenu(zipCodes, out zipCode);
			databaseController.InsertAddress(street, housNb, zipCode);
		}
	}
}